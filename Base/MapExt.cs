using System;
using System.Collections.Generic;

namespace niushuai233.Base
{
    public class MapExt<TKey, TValue> : Dictionary<string, object>
    {
        public bool IsNullOrEmpty()
        {
            return this.Count == 0;
        }

        public bool IsNotNullOrEmpty()
        {
            return !IsNullOrEmpty();
        }

        public void Put(string key, object value)
        {
            this.Add(key, value);
        }

        public TValue Get(string key)
        {
            try
            {
                return (TValue)this[key];
            }
            catch (Exception)
            {
                return default;
            }
        }

        public static MapExt<TKey, TValue> NullMapExt()
        {
            return new MapExt<TKey, TValue>();
        }
    }
}
