using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MAhface.Infrastructure.EfCore.Migrations
{
    /// <inheritdoc />
    public partial class removeSection : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Section_Season_SeasonId",
                schema: "Study",
                table: "Section");

            migrationBuilder.DropForeignKey(
                name: "FK_Views_Section_SectionId",
                schema: "Study",
                table: "Views");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Section",
                schema: "Study",
                table: "Section");

            migrationBuilder.RenameTable(
                name: "Section",
                schema: "Study",
                newName: "Sections");

            migrationBuilder.RenameIndex(
                name: "IX_Section_SeasonId",
                table: "Sections",
                newName: "IX_Sections_SeasonId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sections",
                table: "Sections",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Sections_Season_SeasonId",
                table: "Sections",
                column: "SeasonId",
                principalSchema: "Study",
                principalTable: "Season",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Views_Sections_SectionId",
                schema: "Study",
                table: "Views",
                column: "SectionId",
                principalTable: "Sections",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sections_Season_SeasonId",
                table: "Sections");

            migrationBuilder.DropForeignKey(
                name: "FK_Views_Sections_SectionId",
                schema: "Study",
                table: "Views");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sections",
                table: "Sections");

            migrationBuilder.RenameTable(
                name: "Sections",
                newName: "Section",
                newSchema: "Study");

            migrationBuilder.RenameIndex(
                name: "IX_Sections_SeasonId",
                schema: "Study",
                table: "Section",
                newName: "IX_Section_SeasonId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Section",
                schema: "Study",
                table: "Section",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Section_Season_SeasonId",
                schema: "Study",
                table: "Section",
                column: "SeasonId",
                principalSchema: "Study",
                principalTable: "Season",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Views_Section_SectionId",
                schema: "Study",
                table: "Views",
                column: "SectionId",
                principalSchema: "Study",
                principalTable: "Section",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
