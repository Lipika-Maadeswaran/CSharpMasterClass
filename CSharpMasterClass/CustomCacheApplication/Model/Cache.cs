using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomCacheApplication.Model
{
    internal class Cache<TKey, TData>
    {
        private readonly Dictionary<TKey, TData> _cachedData = new();

        public TData GetData(TKey key, Func<TKey, TData> value)
        {
            if (!_cachedData.ContainsKey(key))
            {
                _cachedData[key] = value(key);
            }
            return _cachedData[key];
        }
    }
}
