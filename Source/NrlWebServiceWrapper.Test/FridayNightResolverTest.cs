using System;
using FluentAssertions;
using NrlWebServiceWrapper.Core;
using NUnit.Framework;

namespace NrlWebServiceWrapper.Test
{
    [TestFixture]
    public class FridayNightResolverTest
    {
        private IFridayNightResolver _resolver;

        [SetUp]
        public void SetUp()
        {
            _resolver = new FridayNightResolver();
        }

        [Test]
        public void ShouldResolveCorrectFridaysForFriday()
        {
            DateTime friday = _resolver.FindFridayNightRound(TestDates.FridayTenth);
            friday.Should().Be(TestDates.FridayTenth);
        }
        [Test]
        public void ShouldResolveCorrectFridaysForSaturday()
        {
            DateTime friday = _resolver.FindFridayNightRound(TestDates.SaturdayEleventh);
            friday.Should().Be(TestDates.FridayTenth);
        }
        [Test]
        public void ShouldResolveCorrectFridaysForSunday()
        {
            DateTime friday = _resolver.FindFridayNightRound(TestDates.SundayTwelfth);
            friday.Should().Be(TestDates.FridayTenth);
        }
        [Test]
        public void ShouldResolveCorrectFridaysForMonday()
        {
            DateTime friday = _resolver.FindFridayNightRound(TestDates.MondayThirteenth);
            friday.Should().Be(TestDates.FridayTenth);
        }
        [Test]
        public void ShouldResolveCorrectFridaysForTuesday()
        {
            DateTime friday = _resolver.FindFridayNightRound(TestDates.TuesdayFourteenth);
            friday.Should().Be(TestDates.FridaySeventeenth);
        }
        [Test]
        public void ShouldResolveCorrectFridaysForWednesday()
        {
            DateTime friday = _resolver.FindFridayNightRound(TestDates.WednesdayFifteenth);
            friday.Should().Be(TestDates.FridaySeventeenth);
        }
        [Test]
        public void ShouldResolveCorrectFridaysForThursday()
        {
            DateTime friday = _resolver.FindFridayNightRound(TestDates.ThursdaySixteenth);
            friday.Should().Be(TestDates.FridaySeventeenth);
        }
    }
}