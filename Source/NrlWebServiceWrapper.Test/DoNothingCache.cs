using System;
using NrlWebServiceWrapper.Integration;

namespace NrlWebServiceWrapper.Test
{
    internal class DoNothingCache : INrlCache
    {
        private object _cacheObject;

        public object Get(string key)
        {
            return _cacheObject;
        }

        public void Add<T>(string key, T item, NrlCacheExpiry expiry)
        {
            _cacheObject = item;
        }

        public T TryGetSet<T>(string key, Func<T> actionToLoadData, NrlCacheExpiry cacheExpiry)
        {
            return actionToLoadData.Invoke();
        }
    }
}