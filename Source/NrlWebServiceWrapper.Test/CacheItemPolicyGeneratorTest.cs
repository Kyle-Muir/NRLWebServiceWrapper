using System;
using System.Runtime.Caching;
using FluentAssertions;
using NrlWebServiceWrapper.Integration;
using NUnit.Framework;

namespace NrlWebServiceWrapper.Test
{
    [TestFixture]
    public class CacheItemPolicyGeneratorTest
    {
        [Test]
        public void CanGenerateDailyPolicy()
        {
            TestClock testClock = new TestClock();
            testClock.SetNow(TestDates.FridayTenth);
            CacheItemPolicyGenerator generator = new CacheItemPolicyGenerator(testClock);
            CacheItemPolicy cacheItemPolicy = generator.GeneratePolicy(NrlCacheExpiry.Daily);
            cacheItemPolicy.AbsoluteExpiration.Should().Be(new DateTimeOffset(TestDates.FridayTenth.AddDays(1)));
        }

        [Test]
        public void CanGenerateHourlyPolicy()
        {
            TestClock testClock = new TestClock();
            testClock.SetNow(TestDates.FridayTenth);
            CacheItemPolicyGenerator generator = new CacheItemPolicyGenerator(testClock);
            CacheItemPolicy cacheItemPolicy = generator.GeneratePolicy(NrlCacheExpiry.Hourly);
            cacheItemPolicy.AbsoluteExpiration.Should().Be(new DateTimeOffset(TestDates.FridayTenth.AddHours(1)));
        }

        [Test]
        public void CanGenerateMinutesPolicy()
        {
            TestClock testClock = new TestClock();
            testClock.SetNow(TestDates.FridayTenth);
            CacheItemPolicyGenerator generator = new CacheItemPolicyGenerator(testClock);
            CacheItemPolicy cacheItemPolicy = generator.GeneratePolicy(NrlCacheExpiry.Minutes);
            cacheItemPolicy.AbsoluteExpiration.Should().Be(new DateTimeOffset(TestDates.FridayTenth.AddMinutes(3)));
        }
    }
}