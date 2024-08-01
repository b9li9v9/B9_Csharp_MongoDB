using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace SC_DbConfig
{
    internal class Program
    {
        static void Main(string[] args)
        {  /*
            using (SC_DbContext SC_Db = new SC_DbContext())
            {

            }
          

        using (SC_DbContext SC_Db = new SC_DbContext())
        {

            增
            User user = new User();
            user.Acct = "1@qq.com";
            user.Nick = "阿巴";
            user.pwd = "1@qq.com";
            SC_Db.Add(user);

            Org org = new Org();
            org.OrgName = "阿里云";
            SC_Db.Add(org);

            SC_Db.SaveChanges();

            查
            IQueryable<User> users = SC_Db.Users.Where(u => u.Acct == "1@qq.com");
            foreach (User u in users)
            {
                Console.WriteLine(u.Acct+" "+u.Nick);
            }

            var users = SC_Db.Users.Single(u => u.Acct == "2@email.com");
            Console.WriteLine(users.Nick);
            Org org1 = new Org();
            org1.OrgName = "腾讯";
            org1.OrgHeadId = 1;
            SC_Db.Add(org1);

            Org org2 = new Org();
            org2.OrgName = "阿里巴巴";
            org2.OrgHeadId = 2;
            SC_Db.Add(org2);

            Org org3 = new Org();
            org3.OrgName = "京东";
            org3.OrgHeadId = 3;
            SC_Db.Add(org3);

            SC_Db.SaveChanges();

            var orgs = SC_Db.Orgs.Single(


            var orgs = SC_Db.Orgs.OrderByDescending(u => u.OrgHeadId).Where(u=>u.OrgHeadId>1);
            foreach (var org in orgs) 
            {
                Console.WriteLine(org.OrgName+org.OrgHeadId);
            }

            var items = SC_Db.Orgs.GroupBy(o => o.OrgHeadId)
                        .Select(g => new {OrgheadID = g.Key,OrgCount = g.Count() });
            foreach (var item in items) { 
                Console.WriteLine(item.OrgheadID+" "+item.OrgCount);
            }

            改
            var org = SC_Db.Orgs.Single(o => o.OrgName == "厦航");
            org.OrgName = "厦门航空";
            SC_Db.SaveChanges();


            删
            var org = SC_Db.Orgs.Single(o => o.OrgName == "厦门航空");
            SC_Db.Remove(org);
            SC_Db.SaveChanges();





        }


            
            using (SC_DbContext SC_Db = new SC_DbContext())
            {
            */


            //User user = new User();
            //user.UserId = 10086;
            //user.Acct = "1@qq.com";
            //user.Nick = "小鲨鱼";
            //user.pwd = "123";
            //SC_Db.Users.Add(user);
            //SC_Db.SaveChanges();

            /*
            OrgUnit orgu = new OrgUnit();
            orgu.Guid = Guid.NewGuid();
            orgu.EmpName = "马云";
            orgu.OrgName = "阿里巴巴";
            orgu.UserId = 1;
            orgu.IsDeleted = false;
            orgu.AV = true;
            SC_Db.OrgUnits.Add(orgu);
            SC_Db.SaveChanges();
            */

            /*
            using (SC_DbContext SC_Db = new SC_DbContext())
            {
 

                OrgUnit orgu2 = SC_Db.OrgUnits
                        .Include(o => o.NavChildrens)
                        .Single(o => o.ParentGuid == null);

                Console.WriteLine(orgu2.Guid);

                var orguitem = orgu2.NavChildrens;
                Console.WriteLine(orguitem.Count());
                foreach (OrgUnit o in orguitem)
                {
                    Console.WriteLine(o.OrgName + " " + o.EmpName);
                }
            }

            */


            
        }
        }
    }

