using System;
using System.Collections.Generic;
using FluentAssertions;
using NrlWebServiceWrapper.Core;
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

        private static NrlRepository CreateNrlRepository()
        {
            return new NrlRepository(new Uri("http://rbl.webservice.sportsflash.com.au/WebService.asmx"), 151);
        }
    }
}
