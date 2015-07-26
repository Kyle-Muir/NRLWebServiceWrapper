using System;
using NrlWebServiceWrapper.Integration;

namespace NrlWebServiceWrapper.Test
{
    internal class DoNothingCache : INrlCache
    {
        public T TryGetSet<T>(string key, Func<T> actionToLoadData, NrlCacheExpiry cacheExpiry)
        {
            return actionToLoadData.Invoke();
        }
    }
}