using System.Collections.Generic;

namespace niushuai233.Util
{
    public class CollectionUtil
    {
        public static bool IsEmpty(object[] source)
        {
            return null == source || source.Length == 0;
        }

        public static bool IsNotEmpty(object[] source)
        {
            return !IsEmpty(source);
        }

        public static bool IsEmpty<T>(List<T> source)
        {
            return null == source || source.Count == 0;
        }

        public static bool IsNotEmpty<T>(List<T> source)
        {
            return !IsEmpty<T>(source);
        }
    }
}