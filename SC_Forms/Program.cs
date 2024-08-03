
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Diagnostics;
using System.Reflection;
namespace SC_Forms
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            ApplicationConfiguration.Initialize();
            /*
            using (SC_DbContext SC_Db = new SC_DbContext())
            {
                OrgUnit orgu = SC_Db.OrgUnits
                    .Include(o => o.NavChildrens)
                    .Single(o => o.ParentGuid == null);

                Debug.WriteLine(orgu.Guid);

                var orguitem = orgu.NavChildrens;
                Debug.WriteLine(orguitem.Count());
                foreach (OrgUnit o in orguitem)
                {
                    Debug.WriteLine(o.OrgName + " " + o.EmpName);
                }


            }


            using (SC_DbContext SC_Db = new SC_DbContext())
            {
                User user = SC_Db.Users.Single(u => u.UserId == 1);
                Debug.WriteLine(user.Acct);
            }
            */




            //写入
            //var user = MongoDbHelper.GetClient().GetDatabase("TestDB").GetCollection<User>("Users").Find(u=>u.Acct=="avc").FirstOrDefault();

            //user.Acct = "avc";
            //user.Nick = "avc";
            //user.pwd = "av";
            //user.IsDeleted = false;


            //user.navOrgUnits.RootNodes.Add(new OrgUnit()
            //{
            //    EmpName = "bb",
            //    OrgName = "bb",
            //    OwnerId = 1,
            //    IsDeleted = false,
            //    ParentGuid = null,
            //    AV = true
            //});
            //MongoDbHelper.GetClient().GetDatabase("TestDB").GetCollection<User>("Users").UpdateOne(user);
            //PrintObjectProperties(u);


            ////文档类
            //var collection = MongoDbHelper.GetClient().GetDatabase("TestDB").GetCollection<User>("Users");

            //// 查询条件
            //var filter = Builders<User>.Filter.Eq(u => u.Acct, "avc");

            //// 执行查询
            //var user = collection.Find(filter).FirstOrDefault();

            //if (user != null)
            //{
            //    var o = new OrgUnit()
            //    {
            //        EmpName = "bb",
            //        OrgName = "bb",
            //        OwnerId = 1,
            //        IsDeleted = false,
            //        ParentGuid = null,
            //        AV = true
            //    };

            //    // 向集合列表中添加新纪录
            //    user.navOrgUnits.RootNodes.Add(o);

            //    // 更新操作
            //    var update = Builders<User>.Update.Set(u => u.navOrgUnits.RootNodes, user.navOrgUnits.RootNodes);

            //    // 执行更新
            //    collection.UpdateOne(filter, update);
            //}



            FormsHelper.AddForm("Login", new FormLogin());

            Application.Run(FormsHelper.GetForm("Login"));



        }

        static void PrintObjectProperties(object obj)
        {
            Type type = obj.GetType();
            PropertyInfo[] properties = type.GetProperties();

            foreach (PropertyInfo property in properties)
            {
                object value = property.GetValue(obj);
                Debug.WriteLine($"type:{value.GetType()} {property.Name}: {value}");
            }
        }
    }
}