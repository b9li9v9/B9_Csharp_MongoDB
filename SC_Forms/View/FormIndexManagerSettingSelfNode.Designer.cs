namespace SC_Forms
{
    partial class FormIndexManagerSettingSelfNode
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
			btnUpData = new Button();
			btnSignOutNode = new Button();
			btnQuery = new Button();
			txParentNode = new TextBox();
			label1 = new Label();
			btnAddNode = new Button();
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
			splitContainer1.Panel2.Controls.Add(btnUpData);
			splitContainer1.Panel2.Controls.Add(btnSignOutNode);
			splitContainer1.Panel2.Controls.Add(btnQuery);
			splitContainer1.Panel2.Controls.Add(txParentNode);
			splitContainer1.Panel2.Controls.Add(label1);
			splitContainer1.Panel2.Controls.Add(btnAddNode);
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
			dataGridView1.Size = new Size(800, 266);
			dataGridView1.TabIndex = 0;
			// 
			// btnUpData
			// 
			btnUpData.Location = new Point(404, 72);
			btnUpData.Name = "btnUpData";
			btnUpData.Size = new Size(75, 23);
			btnUpData.TabIndex = 9;
			btnUpData.Text = "修改";
			btnUpData.UseVisualStyleBackColor = true;
			btnUpData.Click += btnUpData_Click;
			// 
			// btnSignOutNode
			// 
			btnSignOutNode.Location = new Point(404, 116);
			btnSignOutNode.Name = "btnSignOutNode";
			btnSignOutNode.Size = new Size(75, 23);
			btnSignOutNode.TabIndex = 8;
			btnSignOutNode.Text = "退出节点";
			btnSignOutNode.UseVisualStyleBackColor = true;
			btnSignOutNode.Click += btnSignOutNode_Click;
			// 
			// btnQuery
			// 
			btnQuery.Location = new Point(404, 28);
			btnQuery.Name = "btnQuery";
			btnQuery.Size = new Size(75, 23);
			btnQuery.TabIndex = 3;
			btnQuery.Text = "查询";
			btnQuery.UseVisualStyleBackColor = true;
			btnQuery.Click += btnQuery_Click;
			// 
			// txParentNode
			// 
			txParentNode.Location = new Point(144, 28);
			txParentNode.Name = "txParentNode";
			txParentNode.Size = new Size(116, 23);
			txParentNode.TabIndex = 2;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(34, 31);
			label1.Name = "label1";
			label1.Size = new Size(104, 17);
			label1.TabIndex = 1;
			label1.Text = "父节点组织代码：";
			// 
			// btnAddNode
			// 
			btnAddNode.Location = new Point(56, 72);
			btnAddNode.Name = "btnAddNode";
			btnAddNode.Size = new Size(88, 23);
			btnAddNode.TabIndex = 0;
			btnAddNode.Text = "加入节点";
			btnAddNode.UseVisualStyleBackColor = true;
			btnAddNode.Click += btnAddNode_Click;
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
			OrgName.HeaderText = "部门名字";
			OrgName.Name = "OrgName";
			// 
			// OwnerId
			// 
			OwnerId.DataPropertyName = "OwnerId";
			OwnerId.HeaderText = "权属人";
			OwnerId.Name = "OwnerId";
			OwnerId.ReadOnly = true;
			// 
			// IsDeleted
			// 
			IsDeleted.DataPropertyName = "IsDeleted";
			IsDeleted.HeaderText = "IsDeleted";
			IsDeleted.Name = "IsDeleted";
			IsDeleted.ReadOnly = true;
			IsDeleted.Visible = false;
			// 
			// ParentId
			// 
			ParentId.DataPropertyName = "ParentId";
			ParentId.HeaderText = "父节点";
			ParentId.Name = "ParentId";
			ParentId.ReadOnly = true;
			// 
			// AV
			// 
			AV.DataPropertyName = "AV";
			AV.HeaderText = "合法性";
			AV.Name = "AV";
			AV.ReadOnly = true;
			// 
			// FormIndexManagerSettingSelfNode
			// 
			AutoScaleDimensions = new SizeF(7F, 17F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(splitContainer1);
			Name = "FormIndexManagerSettingSelfNode";
			Text = "FormIndexManagerSettingLoadSelfNote";
			splitContainer1.Panel1.ResumeLayout(false);
			splitContainer1.Panel2.ResumeLayout(false);
			splitContainer1.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
			splitContainer1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private SplitContainer splitContainer1;
        private DataGridView dataGridView1;
        private TextBox txParentNode;
        private Label label1;
        private Button btnAddNode;
        private Button btnQuery;
        private Button btnSignOutNode;
        private Button btnUpData;
		private DataGridViewTextBoxColumn OrgUnitId;
		private DataGridViewTextBoxColumn EmpName;
		private DataGridViewTextBoxColumn OrgName;
		private DataGridViewTextBoxColumn OwnerId;
		private DataGridViewTextBoxColumn IsDeleted;
		private DataGridViewTextBoxColumn ParentId;
		private DataGridViewTextBoxColumn AV;
	}
}