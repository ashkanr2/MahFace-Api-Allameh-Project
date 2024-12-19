using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MAhface.Infrastructure.EfCore.Migrations
{
    /// <inheritdoc />
    public partial class EmailSettingData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "EmailSetting",
                columns: new[] { "Id", "EmailAddress", "Password", "SMTPHost", "SMTPPort" },
                values: new object[] { new Guid("d4819e1b-3dab-4d13-9ee5-dfb6c2aee0ff"), "Register@mahface-allameh.ir", "MahfaceAllamEh", "mail.mahface-allameh.ir", 587 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EmailSetting",
                keyColumn: "Id",
                keyValue: new Guid("d4819e1b-3dab-4d13-9ee5-dfb6c2aee0ff"));
        }
    }
}
