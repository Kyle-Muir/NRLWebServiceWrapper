using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.ServiceModel;
using System.Xml;
using System.Xml.Serialization;
using NrlWebServiceWrapper.Core;
using NrlWebServiceWrapper.Integration.Contracts;
using NrlWebServiceWrapper.Integration.RugbyLeagueWebService;

namespace NrlWebServiceWrapper.Integration
{
    public class NrlRepository : INrlRepository
    {
        private readonly Uri _endpoint;
        private readonly int _clientId;
        private readonly INrlCache _nrlCache;

        public NrlRepository(Uri endpoint, INrlCache nrlCache, int clientId)
        {
            if (endpoint == null) throw new ArgumentNullException("endpoint");
            if (nrlCache == null) throw new ArgumentNullException("nrlCache");
            _endpoint = endpoint;
            _clientId = clientId;
            _nrlCache = nrlCache;
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
                    XmlSerializer serializer = new XmlSerializer(typeof (Fixture));
                    Fixture fixture = (Fixture) serializer.Deserialize(new StringReader(fixtureAsXml.OuterXml));

                    FixtureEvent currentRoundFixture =
                        fixture.Event.FirstOrDefault(i => i.StartDateTime.Date == firstFridayOfRound.Date);
                    if (currentRoundFixture == null)
                    {
                        throw new ArgumentException("Unable to track down current round.");
                    }

                    IEnumerable<FixtureEvent> currentRoundFixtures =
                        fixture.Event.Where(round => round.roundId == currentRoundFixture.roundId);

                    return
                        currentRoundFixtures.Select(
                            item => new MatchUp(item.Round, item.Match, item.Venue.Value, item.StartDateTimeUTC));

                }
            };
            return _nrlCache.TryGetSet(key, loadMatchupsFromApi, NrlCacheExpiry.Daily);
        }
    }
}