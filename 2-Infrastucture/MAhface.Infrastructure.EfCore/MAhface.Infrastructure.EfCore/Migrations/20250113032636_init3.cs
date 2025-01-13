using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MAhface.Infrastructure.EfCore.Migrations
{
    /// <inheritdoc />
    public partial class init3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sections_Season_SeasonnId",
                table: "Sections");

            migrationBuilder.RenameColumn(
                name: "SeasonnId",
                table: "Sections",
                newName: "SeasonId");

            migrationBuilder.RenameIndex(
                name: "IX_Sections_SeasonnId",
                table: "Sections",
                newName: "IX_Sections_SeasonId");

            migrationBuilder.AddForeignKey(
                name: "FK_Sections_Season_SeasonId",
                table: "Sections",
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
                name: "FK_Sections_Season_SeasonId",
                table: "Sections");

            migrationBuilder.RenameColumn(
                name: "SeasonId",
                table: "Sections",
                newName: "SeasonnId");

            migrationBuilder.RenameIndex(
                name: "IX_Sections_SeasonId",
                table: "Sections",
                newName: "IX_Sections_SeasonnId");

            migrationBuilder.AddForeignKey(
                name: "FK_Sections_Season_SeasonnId",
                table: "Sections",
                column: "SeasonnId",
                principalSchema: "Study",
                principalTable: "Season",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
