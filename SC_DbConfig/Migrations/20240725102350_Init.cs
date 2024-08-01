using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SC_DbConfig.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "T_Users",
                columns: table => new
                {
                    UserId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Acct = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Nick = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    pwd = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "T_OrgUnits",
                columns: table => new
                {
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmpName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    OrgName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    OwnerId = table.Column<long>(type: "bigint", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    ParentGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AV = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_OrgUnits", x => x.Guid);
                    table.ForeignKey(
                        name: "FK_T_OrgUnits_T_OrgUnits_ParentGuid",
                        column: x => x.ParentGuid,
                        principalTable: "T_OrgUnits",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_T_OrgUnits_T_Users_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "T_Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_T_OrgUnits_OwnerId",
                table: "T_OrgUnits",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_T_OrgUnits_ParentGuid",
                table: "T_OrgUnits",
                column: "ParentGuid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "T_OrgUnits");

            migrationBuilder.DropTable(
                name: "T_Users");
        }
    }
}
