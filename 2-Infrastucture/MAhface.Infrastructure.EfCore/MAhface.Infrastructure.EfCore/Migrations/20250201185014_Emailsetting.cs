using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MAhface.Infrastructure.EfCore.Migrations
{
    /// <inheritdoc />
    public partial class Emailsetting : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "EmailSetting",
                keyColumn: "Id",
                keyValue: new Guid("d4819e1b-3dab-4d13-9ee5-dfb6c2aee0ff"),
                columns: new[] { "EmailAddress", "Password", "SMTPHost", "SMTPPort" },
                values: new object[] { "mahface@ashkanrazavi.ir", "Ashkan12345678", "mail.ashkanrazavi.ir", 0 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "EmailSetting",
                keyColumn: "Id",
                keyValue: new Guid("d4819e1b-3dab-4d13-9ee5-dfb6c2aee0ff"),
                columns: new[] { "EmailAddress", "Password", "SMTPHost", "SMTPPort" },
                values: new object[] { "Register@mahface-allameh.ir", "MahfaceAllamEh", "mail.mahface-allameh.ir", 587 });
        }
    }
}
