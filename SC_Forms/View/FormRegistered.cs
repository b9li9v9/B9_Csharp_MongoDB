
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SC_Forms
{
    public partial class FormRegistered : Form
    {
        public FormRegistered()
        {
            InitializeComponent();
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            FormsHelper.ShowSingleForm("Login");
        }

        private void btnRegistered_Click(object sender, EventArgs e)
        {
            if (this.tbAcct.Text == "" || this.tbPwd.Text == "")
            {
                MessageBox.Show("账号、密码、不得为空");
                return;
            }

            var collection = MongoDbHelper.GetClient().GetDatabase("TestDB").GetCollection<User>("Users");

            var t = collection.AsQueryable()
    .Where(u => u.Acct == tbAcct.Text).FirstOrDefault();
            Debug.WriteLine(t);

            if (t == null)
            {
                var user = new User();
                user.Acct = tbAcct.Text;
                user.Nick = tbNick.Text;
                user.pwd = tbPwd.Text;
                user.IsDeleted = false;
                collection.InsertOne(user);
                MessageBox.Show("注册成功！");
                FormsHelper.DisposableFormsDict["registered"].Close();
            }
            else
            {
                MessageBox.Show("该账户已存在");
            }
            //using (SC_DbContext SC_Db = new SC_DbContext())
            //{

            //    User user = new User();
            //    user.Acct = this.tbAcct.Text;
            //    user.pwd = this.tbPwd.Text;
            //    user.Nick = this.tbNick.Text;

            //    var existingUser = SC_Db.Users.FirstOrDefault(u => u.Acct == user.Acct);
            //    if (existingUser != null)
            //    {
            //        MessageBox.Show("创建失败，账户已存在");
            //        return;
            //    }
            //    else
            //    {
            //        SC_Db.Users.Add(user);
            //        SC_Db.SaveChanges();
            //        MessageBox.Show("账户创建成功。");
            //        FormsManager.ShowSingleForm("Login");
            //    }
            //}
        }

        //private void FormRegistered_Load(object sender, EventArgs e)
        //{
        //    this.TopMost = true;  // 将窗口置于最前面
        //}
    }
}
