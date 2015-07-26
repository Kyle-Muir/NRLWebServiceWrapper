using System;
using System.Runtime.Caching;
using NrlWebServiceWrapper.Core;

namespace NrlWebServiceWrapper.Integration
{
    public class CacheItemPolicyGenerator : ICacheItemPolicyGenerator
    {
        public CacheItemPolicy GeneratePolicy(NrlCacheExpiry expiry)
        {
            DateTimeOffset expiryOffset;
            switch (expiry)
            {
                case NrlCacheExpiry.Daily:
                    expiryOffset = new DateTimeOffset(DateTime.Now.AddDays(1));
                    break;
                case NrlCacheExpiry.Hourly:
                    expiryOffset = new DateTimeOffset(DateTime.Now.AddHours(1));
                    break;
                case NrlCacheExpiry.Minutes:
                    expiryOffset = new DateTimeOffset(DateTime.Now.AddMinutes(3));
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