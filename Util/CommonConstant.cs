using System;

namespace niushuai233.Util
{
    public class CommonConstant
    {
        /// <summary>
        /// 用户主目录
        /// </summary>
        public static string USER_PROFILE_DIRECTORY = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);

        /// <summary>
        /// 项目作者目录
        /// </summary>
        public static string USER_PROFILE_PROJECT_DIRECTORY = "niushuai233";

        /// <summary>
        /// 项目名称
        /// </summary>
        public static string PROJECT_NAME = "SwaggerTool";

        /// <summary>
        /// 服务设置文件名
        /// </summary>
        public static string ServiceAddr = "ServiceAddr.xml";

        /// <summary>
        /// ApiPost设置文件名
        /// </summary>
        public static string ApiPost = "ApiPost.xml";
    }
}