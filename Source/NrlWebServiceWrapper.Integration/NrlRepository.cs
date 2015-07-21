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

        public NrlRepository(Uri endpoint, int clientId)
        {
            if (endpoint == null) throw new ArgumentNullException("endpoint");
            _endpoint = endpoint;
            _clientId = clientId;
        }

        public int LoadCurrentRound()
        {
            using (RugbyLeagueSoapClient client = CreateRugbyLeagueSoapClient())
            {
                XmlNode item = client.GetCompetitionList(_clientId);
                XmlSerializer serializer = new XmlSerializer(typeof(SeriesList));
                SeriesList seriesList = (SeriesList)serializer.Deserialize(new StringReader(item.InnerXml));
                SeriesListSeries listSeries = seriesList.Series.First(value => value.seriesId == 151);
                int currentRoundId = listSeries.currentRoundId;
                return ProcessCurrentRoundId(currentRoundId);
            }
        }

        private int ProcessCurrentRoundId(int currentRoundId)
        {
            DateTime today = DateTime.Today;
            //TODO: When does this switch over???
            if (today.DayOfWeek == DayOfWeek.Tuesday || today.DayOfWeek == DayOfWeek.Wednesday)
            {
                return currentRoundId + 1;
            }
            return currentRoundId;
        }

        private RugbyLeagueSoapClient CreateRugbyLeagueSoapClient()
        {
            return new RugbyLeagueSoapClient(new BasicHttpBinding(BasicHttpSecurityMode.None), new EndpointAddress(_endpoint));
        }

        public IEnumerable<MatchUp> LoadCurrentRoundMatchUps(int roundNumber)
        {
            using (RugbyLeagueSoapClient client = CreateRugbyLeagueSoapClient())
            {
                XmlNode item = client.GetFixture(_clientId);
                XmlSerializer serializer = new XmlSerializer(typeof (Fixture));
                Fixture fixture = (Fixture) serializer.Deserialize(new StringReader(item.OuterXml));
                IEnumerable<FixtureEvent> currentRoundFixtures = fixture.Event.Where(i => i.roundId == roundNumber);
                return
                    currentRoundFixtures.Select(
                        currentRoundFixture =>
                            new MatchUp(currentRoundFixture.Round, currentRoundFixture.Match,
                                currentRoundFixture.Venue.Value, currentRoundFixture.StartDateTimeUTC));

            }
        }
    }
}