using System;
using System.Globalization;

namespace niushuai233.Util
{
    public class DateUtil
    {
        /// <summary>
        /// 时分秒转为毫秒值
        /// </summary>
        /// <param name="hour">时</param>
        /// <param name="minute">分</param>
        /// <param name="second">秒</param>
        /// <returns>毫秒值</returns>
        public static long HMS2Millisecond(int hour, int minute, int second)
        {
            return ((hour * 60 + minute) * 60 + second) * 1000;
        }

        /// <summary>
        /// 毫秒转为时分秒字符串
        /// </summary>
        /// <param name="millisecond">毫秒值</param>
        /// <returns>时:分:秒 字符串</returns>
        public static string Millisecond2HMS(long millisecond)
        {
            double time = double.Parse(millisecond.ToString());

            DateTime dateTime = DateTime.Parse(DateTime.Now.ToString("1970-01-01 00:00:00")).AddMilliseconds(time);

            return dateTime.Hour + ":" + dateTime.Minute + ":" + dateTime.Second;
        }

        /// <summary>
        /// 根据提供的pattern来格式化时间
        /// </summary>
        /// <param name="pattern">时间格式</param>
        /// <returns></returns>
        public static string Now(string pattern)
        {
            return DateTime.Now.ToString(pattern);
        }

        /// <summary>
        /// 获取当前时间 年月日时分秒
        /// </summary>
        /// <returns>yyyy-MM-dd HH:mm:ss</returns>
        public static string Now()
        {
            return Now("yyyy-MM-dd HH:mm:ss");
        }

        /// <summary>
        /// 格式化为 yyyy-MM-dd
        /// </summary>
        /// <returns>yyyy-MM-dd</returns>
        public static string FormatNowDate()
        {
            return Now("yyyy-MM-dd");
        }

        /// <summary>
        /// 格式化为 HH:mm:ss
        /// </summary>
        /// <returns>HH:mm:ss</returns>
        public static string FormatNowTime()
        {
            return Now("HH:mm:ss");
        }

        internal static long ToUnixTimeSeconds(DateTime dt)
        {
            return new DateTimeOffset(dt).ToUnixTimeSeconds();
        }

        internal static long ToUnixTimeMilliseconds(DateTime dt)
        {
            return new DateTimeOffset(dt).ToUnixTimeMilliseconds();
        }

        /// <summary>
        /// 格式化为 HH:mm:ss:fff
        /// </summary>
        /// <returns>HH:mm:ss:fff</returns>
        public static string FormatNowTimeWithMillisecond()
        {
            return Now("HH:mm:ss:fff");
        }

        /// <summary>
        /// 格式化时间 可提供格式
        /// </summary>
        /// <param name="dt">时间</param>
        /// <param name="pattern">提供的格式</param>
        /// <returns>pattern</returns>
        public static string Format(DateTime dt, string pattern = "yyyy-MM-dd HH:mm:ss")
        {
            return dt.ToString(pattern);
        }

        /// <summary>
        /// 格式化时间 可提供格式
        /// </summary>
        /// <param name="dt">时间</param>
        /// <returns>yyyy-MM-dd HH:mm:ss</returns>
        public static string FormatDateTime(DateTime dt)
        {
            return Format(dt, "yyyy-MM-dd HH:mm:ss");
        }

        /// <summary>
        /// 格式化时间 可提供格式
        /// </summary>
        /// <param name="dt">时间</param>
        /// <returns>yyyy-MM-dd</returns>
        public static string FormatDate(DateTime dt)
        {
            return Format(dt, "yyyy-MM-dd");
        }

        /// <summary>
        /// 格式化时间 可提供格式
        /// </summary>
        /// <param name="dt">时间</param>
        /// <returns>HH:mm:ss</returns>
        public static string FormatTime(DateTime dt)
        {
            return Format(dt, "HH:mm:ss");
        }

        /// <summary>
        /// 格式化时间 可提供格式
        /// </summary>
        /// <param name="dt">时间</param>
        /// <returns>HH:mm:ss:fff</returns>
        public static string FormatTimeWithMillisecond(DateTime dt)
        {
            return Format(dt, "HH:mm:ss:fff");
        }

        /// <summary>
        /// 格式化时间 可提供格式
        /// </summary>
        /// <param name="dt">时间</param>
        /// <returns>yyyy-MM-dd HH:mm:ss:fff</returns>
        public static string FormatDateTimeWithMillisecond(DateTime dt)
        {
            return Format(dt, "yyyy-MM-dd HH:mm:ss:fff");
        }

        /// <summary>
        /// 秒转DateTime
        /// </summary>
        /// <param name="seconds">秒值</param>
        /// <returns>DateTime对象</returns>
        public static DateTime Second2DateTime(long seconds)
        {
            return Millisecond2DateTime(seconds * 1000);
        }

        /// <summary>
        /// 毫秒转DateTime
        /// </summary>
        /// <param name="millis">毫秒值</param>
        /// <returns>DateTime对象</returns>
        public static DateTime Millisecond2DateTime(long millis)
        {
            // 当地时区
            DateTime startTime = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1));
            DateTime dt = startTime.AddMilliseconds(millis);

            return dt;
        }

        /// <summary>
        /// 封装为时间对象
        /// </summary>
        /// <param name="source">文本时间</param>
        /// <param name="pattern">格式</param>
        /// <returns>pattern</returns>
        public static DateTime Parse(string source, string pattern = "yyyy-MM-dd HH:mm:ss")
        {
            return DateTime.ParseExact(source, pattern, CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// 封装为时间对象
        /// </summary>
        /// <param name="source">文本时间</param>
        /// <returns>pattern</returns>
        public static DateTime ParseDate(string source)
        {
            return Parse(source, "yyyy-MM-dd");
        }

        /// <summary>
        /// 封装为时间对象
        /// </summary>
        /// <param name="source">文本时间</param>
        /// <returns>pattern</returns>
        public static DateTime ParseTime(string source)
        {
            return Parse(source, "HH:mm:ss");
        }

        /// <summary>
        /// 封装为时间对象
        /// </summary>
        /// <param name="source">文本时间</param>
        /// <returns>pattern</returns>
        public static DateTime ParseDateTime(string source)
        {
            return Parse(source);
        }

        /// <summary>
        /// 封装为时间对象
        /// </summary>
        /// <param name="source">文本时间</param>
        /// <returns>pattern</returns>
        public static DateTime ParseDateTimeWithMilliseconds(string source)
        {
            return Parse(source, "yyyy-MM-dd HH:mm:ss:fff");
        }

        /// <summary>
        /// 比较两个日期 <br/>
        /// <br/>
        ///  -1表示 dt1 &lt; dt2 <br/>
        ///  0表示 dt1 = dt2 <br/>
        ///  1表示 dt1 &gt; dt2
        /// </summary>
        /// <param name="dt1"></param>
        /// <param name="dt2"></param>
        /// <returns></returns>
        public static int Compare(DateTime dt1, DateTime dt2)
        {
            if (null == dt1 || null == dt2)
            {
                throw new NotSupportedException("比较的时间不能为空");
            }

            long dt1ms = dt1.Ticks;
            long dt2ms = dt2.Ticks;

            return dt1ms.Equals(dt2ms) ? 0 : (dt1ms < dt2ms ? -1 : 1);
        }

        public static bool Equals(DateTime currTime, DateTime baseTime)
        {
            return Compare(currTime, baseTime) == 0;
        }

        public static bool Before(DateTime currTime, DateTime baseTime)
        {
            return Compare(currTime, baseTime) == -1;
        }

        public static bool After(DateTime currTime, DateTime baseTime)
        {
            return Compare(currTime, baseTime) == 1;
        }

        public static TimeSpan Diff(DateTime dt1, DateTime dt2)
        {
            TimeSpan ts1 = new TimeSpan(dt1.Ticks);
            TimeSpan ts2 = new TimeSpan(dt2.Ticks);

            return ts1.Subtract(ts2).Duration();
        }
    }
}