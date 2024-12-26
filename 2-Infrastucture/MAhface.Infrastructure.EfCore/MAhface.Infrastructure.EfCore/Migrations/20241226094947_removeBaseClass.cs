using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MAhface.Infrastructure.EfCore.Migrations
{
    /// <inheritdoc />
    public partial class removeBaseClass : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Code",
                table: "TeacherRequests");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "TeacherRequests");

            migrationBuilder.DropColumn(
                name: "CreatedUserID",
                table: "TeacherRequests");

            migrationBuilder.DropColumn(
                name: "DeletedDate",
                table: "TeacherRequests");

            migrationBuilder.DropColumn(
                name: "DeletedUserID",
                table: "TeacherRequests");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "TeacherRequests");

            migrationBuilder.DropColumn(
                name: "ISActive",
                table: "TeacherRequests");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Code",
                table: "TeacherRequests",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "TeacherRequests",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedUserID",
                table: "TeacherRequests",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                table: "TeacherRequests",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DeletedUserID",
                table: "TeacherRequests",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "TeacherRequests",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "ISActive",
                table: "TeacherRequests",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
