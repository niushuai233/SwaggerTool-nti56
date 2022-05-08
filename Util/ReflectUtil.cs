using System;
using System.Reflection;

namespace niushuai233.Util
{
    public class ReflectUtil
    {
        public static FieldInfo[] GetAllField<T>()
        {
            Type type = typeof(T);

            FieldInfo[] fieldInfos = type.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public | BindingFlags.Static);

            return fieldInfos;
        }
    }
}