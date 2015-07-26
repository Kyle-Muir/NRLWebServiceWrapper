using System;

namespace NrlWebServiceWrapper.Integration
{
    public interface INrlCache
    {
        object Get(string key);
        void Add<T>(string key, T item, NrlCacheExpiry expiry);
        T TryGetSet<T>(string key, Func<T> actionToLoadData, NrlCacheExpiry expiry);
    }
}