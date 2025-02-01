using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MAhface.Infrastructure.EfCore.Migrations
{
    /// <inheritdoc />
    public partial class Emailsetting2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "EmailSetting",
                keyColumn: "Id",
                keyValue: new Guid("d4819e1b-3dab-4d13-9ee5-dfb6c2aee0ff"),
                column: "SMTPPort",
                value: 587);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "EmailSetting",
                keyColumn: "Id",
                keyValue: new Guid("d4819e1b-3dab-4d13-9ee5-dfb6c2aee0ff"),
                column: "SMTPPort",
                value: 0);
        }
    }
}
