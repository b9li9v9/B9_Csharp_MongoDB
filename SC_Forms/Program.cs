
using System.Diagnostics;
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

            FormsHelper.AddForm("Login",new FormLogin());

            Application.Run(FormsHelper.GetForm("Login"));



        }
    }
}