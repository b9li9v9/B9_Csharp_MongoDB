
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SC_Forms
{
    public partial class FormIndex : Form
    {


        public FormIndex()
        {
            InitializeComponent();
        }

        /// 关闭按钮
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // 用户信息测试
        private void btnUserSetting_Click(object sender, EventArgs e)
        {
            //FormsManager.UseDisposableForm("testDbView", new TestDbView());
        }

        // 根节点管理
        private void menuNodeManager_Click(object sender, EventArgs e)
        {
            FormsManager.UseDisposableForm("LoadRootNode", new FormIndexManagerSettingRootNote());
        }

        // 本节点读取
        private void menuSelfNode_Click(object sender, EventArgs e)
        {
            FormsManager.UseDisposableForm("LoadSelfNode", new FormIndexManagerSettingSelfNode());
        }

        private void 查询子节点ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormsManager.UseDisposableForm("LoadChildNode", new FormIndexManagerSettingChildNode());
        }
    }
}
