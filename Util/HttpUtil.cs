using EasyHttp.Http;
using Newtonsoft.Json;
using niushuai233.Base;
using System;

namespace niushuai233.Util
{
    public class HttpUtil
    {
        private static HttpClient client = new HttpClient();
        private const string USER_AGENT = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/96.0.4664.45 Safari/537.36";

        private const string METHOD_GET = "GET";

        private const string METHOD_POST = "POST";

        private HttpUtil()
        { }

        public static T Post<T>(string url, MapExt<string, object> headerMap, object data, string contentType)
        {
            // data转mapExt 防止easyhttp转换为帕斯卡命名
            MapExt<string, object> _data = CommonUtil.Object2Map(data);

            client.Request.Accept = "*/*";
            client.Request.ContentType = contentType;
            //client.Request.RawHeaders.Add("Accept", "*/*");

            client.Request.RawHeaders.Clear();
            foreach (var item in headerMap)
            {
                client.Request.RawHeaders.Add(item.Key, item.Value);
            }

            HttpResponse response = client.Post(url, _data, contentType);

            string res = response.RawText;
            Console.WriteLine("///////////////////////////////////////////////////////////////////////////////////////////////");
            Console.WriteLine("post request url [{0}]\nres [{1}]", url, res);
            Console.WriteLine("///////////////////////////////////////////////////////////////////////////////////////////////");
            try
            {
                return JsonConvert.DeserializeObject<T>(res);
            }
            catch (Exception e)
            {
                Console.WriteLine("反序列化对象失败: {0} | {1}", res, e.Message);
                return default;
            }
        }

        public static T Post<T>(string url, object data, string contentType)
        {
            return Post<T>(url, MapExt<string, object>.NullMapExt(), data, contentType);
        }

        public static T Get<T>(string url, object data)
        {
            // data转MapExt 防止easyhttp转换为帕斯卡命名
            MapExt<string, object> _data = CommonUtil.Object2Map(data);

            string _query = CommonUtil.Data2GetQuery(_data);

            url = url + _query;

            client.Request.Accept = "*/*";
            HttpResponse response = client.Get(url);

            string res = response.RawText;
            Console.WriteLine("///////////////////////////////////////////////////////////////////////////////////////////////");
            Console.WriteLine("get request url [{0}]\nres [{1}]", url, res);
            Console.WriteLine("///////////////////////////////////////////////////////////////////////////////////////////////");
            try
            {
                return JsonConvert.DeserializeObject<T>(res);
            }
            catch (Exception e)
            {
                Console.WriteLine("反序列化对象失败: {0} | {1}", res, e.Message);
                return default;
            }
        }
    }
}