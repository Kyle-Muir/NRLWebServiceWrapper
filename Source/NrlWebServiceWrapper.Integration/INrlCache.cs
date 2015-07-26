using System;

namespace NrlWebServiceWrapper.Integration
{
    public interface INrlCache
    {
        T TryGetSet<T>(string key, Func<T> actionToLoadData, NrlCacheExpiry cacheExpiry);
    }
}