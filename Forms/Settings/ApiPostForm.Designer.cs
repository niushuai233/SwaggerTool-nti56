
namespace SwaggerTool.Forms.Settings
{
    partial class ApiPostForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_token = new System.Windows.Forms.TextBox();
            this.textBox_projectId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(387, 92);
            this.button1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "确定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Token:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "项目ID:";
            // 
            // textBox_token
            // 
            this.textBox_token.Location = new System.Drawing.Point(79, 13);
            this.textBox_token.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.textBox_token.Name = "textBox_token";
            this.textBox_token.Size = new System.Drawing.Size(403, 29);
            this.textBox_token.TabIndex = 3;
            this.textBox_token.Text = "3524822cd2ad6abc597581497356fd0fce3dd465";
            // 
            // textBox_projectId
            // 
            this.textBox_projectId.Location = new System.Drawing.Point(79, 53);
            this.textBox_projectId.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.textBox_projectId.Name = "textBox_projectId";
            this.textBox_projectId.Size = new System.Drawing.Size(403, 29);
            this.textBox_projectId.TabIndex = 4;
            this.textBox_projectId.Text = "f4828dd4-ecd8-4be7-cd2b-55dedd69b868";
            // 
            // ApiPostForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 129);
            this.ControlBox = false;
            this.Controls.Add(this.textBox_projectId);
            this.Controls.Add(this.textBox_token);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ApiPostForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ApiPost设置";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_token;
        private System.Windows.Forms.TextBox textBox_projectId;
    }
}