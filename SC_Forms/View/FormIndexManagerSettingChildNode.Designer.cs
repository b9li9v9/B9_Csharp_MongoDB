namespace SC_Forms
{
    partial class FormIndexManagerSettingChildNode
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
			OrgUnitId = new DataGridViewTextBoxColumn();
			EmpName = new DataGridViewTextBoxColumn();
			OrgName = new DataGridViewTextBoxColumn();
			OwnerId = new DataGridViewTextBoxColumn();
			IsDeleted = new DataGridViewTextBoxColumn();
			ParentId = new DataGridViewTextBoxColumn();
			AV = new DataGridViewTextBoxColumn();
			button3 = new Button();
			button1 = new Button();
			button4 = new Button();
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
			splitContainer1.Panel2.Controls.Add(button3);
			splitContainer1.Panel2.Controls.Add(button1);
			splitContainer1.Panel2.Controls.Add(button4);
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
			EmpName.HeaderText = "职员名字";
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
			OwnerId.HeaderText = "职员标识";
			OwnerId.Name = "OwnerId";
			// 
			// IsDeleted
			// 
			IsDeleted.DataPropertyName = "IsDeleted";
			IsDeleted.HeaderText = "IsDeleted";
			IsDeleted.Name = "IsDeleted";
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
			// button3
			// 
			button3.Location = new Point(72, 79);
			button3.Name = "button3";
			button3.Size = new Size(75, 23);
			button3.TabIndex = 8;
			button3.Text = "查询";
			button3.UseVisualStyleBackColor = true;
			button3.Click += btnQuery_Click;
			// 
			// button1
			// 
			button1.Location = new Point(167, 79);
			button1.Name = "button1";
			button1.Size = new Size(75, 23);
			button1.TabIndex = 6;
			button1.Text = "修改";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// button4
			// 
			button4.Location = new Point(268, 79);
			button4.Name = "button4";
			button4.Size = new Size(75, 23);
			button4.TabIndex = 5;
			button4.Text = "授权";
			button4.UseVisualStyleBackColor = true;
			button4.Click += button4_Click;
			// 
			// FormIndexManagerSettingChildNode
			// 
			AutoScaleDimensions = new SizeF(7F, 17F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(splitContainer1);
			Name = "FormIndexManagerSettingChildNode";
			Text = "FormIndexManagerSettingChildNode";
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
        private Button button4;
        private Button button3;
        private Button button1;
		private DataGridViewTextBoxColumn OrgUnitId;
		private DataGridViewTextBoxColumn EmpName;
		private DataGridViewTextBoxColumn OrgName;
		private DataGridViewTextBoxColumn OwnerId;
		private DataGridViewTextBoxColumn IsDeleted;
		private DataGridViewTextBoxColumn ParentId;
		private DataGridViewTextBoxColumn AV;
	}
}