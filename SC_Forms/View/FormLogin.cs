
using MongoDB.Driver.Core.Configuration;
using MongoDB.Driver;
using System.Data.Common;
using MongoDB.Bson;

namespace SC_Forms
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        // 打开注册窗口
        private void btnRegistered_Click_1(object sender, EventArgs e)
        {
            //FormsManager.ShowSingleForm("Registered");
            FormsHelper.UseDisposableForm("registered",new FormRegistered());
        }

        // 验证账号密码
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (this.tbAcct.Text == "" || this.tbPwd.Text == "")
            {
                MessageBox.Show("账号、密码 不得为空");
                return;
            }

            string connstr = @"mongodb://localhost:27017";
            var client = new MongoClient(connstr);


            //using (SC_DbContext SC_Db = new SC_DbContext())
            //{
            //    var existingUser = SC_Db.Users.FirstOrDefault(u => u.Acct == this.tbAcct.Text && u.pwd == this.tbPwd.Text);
            //    if (existingUser != null) 
            //    {
            //        FormsManager.UserId = existingUser.UserId;
            //        FormsManager.AddForm("Index", new FormIndex());
            //        FormsManager.ShowSingleForm("Index");
            //    }
            //    else
            //    {
            //        MessageBox.Show("账号不存在或密码错误");
            //        return;
            //    }
            //}
        }
    }
}
