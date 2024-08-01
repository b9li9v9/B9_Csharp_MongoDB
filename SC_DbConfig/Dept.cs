/*
namespace SC_DbConfig
{
    internal class Dept
    {
        public Guid DeptId { get; set; }
        public string DeptName { get; set; }
        public long? UserOwn { get; set; }
        public Guid OrgOwn { get; set; }
        //"Attribution Verification" 的缩写可以是 AV。 .
        public bool AV { get; set; }

        public User FKUserOwn { get; set; } = null!;
        //public Org FKOrgOwn { get; set; } = null!;
        //public ICollection<Emp> FKEmps { get; } = new List<Emp>();
    }

    internal class DeptConfig : IEntityTypeConfiguration<Dept>
    {
        public void Configure(EntityTypeBuilder<Dept> builder)
        {
            builder.ToTable("T_Depts");
            //builder.Property(d => d.DeptName).HasMaxLength(50).IsRequired();

            //FK
            builder.HasOne<User>(d => d.FKUserOwn)
                    .WithMany(u => u.FKDepts)
                    .HasForeignKey(d => d.UserOwn)
                    .OnDelete(DeleteBehavior.SetNull);



            //builder.HasOne<Org>(d => d.FKOrgOwn)
            //        .WithMany(o => o.FKDepts)
            //        .HasForeignKey(d => d.OrgOwn);

        }
    }
}
*/