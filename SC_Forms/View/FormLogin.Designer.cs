
namespace SC_Forms
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnLogin = new Button();
            btnRegistered = new Button();
            label1 = new Label();
            label2 = new Label();
            tbAcct = new TextBox();
            tbPwd = new TextBox();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(169, 218);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "登陆";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnRegistered
            // 
            btnRegistered.Location = new Point(281, 218);
            btnRegistered.Name = "btnRegistered";
            btnRegistered.Size = new Size(75, 23);
            btnRegistered.TabIndex = 1;
            btnRegistered.Text = "注册";
            btnRegistered.UseVisualStyleBackColor = true;
            btnRegistered.Click += btnRegistered_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(169, 129);
            label1.Name = "label1";
            label1.Size = new Size(32, 17);
            label1.TabIndex = 2;
            label1.Text = "账号";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(169, 169);
            label2.Name = "label2";
            label2.Size = new Size(32, 17);
            label2.TabIndex = 3;
            label2.Text = "密码";
            // 
            // tbAcct
            // 
            tbAcct.Location = new Point(256, 128);
            tbAcct.Name = "tbAcct";
            tbAcct.Size = new Size(100, 23);
            tbAcct.TabIndex = 4;
            // 
            // tbPwd
            // 
            tbPwd.Location = new Point(256, 166);
            tbPwd.Name = "tbPwd";
            tbPwd.PasswordChar = '*';
            tbPwd.Size = new Size(100, 23);
            tbPwd.TabIndex = 5;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tbPwd);
            Controls.Add(tbAcct);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnRegistered);
            Controls.Add(btnLogin);
            Name = "FormLogin";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Button btnLogin;
        private Button btnRegistered;
        private Label label1;
        private Label label2;
        private TextBox tbAcct;
        private TextBox tbPwd;
    }
}
