namespace SC_Forms
{
    partial class FormIndex
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
            toolStrip1 = new ToolStrip();
            btnSetting = new ToolStripSplitButton();
            btnUserSetting = new ToolStripMenuItem();
            组织管理ToolStripMenuItem = new ToolStripMenuItem();
            menuNodeManager = new ToolStripMenuItem();
            menuSelfNode = new ToolStripMenuItem();
            查询子节点ToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = SystemColors.ControlLightLight;
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnSetting });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnSetting
            // 
            btnSetting.DropDownItems.AddRange(new ToolStripItem[] { btnUserSetting, 组织管理ToolStripMenuItem });
            btnSetting.Name = "btnSetting";
            btnSetting.Size = new Size(72, 22);
            btnSetting.Text = "管理界面";
            // 
            // btnUserSetting
            // 
            btnUserSetting.Name = "btnUserSetting";
            btnUserSetting.Size = new Size(180, 22);
            btnUserSetting.Text = "用户管理";
            btnUserSetting.Click += btnUserSetting_Click;
            // 
            // 组织管理ToolStripMenuItem
            // 
            组织管理ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menuNodeManager, menuSelfNode, 查询子节点ToolStripMenuItem });
            组织管理ToolStripMenuItem.Name = "组织管理ToolStripMenuItem";
            组织管理ToolStripMenuItem.Size = new Size(180, 22);
            组织管理ToolStripMenuItem.Text = "组织管理";
            // 
            // menuNodeManager
            // 
            menuNodeManager.Name = "menuNodeManager";
            menuNodeManager.Size = new Size(180, 22);
            menuNodeManager.Text = "根节点管理";
            menuNodeManager.Click += menuNodeManager_Click;
            // 
            // menuSelfNode
            // 
            menuSelfNode.Name = "menuSelfNode";
            menuSelfNode.Size = new Size(180, 22);
            menuSelfNode.Text = "本节点管理";
            menuSelfNode.Click += menuSelfNode_Click;
            // 
            // 查询子节点ToolStripMenuItem
            // 
            查询子节点ToolStripMenuItem.Name = "查询子节点ToolStripMenuItem";
            查询子节点ToolStripMenuItem.Size = new Size(180, 22);
            查询子节点ToolStripMenuItem.Text = "子节点管理";
            查询子节点ToolStripMenuItem.Click += 查询子节点ToolStripMenuItem_Click;
            // 
            // FormIndex
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(toolStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormIndex";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Index";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ToolStrip toolStrip1;
        private ToolStripSplitButton btnSetting;
        private ToolStripMenuItem btnUserSetting;
        private ToolStripMenuItem 组织管理ToolStripMenuItem;
        private ToolStripMenuItem menuNodeManager;
        private ToolStripMenuItem 查询子节点ToolStripMenuItem;
        private ToolStripMenuItem menuSelfNode;
    }
}