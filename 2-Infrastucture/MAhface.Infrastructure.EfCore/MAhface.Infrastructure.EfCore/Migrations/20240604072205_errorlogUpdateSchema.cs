using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MAhface.Infrastructure.EfCore.Migrations
{
    /// <inheritdoc />
    public partial class errorlogUpdateSchema : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ErrorLogs",
                table: "ErrorLogs");

            migrationBuilder.EnsureSchema(
                name: "System");

            migrationBuilder.RenameTable(
                name: "ErrorLogs",
                newName: "ErrorLog",
                newSchema: "System");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ErrorLog",
                schema: "System",
                table: "ErrorLog",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ErrorLog",
                schema: "System",
                table: "ErrorLog");

            migrationBuilder.RenameTable(
                name: "ErrorLog",
                schema: "System",
                newName: "ErrorLogs");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ErrorLogs",
                table: "ErrorLogs",
                column: "Id");
        }
    }
}
