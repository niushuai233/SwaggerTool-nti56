using niushuai233.Util;
using SwaggerTool.Entity;
using SwaggerTool.Util;
using System;
using System.Windows.Forms;

namespace SwaggerTool.Forms.Settings
{
    public partial class ApiPostForm : Form
    {
        public ApiPostForm()
        {
            InitializeComponent();

            ApiPost apiPost = CommonUtil.LoadConfig<ApiPost>(CommonUtil.ApiPostSettingsLocation());
            if (null != apiPost)
            {
                this.textBox_token.Text = apiPost.Token;
                this.textBox_projectId.Text = null == apiPost.ProjectId ? "f4828dd4-ecd8-4be7-cd2b-55dedd69b868" : apiPost.ProjectId;
            }
            ProjectUtil.apiPost = apiPost;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string token = this.textBox_token.Text;
            string projectId = this.textBox_projectId.Text;

            if (StringUtil.IsEmpty(token))
            {
                MessageBox.Show("请输入token");
                return;
            }
            else if (StringUtil.IsEmpty(projectId))
            {
                MessageBox.Show("请输入项目ID");
                return;
            }

            ApiPost apiPost = new ApiPost()
            {
                Token = token,
                ProjectId = projectId
            };
            XmlUtil.Obj2Xml<ApiPost>(CommonUtil.ApiPostSettingsLocation(), apiPost);
            ProjectUtil.apiPost = apiPost;

            this.Close();
            this.Dispose();
        }
    }
}