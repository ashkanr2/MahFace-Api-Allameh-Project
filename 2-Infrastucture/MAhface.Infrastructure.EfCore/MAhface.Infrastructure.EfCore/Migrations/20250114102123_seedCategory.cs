using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MAhface.Infrastructure.EfCore.Migrations
{
    /// <inheritdoc />
    public partial class seedCategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Views_Sections_SectionId",
                schema: "Study",
                table: "Views");

            migrationBuilder.DropTable(
                name: "Sections");

            migrationBuilder.DropIndex(
                name: "IX_Views_SectionId",
                schema: "Study",
                table: "Views");

            migrationBuilder.DropColumn(
                name: "SectionId",
                schema: "Study",
                table: "Views");

            migrationBuilder.CreateTable(
                name: "Episodes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SeasionnId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SeasonId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CourseId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    URL = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Episodes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Episodes_Season_SeasonId",
                        column: x => x.SeasonId,
                        principalSchema: "Study",
                        principalTable: "Season",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "BasicInfo",
                table: "Category",
                columns: new[] { "Id", "CreatedDate", "CreatedUserID", "DeletedDate", "DeletedUserID", "Description", "ISActive", "IsDeleted", "OrderNo", "ParentCategoryId", "Title" },
                values: new object[,]
                {
                    { new Guid("13dc2597-a7a3-482e-b54a-23e83d2ab18b"), new DateTime(2024, 11, 25, 22, 50, 46, 123, DateTimeKind.Unspecified).AddTicks(3333), new Guid("85f9967b-1011-40c0-a32e-87370b013966"), null, null, "", true, false, 7, null, "دانشگاهی علوم پایه پزشکی" },
                    { new Guid("35f3bf57-7f05-41a7-8ecb-9b48bcd52fa7"), new DateTime(2024, 11, 25, 22, 50, 24, 423, DateTimeKind.Unspecified).AddTicks(3333), new Guid("85f9967b-1011-40c0-a32e-87370b013966"), null, null, "", true, false, 6, null, "دانشگاهی فنی و مهندسی" },
                    { new Guid("3cfad89a-7c7b-497e-acd6-9bfc97d48a9b"), new DateTime(2024, 11, 25, 22, 49, 8, 46, DateTimeKind.Unspecified).AddTicks(6667), new Guid("85f9967b-1011-40c0-a32e-87370b013966"), null, null, "", true, false, 2, null, "آی تی  و نرم افزار" },
                    { new Guid("463044b4-343f-4101-b2a3-73012d059ac9"), new DateTime(2024, 11, 25, 22, 51, 16, 403, DateTimeKind.Unspecified).AddTicks(3333), new Guid("85f9967b-1011-40c0-a32e-87370b013966"), null, null, "", true, false, 9, null, "هنر" },
                    { new Guid("4a6ef880-e352-49dc-0976-08dd0d886873"), new DateTime(2024, 11, 25, 23, 6, 7, 541, DateTimeKind.Unspecified).AddTicks(9737), new Guid("85f9967b-1011-40c0-a32e-87370b013966"), null, null, "string", true, false, 0, null, "تستی" },
                    { new Guid("75f6493f-813e-4d97-a0ea-e4203b90f436"), new DateTime(2024, 11, 25, 22, 51, 6, 316, DateTimeKind.Unspecified).AddTicks(6667), new Guid("85f9967b-1011-40c0-a32e-87370b013966"), null, null, "", true, false, 8, null, "علوم پایه" },
                    { new Guid("7dbb7444-f7a7-46d7-aa82-d35f70b2165d"), new DateTime(2024, 11, 25, 22, 50, 4, 16, DateTimeKind.Unspecified).AddTicks(6667), new Guid("85f9967b-1011-40c0-a32e-87370b013966"), null, null, "", true, false, 5, null, "مالی و سرمایه گذاری" },
                    { new Guid("a2a57c78-7043-42e3-a156-ea5ad99fc083"), new DateTime(2024, 11, 25, 22, 49, 40, 350, DateTimeKind.Unspecified), new Guid("85f9967b-1011-40c0-a32e-87370b013966"), null, null, "", true, false, 4, null, "مدیریت و کسب وکار" },
                    { new Guid("a654d03d-4e58-47fb-b70c-5e9433677052"), new DateTime(2024, 11, 25, 22, 49, 22, 566, DateTimeKind.Unspecified).AddTicks(6667), new Guid("85f9967b-1011-40c0-a32e-87370b013966"), null, null, "", true, false, 3, null, "زبان های خارجی" },
                    { new Guid("c758ad65-5f5d-43cf-b676-8dac2d2cf948"), new DateTime(2024, 11, 25, 22, 48, 45, 830, DateTimeKind.Unspecified), new Guid("85f9967b-1011-40c0-a32e-87370b013966"), null, null, "", true, false, 1, null, "برنامه نویسی" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Episodes_SeasonId",
                table: "Episodes",
                column: "SeasonId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Episodes");

            migrationBuilder.DeleteData(
                schema: "BasicInfo",
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("13dc2597-a7a3-482e-b54a-23e83d2ab18b"));

            migrationBuilder.DeleteData(
                schema: "BasicInfo",
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("35f3bf57-7f05-41a7-8ecb-9b48bcd52fa7"));

            migrationBuilder.DeleteData(
                schema: "BasicInfo",
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("3cfad89a-7c7b-497e-acd6-9bfc97d48a9b"));

            migrationBuilder.DeleteData(
                schema: "BasicInfo",
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("463044b4-343f-4101-b2a3-73012d059ac9"));

            migrationBuilder.DeleteData(
                schema: "BasicInfo",
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("4a6ef880-e352-49dc-0976-08dd0d886873"));

            migrationBuilder.DeleteData(
                schema: "BasicInfo",
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("75f6493f-813e-4d97-a0ea-e4203b90f436"));

            migrationBuilder.DeleteData(
                schema: "BasicInfo",
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("7dbb7444-f7a7-46d7-aa82-d35f70b2165d"));

            migrationBuilder.DeleteData(
                schema: "BasicInfo",
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("a2a57c78-7043-42e3-a156-ea5ad99fc083"));

            migrationBuilder.DeleteData(
                schema: "BasicInfo",
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("a654d03d-4e58-47fb-b70c-5e9433677052"));

            migrationBuilder.DeleteData(
                schema: "BasicInfo",
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("c758ad65-5f5d-43cf-b676-8dac2d2cf948"));

            migrationBuilder.AddColumn<Guid>(
                name: "SectionId",
                schema: "Study",
                table: "Views",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "Sections",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SeasonId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUserID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedUserID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HashUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ISActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    SeasionnId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    URL = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sections", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sections_Season_SeasonId",
                        column: x => x.SeasonId,
                        principalSchema: "Study",
                        principalTable: "Season",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Views_SectionId",
                schema: "Study",
                table: "Views",
                column: "SectionId");

            migrationBuilder.CreateIndex(
                name: "IX_Sections_SeasonId",
                table: "Sections",
                column: "SeasonId");

            migrationBuilder.AddForeignKey(
                name: "FK_Views_Sections_SectionId",
                schema: "Study",
                table: "Views",
                column: "SectionId",
                principalTable: "Sections",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
