using System;
using System.Collections.Generic;
using FluentAssertions;
using NrlWebServiceWrapper.Core;
using NrlWebServiceWrapper.Core.Domain;
using NrlWebServiceWrapper.Integration;
using NUnit.Framework;

namespace NrlWebServiceWrapper.Test
{
    [TestFixture]
    public class NrlRepositoryTest
    {
        [Test]
        public void CanLoadGamesForCurrentRound()
        {
            NrlRepository repository = CreateNrlRepository();
            DateTime firstFridayOfRound = TestDates.FridaySeventeenth.AddDays(7);
            IEnumerable<MatchUp> currentRoundMatchUps = repository.LoadCurrentRoundMatchUps(firstFridayOfRound);
            currentRoundMatchUps.Should().NotBeNull("There should be some games being played");
        }

        [Test]
        public void CanLoadScoreForCurrentGame()
        {
            NrlRepository nrlRepository = CreateNrlRepository();
            const int stormVsDragons = 141;
            MatchScorecard matchScorecard = nrlRepository.LoadMatchScorecard(stormVsDragons);
            
            matchScorecard.Status.Should().Be(MatchStatus.Finished, "Game is in the past");
            matchScorecard.HomeTeam.Name.Should().Be("Storm");
            matchScorecard.HomeTeam.Points.Should().Be(22);
            matchScorecard.AwayTeam.Name.Should().Be("Dragons");
            matchScorecard.AwayTeam.Points.Should().Be(4);
        }

        private static NrlRepository CreateNrlRepository()
        {
            return new NrlRepository(new Uri("http://rbl.webservice.sportsflash.com.au/WebService.asmx"), new DoNothingCache(),  151);
        }
    }
}
