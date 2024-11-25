using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MAhface.Infrastructure.EfCore.Migrations
{
    /// <inheritdoc />
    public partial class seasonidNameFixing : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Section_Season_seasonId",
                schema: "Study",
                table: "Section");

            migrationBuilder.RenameColumn(
                name: "seasonId",
                schema: "Study",
                table: "Section",
                newName: "SeasonId");

            migrationBuilder.RenameIndex(
                name: "IX_Section_seasonId",
                schema: "Study",
                table: "Section",
                newName: "IX_Section_SeasonId");

            migrationBuilder.AddForeignKey(
                name: "FK_Section_Season_SeasonId",
                schema: "Study",
                table: "Section",
                column: "SeasonId",
                principalSchema: "Study",
                principalTable: "Season",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Section_Season_SeasonId",
                schema: "Study",
                table: "Section");

            migrationBuilder.RenameColumn(
                name: "SeasonId",
                schema: "Study",
                table: "Section",
                newName: "seasonId");

            migrationBuilder.RenameIndex(
                name: "IX_Section_SeasonId",
                schema: "Study",
                table: "Section",
                newName: "IX_Section_seasonId");

            migrationBuilder.AddForeignKey(
                name: "FK_Section_Season_seasonId",
                schema: "Study",
                table: "Section",
                column: "seasonId",
                principalSchema: "Study",
                principalTable: "Season",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
