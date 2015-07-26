using System.Runtime.Caching;

namespace NrlWebServiceWrapper.Integration
{
    public interface ICacheItemPolicyGenerator
    {
        CacheItemPolicy GeneratePolicy(NrlCacheExpiry expiry);
    }
}