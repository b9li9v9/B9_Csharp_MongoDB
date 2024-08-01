﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SC_DbConfig;

#nullable disable

namespace SC_DbConfig.Migrations
{
    [DbContext(typeof(SC_DbContext))]
    partial class SC_DbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SC_DbConfig.OrgUnit", b =>
                {
                    b.Property<Guid>("Guid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("AV")
                        .HasColumnType("bit");

                    b.Property<string>("EmpName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("OrgName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(50)");

                    b.Property<long>("OwnerId")
                        .HasColumnType("bigint");

                    b.Property<Guid?>("ParentGuid")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Guid");

                    b.HasIndex("OwnerId");

                    b.HasIndex("ParentGuid");

                    b.ToTable("T_OrgUnits", (string)null);
                });

            modelBuilder.Entity("SC_DbConfig.User", b =>
                {
                    b.Property<long>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("UserId"));

                    b.Property<string>("Acct")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Nick")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("pwd")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("UserId");

                    b.ToTable("T_Users", (string)null);
                });

            modelBuilder.Entity("SC_DbConfig.OrgUnit", b =>
                {
                    b.HasOne("SC_DbConfig.User", "NavOwnerId")
                        .WithMany()
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("SC_DbConfig.OrgUnit", "NavParent")
                        .WithMany("NavChildrens")
                        .HasForeignKey("ParentGuid")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("NavOwnerId");

                    b.Navigation("NavParent");
                });

            modelBuilder.Entity("SC_DbConfig.OrgUnit", b =>
                {
                    b.Navigation("NavChildrens");
                });
#pragma warning restore 612, 618
        }
    }
}
