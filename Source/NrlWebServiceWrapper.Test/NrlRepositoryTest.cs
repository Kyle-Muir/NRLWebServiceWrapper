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
        public void CanLoadCurrentRound()
        {
            NrlRepository repository = CreateNrlRepository();
            int currentRound = repository.LoadCurrentRound();
            Console.WriteLine(currentRound);
            currentRound.Should().NotBe(-1, "Should have a reasonable value");
        }

        [Test]
        public void CanLoadGamesForCurrentRound()
        {
            NrlRepository repository = CreateNrlRepository();
            IEnumerable<MatchUp> currentRoundMatchUps = repository.LoadCurrentRoundMatchUps(19);
            currentRoundMatchUps.Should().NotBeNull("There should be some games being played");
        }

        private static NrlRepository CreateNrlRepository()
        {
            return new NrlRepository(new Uri("http://rbl.webservice.sportsflash.com.au/WebService.asmx"), 151);
        }
    }
}
