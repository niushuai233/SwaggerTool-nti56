using Newtonsoft.Json.Linq;
using niushuai233.Base;
using niushuai233.Util;
using SwaggerTool.Entity;
using SwaggerTool.Entity.Api;
using SwaggerTool.Forms.Settings;
using SwaggerTool.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SwaggerTool
{
    public partial class MainApplication : Form
    {
        private ApiDocs apiDocs;
        public MainApplication()
        {
            InitializeComponent();

            // 初始化服务列表
            InitializeServiceAddr();
            // 初始化平台工程列表
            InitializeTargetServiceAddr();
            InitializeApiPost();

            this.textBox_keyword.Focus();
        }

        private void InitializeApiPost()
        {
            ApiPostForm apiPost = new ApiPostForm();
            apiPost.ShowDialog(this);

        }

        /// <summary>
        /// 从配置文件中加载服务列表
        /// </summary>
        private void InitializeServiceAddr()
        {
            ServiceAddr serviceAddr = CommonUtil.LoadConfig<ServiceAddr>(CommonUtil.ServiceAddrSettingsLocation());
            this.comboBox_serviceAddr.Items.Clear();
            if (CollectionUtil.IsNotEmpty(serviceAddr.ServerList))
            {
                foreach (var item in serviceAddr.ServerList)
                {
                    this.comboBox_serviceAddr.Items.Add(item);
                }
                this.comboBox_serviceAddr.SelectedIndex = 0;
            } 
            else
            {
                // 数据为空 初始化一堆数据进去
                serviceAddr.ServerList = ServiceList();
                XmlUtil.Obj2Xml<ServiceAddr>(CommonUtil.ServiceAddrSettingsLocation(), serviceAddr);
                InitializeServiceAddr();
            }
        }

        private List<string> ServiceList()
        {
            return new List<string>()
            {
                "http://nti56.niushuai.cc:58092/v3/api-docs",
                "http://localhost:8092/v3/api-docs",
                "http://localhost:8093/v3/api-docs",
                "http://localhost:8094/v3/api-docs",
                "http://localhost:8095/v3/api-docs",
                "http://localhost:8096/v3/api-docs",
                "http://localhost:8097/v3/api-docs"
            };
        }

        /// <summary>
        /// 取平台工程列表中分类为自定义后端工程
        /// </summary>
        private void InitializeTargetServiceAddr()
        {
            // 登陆 
            string token = ProjectUtil.GetToken();
            // 请求列表
            List<Engineering> engineeringList = ProjectUtil.EngineeringList(token);

            this.comboBox_serviceTarget.Items.Clear();
            foreach (var item in engineeringList)
            {
                string e = item.Name + "_" + item.Id;
                this.comboBox_serviceTarget.Items.Add(e);
            }
            this.comboBox_serviceTarget.SelectedIndex = 0;
        }

        /// <summary>
        /// 退出 关闭应用程序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            InitializeServiceAddr();
            InitializeTargetServiceAddr();
        }

        private void button_submitTarget_Click(object sender, EventArgs e)
        {
            ProjectUtil.Submit(apiDocs, this.treeView_apiDocs_selected.Nodes);
        }

        private void Settings_ServiceAddr_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ServiceAddrSetForm serviceAddrSetForm = new ServiceAddrSetForm();

            serviceAddrSetForm.ShowDialog(this);
        }

        private void apiPostToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InitializeApiPost();
        }

        private void comboBox_serviceAddr_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 得到实际地址
            ComboBox box = (ComboBox)sender;
            string url = box.SelectedItem.ToString();
            // 请求接口
            JObject apiData = HttpUtil.Get<JObject>(url, MapExt<string, object>.NullMapExt());
            // 解析数据结构 组合成需要的数据结构
            apiDocs = ParseApiObj(apiData);

            // 显示到treeView控件中
            TreeShow(null);
        }

        private void TreeShow(string keyword)
        {
            this.treeView_apiDocs.Nodes.Clear();

            foreach (var path in apiDocs.Paths)
            {
                if (StringUtil.IsEmpty(keyword))
                {
                    this.treeView_apiDocs.Nodes.Add(path.Url);
                }
                else if(path.Url.Contains(keyword) || (null != path.Description && path.Description.Contains(keyword)))
                {
                    this.treeView_apiDocs.Nodes.Add(path.Url);
                }
            }
        }

        private ApiDocs ParseApiObj(JObject data)
        {
            ApiDocs docs = new ApiDocs
            {
                OpenApi = data["openapi"].ToString(),
                Info = data["info"].ToString(),
                Schemas = ParseApiSchemas(data["components"]),
                Paths = ParseApiPaths(data["paths"])
            };

            return docs;
        }

        private List<Schema> ParseApiSchemas(JToken jToken)
        {
            List<Schema> schemas = new List<Schema>();

            JEnumerable<JToken> elems = jToken["schemas"].Children();

            foreach (var item in elems)
            {
                JProperty element = (JProperty)item;
                string name = element.Name;
                if ("JSONObject".Equals(name) || "JSONConfig".Equals(name))
                {
                    continue;
                }
                string title = element.Value["title"] == null ? null : element.Value["title"].ToString();
                string type = element.Value["type"].ToString();

                Schema target = new Schema
                {
                    Key = name,
                    Title = title,
                    Type = type,
                    Fields = ParseFieldList(element.Value["properties"])
                };

                schemas.Add(target);
            }

            return schemas;
        }

        private List<Field> ParseFieldList(JToken jToken)
        {
            List<Field> fields = new List<Field>();


            JEnumerable<JToken> elems = jToken.Children();

            foreach (var item in elems)
            {
                JProperty element = (JProperty)item;
                string name = element.Name;

                if (ProjectUtil.FieldNeedSkip(name))
                {
                    continue;
                }

                string type = element.Value["type"] == null ? "object" : element.Value["type"].ToString();
                string format = element.Value["format"] == null ? null : element.Value["format"].ToString();
                string description = element.Value["description"] == null ? null : element.Value["description"].ToString();
                string _ref = null;
                if (!name.Equals("result") && type.Equals("object"))
                {
                    _ref = element.Value["$ref"].ToString();
                } 
                else if (type.Equals("array"))
                {
                    var tmp = element.Value["items"];
                    _ref = ((JProperty)tmp.First).Value.ToString();
                }
                Field target = new Field()
                {
                    Name = name,
                    Type = type,
                    Format = format,
                    Ref = _ref,
                    Description = description
                };
                fields.Add(target);
            }

            return fields;
        }

        private List<Path> ParseApiPaths(JToken jToken)
        {
            List<Path> paths = new List<Path>();

            JEnumerable<JToken> elems = jToken.Children();

            foreach (var item in elems)
            {
                JProperty element = (JProperty)item;
                string name = element.Name;
                if (name.EndsWith("/base/getDict"))
                {
                    continue;
                }

                string methodType = null, url = name, description = null; 

                if (null == element.Value["get"] && null == element.Value["post"])
                {
                    Console.WriteLine("存在空类型值: " + url);
                    continue;
                } 
                else if (null != element.Value["get"])
                {
                    methodType = "get";
                }
                else if (null != element.Value["post"])
                {
                    methodType = "post";
                }
                if (null != (element.Value[methodType]["description"]))
                {
                    description = ((JValue)(element.Value[methodType]["description"])).Value.ToString();
                }
                
                Path target = new Path()
                {
                    MethodType = methodType,
                    Url = url,
                    Description = description,
                    Parameters = ParsePathParameter(methodType, element),
                    Body = ParsePathRequestBody(methodType, element)
                };
                paths.Add(target);

                Console.WriteLine();
            }

            return paths;
        }

        private List<Parameter> ParsePathParameter(string methodType, JProperty element)
        {
            // 只处理get类型
            if ("post".Equals(methodType))
            {
                return null;
            }
            List<Parameter> list = new List<Parameter>();

            JToken parameterToken = element.Value["get"]["parameters"];
            // 无参数类型
            if (null == parameterToken)
            {
                return list;
            }

            foreach (JToken item in parameterToken.Children())
            {
                string name, schemaKey, schemaType, schemaFormat, schemaDefault;
                bool required = false;

                name = ((JValue)(item["name"])).Value.ToString();
                required = Boolean.Parse((((JValue)item["required"]).Value.ToString()));

                JObject schema = ((JObject)(item["schema"]));
                schemaKey = null == schema["$ref"] ? null : ((JValue)schema["$ref"]).Value.ToString();
                schemaType = null == schema["type"] ? null : ((JValue)schema["type"]).Value.ToString();
                schemaFormat = null == schema["format"] ? null : ((JValue)schema["format"]).Value.ToString();
                schemaDefault = null == schema["default"] ? null : ((JValue)schema["default"]).Value.ToString();

                Parameter target = new Parameter()
                {
                    Name = name,
                    SchemaKey = schemaKey,
                    SchemaType = schemaType,
                    SchemaFormat = schemaFormat,
                    SchemaDefault = schemaDefault,
                    Required = required
                };
                list.Add(target);
            }

            return list;
        }

        private RequestBody ParsePathRequestBody(string methodType, JProperty element)
        {
            // 只处理post类型
            if ("get".Equals(methodType))
            {
                return null;
            }

            JToken mediaTypeToken = element.Value["post"]["requestBody"]["content"].Children().First();

            string mediaType = ((JProperty)mediaTypeToken).Name;

            string schemaKey = ((JValue)mediaTypeToken.First()["schema"]["$ref"]).Value.ToString();

            RequestBody body = new RequestBody()
            {
                MediaType = mediaType,
                SchemaKey = schemaKey
            };
            return body;
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            string keyword = this.textBox_keyword.Text;

            TreeShow(keyword.Trim());
        }

        private void treeView_apidocs_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (null == this.treeView_apiDocs.SelectedNode || NodeExists(this.treeView_apiDocs.SelectedNode.Text))
            {
                return;
            }
            string path = this.treeView_apiDocs.SelectedNode.Text;
            Console.WriteLine("Node Mouse Double Click " + path);

            this.treeView_apiDocs_selected.Nodes.Add(path);
        }

        private bool NodeExists(string path)
        {
            int count = this.treeView_apiDocs_selected.Nodes.Count;
            if (count == 0)
            {
                return false;
            }

            foreach (TreeNode node in this.treeView_apiDocs_selected.Nodes)
            {
                Console.WriteLine("path = {0}, node = {1}", path, node.Text);
                if (node.Text.Equals(path))
                {
                    return true;
                }
            }
            return false;
        }

        private void treeView_apiDocs_selected_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (null == this.treeView_apiDocs.SelectedNode)
            {
                return;
            }
            this.treeView_apiDocs_selected.SelectedNode.Remove();
        }

        private void button_clearSelected_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("即将清空已选择内容", "确认", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.treeView_apiDocs_selected.Nodes.Clear();
            }
        }

        private void textBox_keyword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                this.button_search_Click(sender, e);
            }
        }

    }
}
