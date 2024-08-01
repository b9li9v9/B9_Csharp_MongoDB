using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SC_DbConfig
{
    internal class User
    {
        public long UserId { get; set; }
        public string Acct { get; set; }
        public string Nick { get; set; }
        public string pwd { get; set; }

        public bool IsDeleted { get; set; }

        //only 
        //many 员工身份档案
        //public ICollection<Org> FKOrgs { get; } = new List<Org>();
        //public ICollection<Dept> FKDepts { get; } = new List<Dept>();
        //public ICollection<Emp> FKEmps { get; } = new List<Emp>();
    }

    internal class UserConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("T_Users");
            builder.HasKey(u => u.UserId);
            builder.Property(u => u.Acct).HasMaxLength(50).IsRequired();
            builder.Property(u => u.Nick).HasMaxLength(50).IsRequired();
            builder.Property(u => u.pwd).HasMaxLength(50).IsRequired();
            builder.HasQueryFilter(u => u.IsDeleted == false); // 全局搜索器 支持软删除
        }
    }
}
