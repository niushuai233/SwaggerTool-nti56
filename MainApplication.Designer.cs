
namespace SwaggerTool
{
    partial class MainApplication
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.暂定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Settings_ServiceAddr_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apiPostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_keyword = new System.Windows.Forms.TextBox();
            this.button_submitTarget = new System.Windows.Forms.Button();
            this.button_clearSelected = new System.Windows.Forms.Button();
            this.button_search = new System.Windows.Forms.Button();
            this.button_refresh = new System.Windows.Forms.Button();
            this.comboBox_serviceTarget = new System.Windows.Forms.ComboBox();
            this.label_serviceTarget = new System.Windows.Forms.Label();
            this.comboBox_serviceAddr = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_serviceAddr = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.treeView_apiDocs = new System.Windows.Forms.TreeView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.treeView_apiDocs_selected = new System.Windows.Forms.TreeView();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 707);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1008, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.SettingsToolStripMenuItem,
            this.AboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 29);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.暂定ToolStripMenuItem,
            this.toolStripSeparator1,
            this.ExitToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(59, 25);
            this.FileToolStripMenuItem.Text = "文件";
            // 
            // 暂定ToolStripMenuItem
            // 
            this.暂定ToolStripMenuItem.Name = "暂定ToolStripMenuItem";
            this.暂定ToolStripMenuItem.Size = new System.Drawing.Size(112, 26);
            this.暂定ToolStripMenuItem.Text = "暂定";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(109, 6);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(112, 26);
            this.ExitToolStripMenuItem.Text = "退出";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // SettingsToolStripMenuItem
            // 
            this.SettingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Settings_ServiceAddr_ToolStripMenuItem,
            this.apiPostToolStripMenuItem});
            this.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem";
            this.SettingsToolStripMenuItem.Size = new System.Drawing.Size(54, 25);
            this.SettingsToolStripMenuItem.Text = "设置";
            // 
            // Settings_ServiceAddr_ToolStripMenuItem
            // 
            this.Settings_ServiceAddr_ToolStripMenuItem.Name = "Settings_ServiceAddr_ToolStripMenuItem";
            this.Settings_ServiceAddr_ToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.Settings_ServiceAddr_ToolStripMenuItem.Text = "服务地址";
            this.Settings_ServiceAddr_ToolStripMenuItem.Click += new System.EventHandler(this.Settings_ServiceAddr_ToolStripMenuItem_Click);
            // 
            // apiPostToolStripMenuItem
            // 
            this.apiPostToolStripMenuItem.Name = "apiPostToolStripMenuItem";
            this.apiPostToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.apiPostToolStripMenuItem.Text = "ApiPost设置";
            this.apiPostToolStripMenuItem.Click += new System.EventHandler(this.apiPostToolStripMenuItem_Click);
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(54, 25);
            this.AboutToolStripMenuItem.Text = "关于";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_keyword);
            this.groupBox1.Controls.Add(this.button_submitTarget);
            this.groupBox1.Controls.Add(this.button_clearSelected);
            this.groupBox1.Controls.Add(this.button_search);
            this.groupBox1.Controls.Add(this.button_refresh);
            this.groupBox1.Controls.Add(this.comboBox_serviceTarget);
            this.groupBox1.Controls.Add(this.label_serviceTarget);
            this.groupBox1.Controls.Add(this.comboBox_serviceAddr);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label_serviceAddr);
            this.groupBox1.Location = new System.Drawing.Point(13, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(983, 96);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "功能区";
            // 
            // textBox_keyword
            // 
            this.textBox_keyword.Location = new System.Drawing.Point(91, 57);
            this.textBox_keyword.Name = "textBox_keyword";
            this.textBox_keyword.Size = new System.Drawing.Size(429, 29);
            this.textBox_keyword.TabIndex = 3;
            this.textBox_keyword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_keyword_KeyDown);
            // 
            // button_submitTarget
            // 
            this.button_submitTarget.Location = new System.Drawing.Point(899, 57);
            this.button_submitTarget.Name = "button_submitTarget";
            this.button_submitTarget.Size = new System.Drawing.Size(78, 32);
            this.button_submitTarget.TabIndex = 2;
            this.button_submitTarget.Text = "提交";
            this.button_submitTarget.UseVisualStyleBackColor = true;
            this.button_submitTarget.Click += new System.EventHandler(this.button_submitTarget_Click);
            // 
            // button_clearSelected
            // 
            this.button_clearSelected.Location = new System.Drawing.Point(806, 57);
            this.button_clearSelected.Name = "button_clearSelected";
            this.button_clearSelected.Size = new System.Drawing.Size(87, 32);
            this.button_clearSelected.TabIndex = 2;
            this.button_clearSelected.Text = "清空选中";
            this.button_clearSelected.UseVisualStyleBackColor = true;
            this.button_clearSelected.Click += new System.EventHandler(this.button_clearSelected_Click);
            // 
            // button_search
            // 
            this.button_search.Location = new System.Drawing.Point(526, 57);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(78, 32);
            this.button_search.TabIndex = 2;
            this.button_search.Text = "搜索";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // button_refresh
            // 
            this.button_refresh.Location = new System.Drawing.Point(722, 57);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(78, 32);
            this.button_refresh.TabIndex = 2;
            this.button_refresh.Text = "刷新";
            this.button_refresh.UseVisualStyleBackColor = true;
            this.button_refresh.Click += new System.EventHandler(this.button_refresh_Click);
            // 
            // comboBox_serviceTarget
            // 
            this.comboBox_serviceTarget.FormattingEnabled = true;
            this.comboBox_serviceTarget.Location = new System.Drawing.Point(610, 25);
            this.comboBox_serviceTarget.Name = "comboBox_serviceTarget";
            this.comboBox_serviceTarget.Size = new System.Drawing.Size(367, 29);
            this.comboBox_serviceTarget.TabIndex = 1;
            // 
            // label_serviceTarget
            // 
            this.label_serviceTarget.AutoSize = true;
            this.label_serviceTarget.Location = new System.Drawing.Point(526, 29);
            this.label_serviceTarget.Name = "label_serviceTarget";
            this.label_serviceTarget.Size = new System.Drawing.Size(78, 21);
            this.label_serviceTarget.TabIndex = 0;
            this.label_serviceTarget.Text = "平台工程:";
            // 
            // comboBox_serviceAddr
            // 
            this.comboBox_serviceAddr.FormattingEnabled = true;
            this.comboBox_serviceAddr.Location = new System.Drawing.Point(91, 25);
            this.comboBox_serviceAddr.Name = "comboBox_serviceAddr";
            this.comboBox_serviceAddr.Size = new System.Drawing.Size(429, 29);
            this.comboBox_serviceAddr.TabIndex = 1;
            this.comboBox_serviceAddr.SelectedIndexChanged += new System.EventHandler(this.comboBox_serviceAddr_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "搜索内容:";
            // 
            // label_serviceAddr
            // 
            this.label_serviceAddr.AutoSize = true;
            this.label_serviceAddr.Location = new System.Drawing.Point(7, 29);
            this.label_serviceAddr.Name = "label_serviceAddr";
            this.label_serviceAddr.Size = new System.Drawing.Size(78, 21);
            this.label_serviceAddr.TabIndex = 0;
            this.label_serviceAddr.Text = "服务地址:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.treeView_apiDocs);
            this.groupBox2.Location = new System.Drawing.Point(12, 135);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(461, 569);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "显示区";
            // 
            // treeView_apiDocs
            // 
            this.treeView_apiDocs.Location = new System.Drawing.Point(10, 28);
            this.treeView_apiDocs.Name = "treeView_apiDocs";
            this.treeView_apiDocs.Size = new System.Drawing.Size(445, 535);
            this.treeView_apiDocs.TabIndex = 0;
            this.treeView_apiDocs.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView_apidocs_NodeMouseDoubleClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.treeView_apiDocs_selected);
            this.groupBox3.Location = new System.Drawing.Point(520, 135);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(461, 569);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "已选择内容";
            // 
            // treeView_apiDocs_selected
            // 
            this.treeView_apiDocs_selected.Location = new System.Drawing.Point(6, 28);
            this.treeView_apiDocs_selected.Name = "treeView_apiDocs_selected";
            this.treeView_apiDocs_selected.Size = new System.Drawing.Size(449, 535);
            this.treeView_apiDocs_selected.TabIndex = 0;
            this.treeView_apiDocs_selected.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView_apiDocs_selected_NodeMouseDoubleClick);
            // 
            // MainApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainApplication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SwaggerTool";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 暂定ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label_serviceAddr;
        private System.Windows.Forms.ComboBox comboBox_serviceAddr;
        private System.Windows.Forms.Button button_refresh;
        private System.Windows.Forms.ComboBox comboBox_serviceTarget;
        private System.Windows.Forms.Label label_serviceTarget;
        private System.Windows.Forms.Button button_submitTarget;
        private System.Windows.Forms.ToolStripMenuItem Settings_ServiceAddr_ToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox_keyword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.TreeView treeView_apiDocs;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TreeView treeView_apiDocs_selected;
        private System.Windows.Forms.Button button_clearSelected;
        private System.Windows.Forms.ToolStripMenuItem apiPostToolStripMenuItem;
    }
}

