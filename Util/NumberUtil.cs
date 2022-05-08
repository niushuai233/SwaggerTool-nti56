namespace niushuai233.Util
{
    internal class NumberUtil
    {
        /// <summary>
        /// 字符是否为英文
        /// </summary>
        /// <param name="_char">待判断的字符</param>
        /// <returns></returns>
        public static bool IsNumber(char _char)
        {
            return IsNumber(_char.ToString());
        }

        /// <summary>
        /// 字符串是否为数字
        /// </summary>
        /// <param name="str">待判断的字符串</param>
        /// <returns></returns>
        public static bool IsNumber(string str)
        {
            if (int.TryParse(str, out _))
            {
                return true;
            }
            return false;
        }
    }
}