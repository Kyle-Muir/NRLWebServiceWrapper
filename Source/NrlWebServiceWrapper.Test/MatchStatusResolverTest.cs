using System;
using FluentAssertions;
using NrlWebServiceWrapper.Core.Domain;
using NrlWebServiceWrapper.Integration.Builder;
using NUnit.Framework;

namespace NrlWebServiceWrapper.Test
{
    [TestFixture]
    public class MatchStatusResolverTest
    {
        [TestCase("F", MatchStatus.Finished)]
        [TestCase("P", MatchStatus.InProgress)]
        [TestCase("N", MatchStatus.NotYetStarted)]
        public void CanResolveMatchStatuses(string status, MatchStatus expectedMatchStatus)
        {
            MatchStatus actual = MatchStatusResolver.Resolve(status);
            actual.Should().Be(expectedMatchStatus);
        }

        [TestCase(MatchStatus.Finished, "Finished")]
        [TestCase(MatchStatus.InProgress, "In progress")]
        [TestCase(MatchStatus.NotYetStarted, "Not yet started")]
        public void CanResolveMatchStatusesForDisplayValues(MatchStatus matchStatus, string expectedStatus)
        {
            string actual = MatchStatusResolver.Resolve(matchStatus);
            actual.Should().Be(expectedStatus);
        }

        [Test, ExpectedException(typeof(ArgumentException))]
        public void ShouldThrowAnExceptionWhenPassedARubbishStatus()
        {
            MatchStatusResolver.Resolve("BLAH!");
        }

        [Test, ExpectedException(typeof(ArgumentException))]
        public void ShouldThrowAnExceptionWhenPassedARubbishStatusForDisplayValues()
        {
            MatchStatusResolver.Resolve((MatchStatus)8);
        }
    }
}