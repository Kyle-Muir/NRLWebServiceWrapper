using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.ServiceModel;
using System.Xml;
using System.Xml.Serialization;
using NrlWebServiceWrapper.Core;
using NrlWebServiceWrapper.Core.Domain;
using NrlWebServiceWrapper.Integration.Builder;
using NrlWebServiceWrapper.Integration.Contracts;
using NrlWebServiceWrapper.Integration.RugbyLeagueWebService;

namespace NrlWebServiceWrapper.Integration
{
    public class NrlRepository : INrlRepository
    {
        private readonly Uri _endpoint;
        private readonly int _clientId;
        private readonly INrlCache _nrlCache;
        //TODO: currently hardcoded to NRL premiership 2015, resolve this by current NRL premiership season from GetLeagues
        private const int SeriesId = 151;

        public NrlRepository(Uri endpoint, INrlCache nrlCache, int clientId)
        {
            if (endpoint == null) throw new ArgumentNullException("endpoint");
            if (nrlCache == null) throw new ArgumentNullException("nrlCache");
            _endpoint = endpoint;
            _nrlCache = nrlCache;
            _clientId = clientId;
        }

        private RugbyLeagueSoapClient CreateRugbyLeagueSoapClient()
        {
            return new RugbyLeagueSoapClient(new BasicHttpBinding(BasicHttpSecurityMode.None), new EndpointAddress(_endpoint));
        }

        public IEnumerable<MatchUp> LoadCurrentRoundMatchUps(DateTime firstFridayOfRound)
        {
            string key = "LoadCurrentRoundMatchUps_{0}".FormatWith(firstFridayOfRound.ToShortDateString());
            Func<IEnumerable<MatchUp>> loadMatchupsFromApi = () =>
            {
                using (RugbyLeagueSoapClient client = CreateRugbyLeagueSoapClient())
                {
                    XmlNode fixtureAsXml = client.GetFixture(_clientId);
                    XmlSerializer serializer = new XmlSerializer(typeof(Fixture));
                    Fixture fixture = (Fixture)serializer.Deserialize(new StringReader(fixtureAsXml.OuterXml));

                    FixtureEvent currentRoundFixture =
                        fixture.Event.FirstOrDefault(i => i.StartDateTime.Date == firstFridayOfRound.Date);
                    if (currentRoundFixture == null)
                    {
                        throw new ArgumentException("Unable to track down current round.");
                    }

                    IEnumerable<FixtureEvent> currentRoundFixtures =
                        fixture.Event.Where(round => round.roundId == currentRoundFixture.roundId);

                    return
                        currentRoundFixtures.Select(item => new MatchUpBuilder(item).Build());

                }
            };
            return _nrlCache.TryGetSet(key, loadMatchupsFromApi, NrlCacheExpiry.Daily);
        }

        public MatchScorecard LoadMatchScorecard(int matchId)
        {
            string key = "LoadScorecard_{0}".FormatWith(matchId);
            MatchScorecard result = _nrlCache.Get(key) as MatchScorecard;
            if (result != null)
            {
                return result;
            }

            using (RugbyLeagueSoapClient client = CreateRugbyLeagueSoapClient())
            {
                XmlNode mainScorecard = client.GetMainScorecard(_clientId, SeriesId, matchId);
                XmlSerializer serializer = new XmlSerializer(typeof(Scorecard));
                Scorecard scorecard = (Scorecard)serializer.Deserialize(new StringReader(mainScorecard.OuterXml));

                result = new MatchScorecardBuilder(scorecard).Build();
                //TODO: cache all games yet to start up until their start date as an absolute expiry.
                if (result.Status == MatchStatus.Live)
                {
                    _nrlCache.Add(key, result, NrlCacheExpiry.Minutes);
                }
                else
                {
                    _nrlCache.Add(key, result, NrlCacheExpiry.Daily);
                }
                return result;
            }
        }
    }
}

