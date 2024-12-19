using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MAhface.Infrastructure.EfCore.Migrations
{
    /// <inheritdoc />
    public partial class UpdateOTP : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Otps");

            migrationBuilder.RenameColumn(
                name: "PhoneNumber",
                table: "Otps",
                newName: "EmailOrPhoneNumber");

            migrationBuilder.AlterColumn<int>(
                name: "OtpCode",
                table: "Otps",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EmailOrPhoneNumber",
                table: "Otps",
                newName: "PhoneNumber");

            migrationBuilder.AlterColumn<string>(
                name: "OtpCode",
                table: "Otps",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Otps",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
