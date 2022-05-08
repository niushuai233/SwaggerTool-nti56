using System;
using System.Text;
using System.Text.RegularExpressions;

namespace niushuai233.Util
{
    internal class StringUtil
    {
        /// <summary>
        /// 字符是否为中文
        /// </summary>
        /// <param name="_char">待判断的字符</param>
        /// <returns></returns>
        public static bool IsChinese(char _char)
        {
            return IsChinese(_char.ToString());
        }

        /// <summary>
        /// 字符串是否为中文
        /// </summary>
        /// <param name="str">待判断的字符串</param>
        /// <returns></returns>
        public static bool IsChinese(string str)
        {
            return Regex.IsMatch(str, @"[\u4e00-\u9fa5]");
        }

        /// <summary>
        /// 字符是否为英文
        /// </summary>
        /// <param name="_char">待判断的字符</param>
        /// <returns></returns>
        public static bool IsEnglish(char _char)
        {
            return IsEnglish(_char.ToString());
        }

        /// <summary>
        /// 字符串是否为英文
        /// </summary>
        /// <param name="str">待判断的字符串</param>
        /// <returns></returns>
        public static bool IsEnglish(string str)
        {
            return Regex.IsMatch(str, @"^[A-Za-z]+$");
        }

        /// <summary>
        /// 是否为中文字符
        /// </summary>
        /// <param name="_char"></param>
        /// <returns></returns>
        public static bool IsSymbolOfChinese(char _char)
        {
            return 2 * _char.ToString().Length == Encoding.Default.GetByteCount(_char.ToString());
        }

        /// <summary>
        /// 是否为英文字符
        /// </summary>
        /// <param name="_char"></param>
        /// <returns></returns>
        public static bool IsSymbolOfEnglish(char _char)
        {
            return _char.ToString().Length == Encoding.Default.GetByteCount(_char.ToString());
        }

        /// <summary>
        /// 字符串是否为空
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static bool IsEmpty(string text)
        {
            return !IsNotEmpty(text);
        }

        /// <summary>
        /// 字符串是否不为空
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static bool IsNotEmpty(string text)
        {
            return null != text && text.Length > 0;
        }

        public static string GetRandomString(int length)
        {
            return GetRandomString(length, true, true, true, true, "");
        }

        public static string GetRandomString(int length, bool useNum, bool useLow, bool useUpp, bool useSpe, string custom)
        {
            byte[] b = new byte[4];
            new System.Security.Cryptography.RNGCryptoServiceProvider().GetBytes(b);
            Random r = new Random(BitConverter.ToInt32(b, 0));
            string s = null, str = custom;
            if (useNum == true) { str += "0123456789"; }
            if (useLow == true) { str += "abcdefghijklmnopqrstuvwxyz"; }
            if (useUpp == true) { str += "ABCDEFGHIJKLMNOPQRSTUVWXYZ"; }
            if (useSpe == true) { str += "!\"#$%&'()*+,-./:;<=>?@[\\]^_`{|}~"; }
            for (int i = 0; i < length; i++)
            {
                s += str.Substring(r.Next(0, str.Length - 1), 1);
            }
            return s;
        }
    }
}