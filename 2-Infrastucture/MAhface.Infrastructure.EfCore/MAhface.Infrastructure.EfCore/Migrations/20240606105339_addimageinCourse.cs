using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MAhface.Infrastructure.EfCore.Migrations
{
    /// <inheritdoc />
    public partial class addimageinCourse : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Course_ImageId",
                schema: "Study",
                table: "Course",
                column: "ImageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Image_ImageId",
                schema: "Study",
                table: "Course",
                column: "ImageId",
                principalSchema: "BasicInfo",
                principalTable: "Image",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Course_Image_ImageId",
                schema: "Study",
                table: "Course");

            migrationBuilder.DropIndex(
                name: "IX_Course_ImageId",
                schema: "Study",
                table: "Course");
        }
    }
}
