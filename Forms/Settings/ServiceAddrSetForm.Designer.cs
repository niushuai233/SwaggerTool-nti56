
namespace SwaggerTool.Forms.Settings
{
    partial class ServiceAddrSetForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_add = new System.Windows.Forms.Button();
            this.textBox_service_item = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBox_serviceAddr = new System.Windows.Forms.ListBox();
            this.button_close = new System.Windows.Forms.Button();
            this.button_delete_item = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_add);
            this.groupBox1.Controls.Add(this.textBox_service_item);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(694, 73);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "操作区";
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(596, 28);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(88, 30);
            this.button_add.TabIndex = 2;
            this.button_add.Text = "添加";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // textBox_service_item
            // 
            this.textBox_service_item.Location = new System.Drawing.Point(6, 28);
            this.textBox_service_item.Name = "textBox_service_item";
            this.textBox_service_item.Size = new System.Drawing.Size(584, 29);
            this.textBox_service_item.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBox_serviceAddr);
            this.groupBox2.Location = new System.Drawing.Point(13, 76);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(694, 312);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "显示区";
            // 
            // listBox_serviceAddr
            // 
            this.listBox_serviceAddr.FormattingEnabled = true;
            this.listBox_serviceAddr.ItemHeight = 21;
            this.listBox_serviceAddr.Location = new System.Drawing.Point(6, 28);
            this.listBox_serviceAddr.Name = "listBox_serviceAddr";
            this.listBox_serviceAddr.Size = new System.Drawing.Size(681, 277);
            this.listBox_serviceAddr.TabIndex = 0;
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(609, 394);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(88, 30);
            this.button_close.TabIndex = 2;
            this.button_close.Text = "关闭";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // button_delete_item
            // 
            this.button_delete_item.Location = new System.Drawing.Point(515, 394);
            this.button_delete_item.Name = "button_delete_item";
            this.button_delete_item.Size = new System.Drawing.Size(88, 30);
            this.button_delete_item.TabIndex = 2;
            this.button_delete_item.Text = "删除选中";
            this.button_delete_item.UseVisualStyleBackColor = true;
            this.button_delete_item.Click += new System.EventHandler(this.button_delete_item_Click);
            // 
            // ServiceAddrSetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 432);
            this.Controls.Add(this.button_delete_item);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ServiceAddrSetForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "服务地址";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.ListBox listBox_serviceAddr;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.TextBox textBox_service_item;
        private System.Windows.Forms.Button button_delete_item;
    }
}