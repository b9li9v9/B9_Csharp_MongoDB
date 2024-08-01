/*
namespace SC_DbConfig
{
    internal class Org
    {
        public Guid OrgId { get; set; }
        public string OrgName { get; set; }
        public long UserOwn { get; set; }

        //only 负责人
        //many 部门
        public User FKUserOwn { get; set; } = null!;
        //public ICollection<Dept> FKDepts { get;} = new List<Dept>();

    }

    internal class OrgConfig : IEntityTypeConfiguration<Org>
    {
        public void Configure(EntityTypeBuilder<Org> builder)
        {

            builder.ToTable("T_Orgs");
            //builder.Property(o => o.OrgName).HasMaxLength(50).IsRequired();

            //索引 builder.HasIndex(t => t.OrgName);
            //复合索引 builder.HasIndex(t=>new {t.OrgName, t.OrgHeadId});

            //FK 外键设置
            builder.HasOne<User>(o => o.FKUserOwn)
                    .WithMany(u => u.FKOrgs)
                    .HasForeignKey(o => o.UserOwn);

        }
    }
}
*/