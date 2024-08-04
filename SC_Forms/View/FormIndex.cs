
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
            FormsHelper.UseDisposableForm("LoadRootNode", new FormIndexManagerSettingRootNode());
        }

		// 本节点管理
		private void menuSelfNode_Click(object sender, EventArgs e)
        {
            FormsHelper.UseDisposableForm("LoadSelfNode", new FormIndexManagerSettingSelfNode());
        }

		// 子节点管理
		private void 查询子节点ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormsHelper.UseDisposableForm("LoadChildNode", new FormIndexManagerSettingChildNode());
        }
    }
}
