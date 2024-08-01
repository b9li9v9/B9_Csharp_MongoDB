namespace SC_Forms
{
    partial class FormRegistered
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbAcct = new TextBox();
            tbPwd = new TextBox();
            tbNick = new TextBox();
            btnRegistered = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(127, 68);
            label1.Name = "label1";
            label1.Size = new Size(32, 17);
            label1.TabIndex = 0;
            label1.Text = "账号";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(127, 149);
            label2.Name = "label2";
            label2.Size = new Size(32, 17);
            label2.TabIndex = 1;
            label2.Text = "昵称";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(127, 106);
            label3.Name = "label3";
            label3.Size = new Size(32, 17);
            label3.TabIndex = 2;
            label3.Text = "密码";
            // 
            // tbAcct
            // 
            tbAcct.Location = new Point(185, 62);
            tbAcct.Name = "tbAcct";
            tbAcct.Size = new Size(100, 23);
            tbAcct.TabIndex = 3;
            // 
            // tbPwd
            // 
            tbPwd.Location = new Point(185, 106);
            tbPwd.Name = "tbPwd";
            tbPwd.Size = new Size(100, 23);
            tbPwd.TabIndex = 4;
            // 
            // tbNick
            // 
            tbNick.Location = new Point(185, 146);
            tbNick.Name = "tbNick";
            tbNick.Size = new Size(100, 23);
            tbNick.TabIndex = 5;
            // 
            // btnRegistered
            // 
            btnRegistered.Location = new Point(127, 189);
            btnRegistered.Name = "btnRegistered";
            btnRegistered.Size = new Size(75, 23);
            btnRegistered.TabIndex = 6;
            btnRegistered.Text = "注册";
            btnRegistered.UseVisualStyleBackColor = true;
            btnRegistered.Click += btnRegistered_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(210, 189);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "取消";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // FormRegistered
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnRegistered);
            Controls.Add(tbNick);
            Controls.Add(tbPwd);
            Controls.Add(tbAcct);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormRegistered";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbAcct;
        private TextBox tbPwd;
        private TextBox tbNick;
        private Button btnRegistered;
        private Button btnCancel;
    }
}