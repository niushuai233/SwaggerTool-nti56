using EasyHttp.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using niushuai233.Base;
using niushuai233.Util;
using SwaggerTool.Entity;
using SwaggerTool.Entity.Api;
using SwaggerTool.Entity.ApiPostE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SwaggerTool.Util
{
    public class ProjectUtil
    {
        private const string URL_ENGINEERING = "https://it.nti56.com/api/project/engineering/page";

        private const string URL_LOGIN = "https://it.nti56.com/api/oauth/oauth/token";

        private const string LOGIN_PARAM = "password=b30412c5bed39679f8397da7efc85415&username=niushuai-test&grant_type=pwd&scope=all&client_id=nti_client_id&client_secret=nti_client_secret";

        private const string PAGE_PARAM = "{\"recovery\":0,\"spaceId\":\"1505846267724279809\",\"pageQuery\":{\"page\":1,\"rows\":10},\"name\":\"\",\"published\":null,\"createTimeSort\":2}";

        public static string GetToken()
        {
            MapExt<string, object> param = CommonUtil.Query2Data(LOGIN_PARAM);

            MapExt<string, object> map = HttpUtil.Post<MapExt<string, object>>(URL_LOGIN, param, HttpContentTypes.ApplicationXWwwFormUrlEncoded);

            if ("0".Equals(map.Get("code") + ""))
            {
                string data = map.Get("data").ToString();

                MapExt<string, object> dataMap = JsonConvert.DeserializeObject<MapExt<string, object>>(data);

                return dataMap.Get("accessToken").ToString();
            }

            return null;
        }

        internal static List<Engineering> EngineeringList(string token)
        {
            List<Engineering> list = new List<Engineering>();
            MapExt<string, object> paramMap = new MapExt<string, object>();
            paramMap.Put("recovery", 0);
            paramMap.Put("spaceId", "1505846267724279809");
            // "{\"page\":1,\"rows\":10}"
            MapExt<string, object> page = new MapExt<string, object>();
            page.Put("page", 1);
            page.Put("rows", 100);
            paramMap.Put("pageQuery", page);

            MapExt<string, object> headerMap = new MapExt<string, object>();
            headerMap.Put("authorization", "Bearer " + token);

            MapExt<string, object> mapExt = HttpUtil.Post<MapExt<string, object>>(URL_ENGINEERING, headerMap, paramMap, HttpContentTypes.ApplicationJson);

            if ("0".Equals(mapExt.Get("code") + ""))
            {
                JObject data = (JObject)JsonConvert.DeserializeObject(mapExt.Get("data").ToString());
                JArray records = (JArray)data["records"];

                JToken children = records[0]["children"];

                foreach (var item in children)
                {
                    JObject obj = (JObject)item;
                    if (obj["categorize"].ToString().Equals("12"))
                    {
                        Engineering e = new Engineering()
                        {
                            Id = obj["id"].ToString(),
                            Code = obj["code"].ToString(),
                            Name = obj["name"].ToString()
                        };
                        list.Add(e);
                    }
                }
            }

            return list;
        }

        private static string[] Skip_Fields = new string[] { "tenantId", "factoryId", "createBy", "createTime", "updateBy", "updateTime", "deleted" };

        public static bool FieldNeedSkip(string fieldName)
        {
            // TODO 修改为设置项
            return Skip_Fields.Contains(fieldName);
        }
        public static ApiPost apiPost;
        private static string API_POST_SAVE = "https://console-api.apipost.cn/api/apis/save_target_from_client";
        private static string API_POST_INFO = "https://console-api.apipost.cn/api/apis/info";

        public static void Submit(ApiDocs docs, TreeNodeCollection nodes)
        {

            foreach (TreeNode node in nodes)
            {
                string path = node.Text;
                SubmitItem(path, docs.PathsMap().Get(path), docs.SchemasMap());
            }
        }

        private static void SubmitItem(string pathUrl, Path path, MapExt<string, Schema> schemaMap)
        {
            ApiPostInstance instance = new ApiPostInstance()
            {
                target_id = "",
                parent_id = "0",
                project_id = apiPost.ProjectId,
                mark = "developing",
                target_type = "api",
                sort = 999,
                type_sort = "1",
                mock = "{}",
                mock_url = "",
                version = 1,
                is_changed = -1,
                is_save = 1,
                is_force = 0,
                method = path.MethodType.ToUpper(),
                url = pathUrl,
                name = null == path.Description ? pathUrl : path.Description,
                response = ParseResponse(path),
                request = ParseRequest(path, schemaMap)
            };


            MapExt<string, object> headerMap = MapExt<string, object>.NullMapExt();
            headerMap.Put("token", apiPost.Token);

            HttpUtil.Post<ApiPostInstance>(API_POST_SAVE, headerMap, instance, HttpContentTypes.ApplicationJson);
        }

        private static ApiPostResponse ParseResponse(Path path)
        {

            ApiPostSuccess success = new ApiPostSuccess()
            {
                raw = "",
                parameter = new List<string>()

            };
            ApiPostError error = new ApiPostError() 
            {
                raw = "",
                parameter = new List<string>()
            };
            ApiPostResponse response = new ApiPostResponse()
            {
                success = success,
                error = error
            };
            return response;
        }

        private static ApiPostRequest ParseRequest(Path path, MapExt<string, Schema> schemaMap)
        {
            MapExt<string, object> auth = new MapExt<string, object>();
            auth.Put("type", "noauth");

            // 暂时用不到header
            List<ApiPostParameter> headerParameterList = new List<ApiPostParameter>();

            //get请求用query
            List<ApiPostParameter> queryParameterList = new List<ApiPostParameter>();
            if (path.MethodType.Equals("get"))
            {
                List<Parameter> parameters = path.Parameters;
                if (CollectionUtil.IsNotEmpty(parameters))
                {
                    foreach (Parameter item in parameters)
                    {
                        ApiPostParameter e = new ApiPostParameter()
                        {
                            __DATAKEY__ = Guid.NewGuid().ToString(),
                            is_checked = 1,
                            not_null = 1,
                            type = "Text",
                            field_type = "Text",
                            description = "",
                        };

                        queryParameterList.Add(e);
                    }
                }

            }

            //post用body
            List<ApiPostParameter> bodyParameterList = new List<ApiPostParameter>();
            if (path.MethodType.Equals("post"))
            {
                RequestBody requestBody = path.Body;
                Schema schema = schemaMap.Get(requestBody.SchemaKey);
                if (null != schema)
                {

                }


            }

            ApiPostBody body = new ApiPostBody()
            {
                mode = "json",
                parameter = bodyParameterList,
                raw = "",
                raw_para = new List<string>()
            };

            return new ApiPostRequest()
            {
                url = path.Url,
                description = path.Description,
                auth = auth,
                header = new ApiPostHeader(headerParameterList),
                query = new ApiPostQuery(queryParameterList),
                body = body
            };
        }
    }
}