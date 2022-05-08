using niushuai233.Util;
using SwaggerTool.Entity;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SwaggerTool.Forms.Settings
{
    public partial class ServiceAddrSetForm : Form
    {
        public ServiceAddrSetForm()
        {
            InitializeComponent();

            ServiceAddr serviceAddr = CommonUtil.LoadConfig<ServiceAddr>(CommonUtil.ServiceAddrSettingsLocation());
            if (!CollectionUtil.IsEmpty(serviceAddr.ServerList))
            {
                foreach (var item in serviceAddr.ServerList)
                {
                    this.listBox_serviceAddr.Items.Add(item);
                }
            }

            this.RefreshServiceAddrList();
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            string item = this.textBox_service_item.Text;
            if (StringUtil.IsNotEmpty(item))
            {
                this.listBox_serviceAddr.Items.Add(Trans());
            }

            this.RefreshServiceAddrList();
        }

        private void button_delete_item_Click(object sender, EventArgs e)
        {
            int selectedIndex = this.listBox_serviceAddr.SelectedIndex;

            if (MessageBox.Show("是否删除: " + this.listBox_serviceAddr.SelectedItem.ToString(),
                "是否删除?",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.listBox_serviceAddr.Items.RemoveAt(selectedIndex);
            }

            this.RefreshServiceAddrList();
        }

        private void RefreshServiceAddrList()
        {
            ServiceAddr serviceAddr = new ServiceAddr()
            {
                ServerList = Trans()
            };

            XmlUtil.Obj2Xml<ServiceAddr>(CommonUtil.ServiceAddrSettingsLocation(), serviceAddr);
        }

        private List<string> Trans()
        {
            List<string> list = new List<string>();

            ListBox.ObjectCollection items = this.listBox_serviceAddr.Items;
            if (items.Count == 0)
            {
                return list;
            }

            for (int i = 0; i < items.Count; i++)
            {
                list.Add(items[i].ToString());
            }

            return list;
        }
    }
}