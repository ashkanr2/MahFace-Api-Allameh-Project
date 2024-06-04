using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MAhface.Infrastructure.EfCore.Migrations
{
    /// <inheritdoc />
    public partial class seasons : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Descrption",
                schema: "Study",
                table: "Season",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Title",
                schema: "Study",
                table: "Season",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Descrption",
                schema: "Study",
                table: "Season");

            migrationBuilder.DropColumn(
                name: "Title",
                schema: "Study",
                table: "Season");
        }
    }
}
