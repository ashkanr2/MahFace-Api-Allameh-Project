using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MAhface.Infrastructure.EfCore.Migrations
{
    /// <inheritdoc />
    public partial class AddcourseInImage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Course_ImageId",
                schema: "Study",
                table: "Course");

            migrationBuilder.CreateIndex(
                name: "IX_Course_ImageId",
                schema: "Study",
                table: "Course",
                column: "ImageId",
                unique: true,
                filter: "[ImageId] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Course_ImageId",
                schema: "Study",
                table: "Course");

            migrationBuilder.CreateIndex(
                name: "IX_Course_ImageId",
                schema: "Study",
                table: "Course",
                column: "ImageId");
        }
    }
}
