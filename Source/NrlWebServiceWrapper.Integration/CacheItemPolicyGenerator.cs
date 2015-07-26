using System;
using System.Runtime.Caching;
using NrlWebServiceWrapper.Core;

namespace NrlWebServiceWrapper.Integration
{
    public class CacheItemPolicyGenerator : ICacheItemPolicyGenerator
    {
        private readonly IClock _clock;

        public CacheItemPolicyGenerator(IClock clock)
        {
            if (clock == null) throw new ArgumentNullException("clock");
            _clock = clock;
        }

        public CacheItemPolicy GeneratePolicy(NrlCacheExpiry expiry)
        {
            DateTimeOffset expiryOffset;
            switch (expiry)
            {
                case NrlCacheExpiry.Daily:
                    expiryOffset = new DateTimeOffset(_clock.Now.AddDays(1));
                    break;
                case NrlCacheExpiry.Hourly:
                    expiryOffset = new DateTimeOffset(_clock.Now.AddHours(1));
                    break;
                case NrlCacheExpiry.Minutes:
                    expiryOffset = new DateTimeOffset(_clock.Now.AddMinutes(3));
                    break;
                default:
                    throw new ArgumentException(
                        "Unable to generate an offset for an expiry of type: {0}".FormatWith(expiry));
            }
            return new CacheItemPolicy
            {
                AbsoluteExpiration = expiryOffset
            };
        }
    }
}