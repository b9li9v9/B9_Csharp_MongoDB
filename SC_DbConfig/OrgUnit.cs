using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SC_DbConfig
{
    internal class OrgUnit
    {
        /// <summary>
        /// 父节点 控制 AV 子节点的合法性 (根节点默认true)
        /// UserId 控制 IsDeleted 数据的存在性 以及数据拥有者
        /// </summary>
        public Guid Guid { get; set; }     
        public string EmpName { get; set; }     // 员工名字
        public string OrgName { get; set; }     // 组织、部门名字
        public long OwnerId { get; set; }     // 数据拥有者
        public bool IsDeleted { get; set; }
        public Guid? ParentGuid { get; set; } // 即是父节点 也是上级领导人
        public bool AV { get; set; } // 节点合法性

        //外键设置
        public User NavOwnerId { get; set; } // 单项导航
        public OrgUnit NavParent { get; set; }
        public ICollection<OrgUnit> NavChildrens { get; } = new List<OrgUnit>();
    }

    internal class OrgUnitConfig : IEntityTypeConfiguration<OrgUnit>
    {
        public void Configure(EntityTypeBuilder<OrgUnit> builder)
        {
            builder.ToTable("T_OrgUnits");
            builder.HasKey(o => o.Guid);
            builder.Property(o => o.OrgName).IsUnicode().IsRequired().HasMaxLength(50);
            builder.Property(o => o.EmpName).IsUnicode().IsRequired().HasMaxLength(50);
            builder.HasOne<OrgUnit>(o => o.NavParent).WithMany(o => o.NavChildrens).HasForeignKey(o=>o.ParentGuid).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne<User>(o => o.NavOwnerId).WithMany().HasForeignKey(o => o.OwnerId).OnDelete(DeleteBehavior.Restrict);
            builder.HasQueryFilter(o => o.IsDeleted == false); // 全局搜索器 支持软删除
        }
    }
}
