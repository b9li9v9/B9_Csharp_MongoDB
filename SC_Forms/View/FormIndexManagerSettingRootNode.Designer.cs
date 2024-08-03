namespace SC_Forms
{
    partial class FormIndexManagerSettingRootNode
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
            splitContainer1 = new SplitContainer();
            dataGridView1 = new DataGridView();
            button4 = new Button();
            btnRegistered = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            OrgUnitId = new DataGridViewTextBoxColumn();
            EmpName = new DataGridViewTextBoxColumn();
            OrgName = new DataGridViewTextBoxColumn();
            OwnerId = new DataGridViewTextBoxColumn();
            IsDeleted = new DataGridViewTextBoxColumn();
            ParentId = new DataGridViewTextBoxColumn();
            AV = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(dataGridView1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(button4);
            splitContainer1.Panel2.Controls.Add(btnRegistered);
            splitContainer1.Panel2.Controls.Add(button3);
            splitContainer1.Panel2.Controls.Add(button2);
            splitContainer1.Panel2.Controls.Add(button1);
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 266;
            splitContainer1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { OrgUnitId, EmpName, OrgName, OwnerId, IsDeleted, ParentId, AV });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView1.Size = new Size(800, 266);
            dataGridView1.TabIndex = 0;
            // 
            // button4
            // 
            button4.Location = new Point(449, 55);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 4;
            button4.Text = "接收节点";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // btnRegistered
            // 
            btnRegistered.Location = new Point(63, 55);
            btnRegistered.Name = "btnRegistered";
            btnRegistered.Size = new Size(75, 23);
            btnRegistered.TabIndex = 3;
            btnRegistered.Text = "注册";
            btnRegistered.UseVisualStyleBackColor = true;
            btnRegistered.Click += btnRegistered_Click;
            // 
            // button3
            // 
            button3.Location = new Point(156, 55);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 2;
            button3.Text = "查询";
            button3.UseVisualStyleBackColor = true;
            button3.Click += btn_Query_Click;
            // 
            // button2
            // 
            button2.Location = new Point(348, 55);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "删除";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(251, 55);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "修改";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // OrgUnitId
            // 
            OrgUnitId.DataPropertyName = "OrgUnitId";
            OrgUnitId.HeaderText = "组织代码";
            OrgUnitId.Name = "OrgUnitId";
            OrgUnitId.ReadOnly = true;
            // 
            // EmpName
            // 
            EmpName.DataPropertyName = "EmpName";
            EmpName.HeaderText = "负责人名字";
            EmpName.Name = "EmpName";
            // 
            // OrgName
            // 
            OrgName.DataPropertyName = "OrgName";
            OrgName.HeaderText = "组织名字";
            OrgName.Name = "OrgName";
            // 
            // OwnerId
            // 
            OwnerId.DataPropertyName = "OwnerId";
            OwnerId.HeaderText = "权属人";
            OwnerId.Name = "OwnerId";
            // 
            // IsDeleted
            // 
            IsDeleted.DataPropertyName = "IsDeleted";
            IsDeleted.HeaderText = "是否删除";
            IsDeleted.Name = "IsDeleted";
            IsDeleted.Visible = false;
            // 
            // ParentId
            // 
            ParentId.DataPropertyName = "ParentId";
            ParentId.HeaderText = "父节点";
            ParentId.Name = "ParentId";
            ParentId.Visible = false;
            // 
            // AV
            // 
            AV.DataPropertyName = "AV";
            AV.HeaderText = "合法性";
            AV.Name = "AV";
            AV.ReadOnly = true;
            // 
            // FormIndexManagerSettingRootNote
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Name = "FormIndexManagerSettingRootNote";
            Text = "ManagerRootNote";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button btnRegistered;
        private Button button4;
        private DataGridViewTextBoxColumn OrgUnitId;
        private DataGridViewTextBoxColumn EmpName;
        private DataGridViewTextBoxColumn OrgName;
        private DataGridViewTextBoxColumn OwnerId;
        private DataGridViewTextBoxColumn IsDeleted;
        private DataGridViewTextBoxColumn ParentId;
        private DataGridViewTextBoxColumn AV;
    }
}