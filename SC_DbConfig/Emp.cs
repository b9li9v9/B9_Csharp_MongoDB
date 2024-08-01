/*
namespace SC_DbConfig
{
    internal class Emp
    {
        public long EmpId { get; set; }
        public string EmpName { get; set; }
        public long UserOwn { get; set; }
        public Guid DeptOwn {  get; set; }
        //从属验证 "Attribution Verification" 的缩写可以是 AV。
        public bool AV { get; set; }


        public User FKUserOwn { get; set; } = null!;
        //public Dept FKDeptOwnId { get; set; } = null!;
    }

    internal class EmpConfig : IEntityTypeConfiguration<Emp>
    {
        public void Configure(EntityTypeBuilder<Emp> builder)
        {
            builder.ToTable("T_Emps");
            //builder.Property(t => t.EmpName).HasMaxLength(50).IsRequired();


            //FK
            builder.HasOne<User>(e => e.FKUserOwn)
                    .WithMany(u => u.FKEmps)
                    .HasForeignKey(e => e.UserOwn);

            //builder.HasOne<Dept>(e => e.FKDeptOwnId)
            //        .WithMany(d => d.FKEmps)
            //        .HasForeignKey(e => e.DeptOwnId);

        }
    }
}
*/