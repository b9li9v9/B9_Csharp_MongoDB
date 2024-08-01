using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Runtime.CompilerServices;
[assembly: InternalsVisibleTo("SC_Forms")]

namespace SC_DbConfig
{
    internal class SC_DbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<OrgUnit> OrgUnits { get; set; }
        //public DbSet<Org> Orgs { get; set; }
        //public DbSet<Dept> Depts { get; set; }
        //public DbSet<Emp> Emps { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            //string connStr = "server=DESKTOP-10B83JG\\SQLEXPRESS;uid=zhangsan;pwd=111111;database=SC_DB;Encrypt=False;";
            string connStr = "server=.;uid=zhangsan;pwd=123456;database=SC_DB;Encrypt=False;";
            optionsBuilder.UseSqlServer(connStr);
            //optionsBuilder.LogTo(msg => { if (!msg.Contains("CommandExecuting")) return;Debug.WriteLine(msg); });
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // ICollection -> “集合” 的意思
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(this.GetType().Assembly);
        }
    }
}
