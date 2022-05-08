using niushuai233.Base;
using SwaggerTool;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace niushuai233.Util
{
    public class CommonUtil
    {
        public static MainApplication Instance = null;

        public static void SetMainApplication(MainApplication mainApplication)
        {
            Instance = mainApplication;
        }

        /// <summary>
        /// 配置文件位置
        /// </summary>
        /// <returns>配置文件全路径</returns>
        public static string GetConfigLocationPrefix()
        {
            return CommonConstant.USER_PROFILE_DIRECTORY + "/" + CommonConstant.USER_PROFILE_PROJECT_DIRECTORY + "/" + CommonConstant.PROJECT_NAME + "/";
        }

        public static string GetCurrentProcessFileName()
        {
            return Process.GetCurrentProcess().MainModule.FileName;
        }

        public static string CurrentDirectory()
        {
            return System.Environment.CurrentDirectory;
        }

        /// <summary>
        /// 获取设置文件绝对路径名称
        /// </summary>
        /// <returns></returns>
        public static string ApiPostSettingsLocation()
        {
            return GetConfigLocationPrefix() + CommonConstant.ApiPost;
        }

        /// <summary>
        /// 获取设置文件绝对路径名称
        /// </summary>
        /// <returns></returns>
        public static string ServiceAddrSettingsLocation()
        {
            return GetConfigLocationPrefix() + CommonConstant.ServiceAddr;
        }

        /// <summary>
        /// 建立前置配置文件夹
        /// </summary>
        private static void CreateProjectFolder()
        {
            System.IO.Directory.CreateDirectory(GetConfigLocationPrefix());
        }

        public static T LoadConfig<T>(string path)
        {
            object config = Activator.CreateInstance(typeof(T), true);
            if (!File.Exists(path))
            {
                Console.WriteLine("配置文件不存在, 新建. | " + path);
                CreateProjectFolder();
                XmlUtil.Obj2Xml<T>(path, (T)config);
                return (T)config;
            }

            config = XmlUtil.Xml2Obj<T>(path);
            return (T)config;
        }

        public static MapExt<string, object> Object2Map<T>(T obj, bool ignoreGetMethod = false)
        {
            if (obj is Dictionary<string, object> || obj is MapExt<string, object>)
            {
                return (MapExt<string, object>)Convert.ChangeType(obj, typeof(MapExt<string, object>));
            }

            MapExt<string, object> map = new MapExt<string, object>();

            Type type = obj.GetType();
            PropertyInfo[] properties = type.GetProperties(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.Instance);

            foreach (var property in properties)
            {
                MethodInfo method = property.GetGetMethod();

                if (null == method && !ignoreGetMethod)
                {
                    // 设null
                    map.Put(property.Name, null);
                }
                else
                {
                    // 获取实际值
                    map.Put(property.Name, method.Invoke(obj, new object[] { }));
                }
            }

            return map;
        }

        public static string Data2GetQuery(MapExt<string, object> dict, bool startWithQuestion = true)
        {
            string res = "";
            if (startWithQuestion)
            {
                res += "?";
            }
            foreach (var item in dict)
            {
                res += item.Key + "=" + item.Value + "&";
            }
            return res + "time=" + 1;
        }

        public static MapExt<string, object> Query2Data(string query)
        {
            MapExt<string, object> mapExt = MapExt<string, object>.NullMapExt();

            if (StringUtil.IsNotEmpty(query))
            {
                string[] vs = query.Split('&');

                foreach (var item in vs)
                {
                    string[] ix = item.Split('=');
                    if (ix.Length == 1)
                    {
                        mapExt.Put(ix[0], ix[0]);
                    }
                    else
                    {
                        mapExt.Put(ix[0], ix[1]);
                    }
                }
            }

            return mapExt;
        }

        public static string GetValueByKeyFromUrl(string url, string code)
        {
            Uri uri = new Uri(url);

            string[] paramArr = uri.Query.Split('?');
            if (null != paramArr && 2 == paramArr.Length)
            {
                foreach (var item in paramArr)
                {
                    string[] keyValue = item.Split('=');
                    if (keyValue[0].Equals(code))
                    {
                        return keyValue[1];
                    }
                }
            }

            return "";
        }
    }
}