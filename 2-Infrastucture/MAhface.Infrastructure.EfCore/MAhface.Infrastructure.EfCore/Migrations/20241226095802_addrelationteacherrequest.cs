using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MAhface.Infrastructure.EfCore.Migrations
{
    /// <inheritdoc />
    public partial class addrelationteacherrequest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_TeacherRequests_UserId",
                table: "TeacherRequests",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_TeacherRequests_AspNetUsers_UserId",
                table: "TeacherRequests",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TeacherRequests_AspNetUsers_UserId",
                table: "TeacherRequests");

            migrationBuilder.DropIndex(
                name: "IX_TeacherRequests_UserId",
                table: "TeacherRequests");
        }
    }
}
