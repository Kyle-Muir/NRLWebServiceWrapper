using System;
using System.Runtime.Caching;

namespace NrlWebServiceWrapper.Integration
{
    public class NrlCache : INrlCache
    {
        private readonly MemoryCache _memoryCache;
        private readonly ICacheItemPolicyGenerator _cacheItemPolicyGenerator;

        public NrlCache(MemoryCache memoryCache, ICacheItemPolicyGenerator cacheItemPolicyGenerator)
        {
            if (memoryCache == null) throw new ArgumentNullException("memoryCache");
            if (cacheItemPolicyGenerator == null) throw new ArgumentNullException("cacheItemPolicyGenerator");

            _memoryCache = memoryCache;
            _cacheItemPolicyGenerator = cacheItemPolicyGenerator;
        }

        private object Get(string key)
        {
            return _memoryCache.Get(key);
        }

        private void Add<T>(string key, T item, NrlCacheExpiry expiry)
        {
            CacheItemPolicy cacheItemPolicy = _cacheItemPolicyGenerator.GeneratePolicy(expiry);
            _memoryCache.Add(key, item, cacheItemPolicy);
        }

        public T TryGetSet<T>(string key, Func<T> actionToLoadData, NrlCacheExpiry expiry)
        {
            object result = Get(key);
            if (result == null)
            {
                T item = actionToLoadData.Invoke();
                Add(key, item, expiry);
                return item;
            }
            return (T)result;
        }
    }
}