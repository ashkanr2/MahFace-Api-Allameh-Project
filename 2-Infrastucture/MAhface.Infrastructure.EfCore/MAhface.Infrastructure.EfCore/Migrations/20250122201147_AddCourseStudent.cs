using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MAhface.Infrastructure.EfCore.Migrations
{
    /// <inheritdoc />
    public partial class AddCourseStudent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StudentCourses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CourseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentCourses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StudentCourses_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentCourses_Course_CourseId",
                        column: x => x.CourseId,
                        principalSchema: "Study",
                        principalTable: "Course",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("13dc2597-a7a3-482e-b54a-23e83d2ab18b"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 22, 23, 41, 44, 961, DateTimeKind.Local).AddTicks(3101));

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("35f3bf57-7f05-41a7-8ecb-9b48bcd52fa7"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 22, 23, 41, 44, 961, DateTimeKind.Local).AddTicks(3118));

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("3cfad89a-7c7b-497e-acd6-9bfc97d48a9b"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 22, 23, 41, 44, 961, DateTimeKind.Local).AddTicks(3122));

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("463044b4-343f-4101-b2a3-73012d059ac9"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 22, 23, 41, 44, 961, DateTimeKind.Local).AddTicks(3109));

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("4a6ef880-e352-49dc-0976-08dd0d886873"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 22, 23, 41, 44, 961, DateTimeKind.Local).AddTicks(3076));

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("75f6493f-813e-4d97-a0ea-e4203b90f436"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 22, 23, 41, 44, 961, DateTimeKind.Local).AddTicks(3129));

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("7dbb7444-f7a7-46d7-aa82-d35f70b2165d"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 22, 23, 41, 44, 961, DateTimeKind.Local).AddTicks(3125));

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("a2a57c78-7043-42e3-a156-ea5ad99fc083"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 22, 23, 41, 44, 961, DateTimeKind.Local).AddTicks(3133));

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("a654d03d-4e58-47fb-b70c-5e9433677052"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 22, 23, 41, 44, 961, DateTimeKind.Local).AddTicks(3105));

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("c758ad65-5f5d-43cf-b676-8dac2d2cf948"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 22, 23, 41, 44, 961, DateTimeKind.Local).AddTicks(3112));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("12f272c9-f198-45c4-a260-08dd37ab6f06"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 22, 23, 41, 44, 961, DateTimeKind.Local).AddTicks(3743));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("39a2b245-8188-4b47-b508-08dd37ab7f09"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 22, 23, 41, 44, 961, DateTimeKind.Local).AddTicks(3803));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("42d99c9a-7d35-4a45-a256-08dd37ab6f02"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 22, 23, 41, 44, 961, DateTimeKind.Local).AddTicks(3718));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("5f2b414d-63ec-4d3b-bfd3-08dd37aa0f43"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 22, 23, 41, 44, 961, DateTimeKind.Local).AddTicks(3679));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("6d9c7e02-56c7-4a77-b506-08dd37ab7f07"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 22, 23, 41, 44, 961, DateTimeKind.Local).AddTicks(3791));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("71b3bede-4e8e-4207-a7d4-08dd37aa0f45"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 22, 23, 41, 44, 961, DateTimeKind.Local).AddTicks(3694));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("7f6f6aab-c44f-4d30-a257-08dd37ab6f03"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 22, 23, 41, 44, 961, DateTimeKind.Local).AddTicks(3725));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("876a3131-1dc9-4a21-b509-08dd37ab7f10"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 22, 23, 41, 44, 961, DateTimeKind.Local).AddTicks(3809));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("89e4b1db-9b95-4fa8-a261-08dd37ab6f07"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 22, 23, 41, 44, 961, DateTimeKind.Local).AddTicks(3750));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("9d7f57a8-26d1-4b9f-a255-08dd37ab6f01"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 22, 23, 41, 44, 961, DateTimeKind.Local).AddTicks(3712));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("a12c08e7-8827-4912-b502-08dd37ab7f03"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 22, 23, 41, 44, 961, DateTimeKind.Local).AddTicks(3767));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("ab3e4a26-9e2f-46fa-b510-08dd37ab7f11"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 22, 23, 41, 44, 961, DateTimeKind.Local).AddTicks(3815));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("af8d7e39-0f8f-42b9-b1c3-08dd37aa0f44"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 22, 23, 41, 44, 961, DateTimeKind.Local).AddTicks(3687));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("b3e0b271-f8e0-4b3a-a7e5-08dd37aa0f46"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 22, 23, 41, 44, 961, DateTimeKind.Local).AddTicks(3701));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("b8c1131e-c817-44ea-a258-08dd37ab6f04"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 22, 23, 41, 44, 961, DateTimeKind.Local).AddTicks(3730));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("bf3ea476-bc8f-4572-b504-08dd37ab7f05"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 22, 23, 41, 44, 961, DateTimeKind.Local).AddTicks(3779));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("c1e3b450-628f-4a43-b7e3-08dd37aa0f47"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 22, 23, 41, 44, 961, DateTimeKind.Local).AddTicks(3706));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("c7f3d234-9fc3-453a-b500-08dd37ab7f01"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 22, 23, 41, 44, 961, DateTimeKind.Local).AddTicks(3756));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("d52d29fb-80da-40b0-a259-08dd37ab6f05"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 22, 23, 41, 44, 961, DateTimeKind.Local).AddTicks(3737));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("d75d8d12-fdf9-45c8-b503-08dd37ab7f04"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 22, 23, 41, 44, 961, DateTimeKind.Local).AddTicks(3774));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("ef123b19-3b99-4c24-b507-08dd37ab7f08"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 22, 23, 41, 44, 961, DateTimeKind.Local).AddTicks(3798));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("f3e321eb-94d8-4b8d-b505-08dd37ab7f06"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 22, 23, 41, 44, 961, DateTimeKind.Local).AddTicks(3786));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("f9ad1d79-7325-497e-b501-08dd37ab7f02"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 22, 23, 41, 44, 961, DateTimeKind.Local).AddTicks(3762));

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("0c7938f9-e881-42fa-242b-08dd2592d1dd"),
                columns: new[] { "CreatedDate", "CreatedUserID" },
                values: new object[] { new DateTime(2025, 1, 22, 23, 41, 44, 961, DateTimeKind.Local).AddTicks(3577), new Guid("b796c270-eb62-4afb-bef5-ec64f7b2298f") });

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("1f262031-5db7-47ae-893d-08dd0d86a8be"),
                columns: new[] { "CreatedDate", "CreatedUserID" },
                values: new object[] { new DateTime(2025, 1, 22, 23, 41, 44, 961, DateTimeKind.Local).AddTicks(3562), new Guid("605f5f66-845d-48c6-9b59-478f2e34dc06") });

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("2603e63f-9b46-4807-72be-08dd0d8f6f8f"),
                columns: new[] { "CreatedDate", "CreatedUserID" },
                values: new object[] { new DateTime(2025, 1, 22, 23, 41, 44, 961, DateTimeKind.Local).AddTicks(3569), new Guid("a4153638-847a-409d-85f2-15dbdfb9e934") });

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("3a4086aa-1278-4325-242c-08dd2592d1dd"),
                columns: new[] { "CreatedDate", "CreatedUserID" },
                values: new object[] { new DateTime(2025, 1, 22, 23, 41, 44, 961, DateTimeKind.Local).AddTicks(3582), new Guid("dabcfb99-a143-4d7e-8482-c21653d63c3c") });

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("486c341e-03d9-4616-242e-08dd2592d1dd"),
                columns: new[] { "CreatedDate", "CreatedUserID" },
                values: new object[] { new DateTime(2025, 1, 22, 23, 41, 44, 961, DateTimeKind.Local).AddTicks(3626), new Guid("bfb91ae0-81a9-4f03-93f8-a5b123563b04") });

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("55a3337f-cfa5-4440-242a-08dd2592d1dd"),
                columns: new[] { "CreatedDate", "CreatedUserID" },
                values: new object[] { new DateTime(2025, 1, 22, 23, 41, 44, 961, DateTimeKind.Local).AddTicks(3573), new Guid("28f1a760-3d38-40b3-a532-cb5205edd820") });

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("ecf68ade-4b48-4307-242d-08dd2592d1dd"),
                columns: new[] { "CreatedDate", "CreatedUserID" },
                values: new object[] { new DateTime(2025, 1, 22, 23, 41, 44, 961, DateTimeKind.Local).AddTicks(3621), new Guid("69705096-b9b9-45cb-91e7-abc21392af51") });

            migrationBuilder.CreateIndex(
                name: "IX_StudentCourses_CourseId",
                table: "StudentCourses",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentCourses_UserId",
                table: "StudentCourses",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentCourses");

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("13dc2597-a7a3-482e-b54a-23e83d2ab18b"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 21, 20, 7, 18, 706, DateTimeKind.Local).AddTicks(1299));

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("35f3bf57-7f05-41a7-8ecb-9b48bcd52fa7"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 21, 20, 7, 18, 706, DateTimeKind.Local).AddTicks(1315));

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("3cfad89a-7c7b-497e-acd6-9bfc97d48a9b"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 21, 20, 7, 18, 706, DateTimeKind.Local).AddTicks(1359));

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("463044b4-343f-4101-b2a3-73012d059ac9"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 21, 20, 7, 18, 706, DateTimeKind.Local).AddTicks(1307));

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("4a6ef880-e352-49dc-0976-08dd0d886873"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 21, 20, 7, 18, 706, DateTimeKind.Local).AddTicks(1277));

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("75f6493f-813e-4d97-a0ea-e4203b90f436"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 21, 20, 7, 18, 706, DateTimeKind.Local).AddTicks(1366));

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("7dbb7444-f7a7-46d7-aa82-d35f70b2165d"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 21, 20, 7, 18, 706, DateTimeKind.Local).AddTicks(1362));

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("a2a57c78-7043-42e3-a156-ea5ad99fc083"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 21, 20, 7, 18, 706, DateTimeKind.Local).AddTicks(1371));

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("a654d03d-4e58-47fb-b70c-5e9433677052"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 21, 20, 7, 18, 706, DateTimeKind.Local).AddTicks(1303));

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("c758ad65-5f5d-43cf-b676-8dac2d2cf948"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 21, 20, 7, 18, 706, DateTimeKind.Local).AddTicks(1310));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("12f272c9-f198-45c4-a260-08dd37ab6f06"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 21, 20, 7, 18, 706, DateTimeKind.Local).AddTicks(2112));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("39a2b245-8188-4b47-b508-08dd37ab7f09"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 21, 20, 7, 18, 706, DateTimeKind.Local).AddTicks(2173));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("42d99c9a-7d35-4a45-a256-08dd37ab6f02"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 21, 20, 7, 18, 706, DateTimeKind.Local).AddTicks(2085));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("5f2b414d-63ec-4d3b-bfd3-08dd37aa0f43"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 21, 20, 7, 18, 706, DateTimeKind.Local).AddTicks(2002));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("6d9c7e02-56c7-4a77-b506-08dd37ab7f07"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 21, 20, 7, 18, 706, DateTimeKind.Local).AddTicks(2161));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("71b3bede-4e8e-4207-a7d4-08dd37aa0f45"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 21, 20, 7, 18, 706, DateTimeKind.Local).AddTicks(2018));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("7f6f6aab-c44f-4d30-a257-08dd37ab6f03"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 21, 20, 7, 18, 706, DateTimeKind.Local).AddTicks(2090));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("876a3131-1dc9-4a21-b509-08dd37ab7f10"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 21, 20, 7, 18, 706, DateTimeKind.Local).AddTicks(2179));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("89e4b1db-9b95-4fa8-a261-08dd37ab6f07"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 21, 20, 7, 18, 706, DateTimeKind.Local).AddTicks(2119));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("9d7f57a8-26d1-4b9f-a255-08dd37ab6f01"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 21, 20, 7, 18, 706, DateTimeKind.Local).AddTicks(2079));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("a12c08e7-8827-4912-b502-08dd37ab7f03"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 21, 20, 7, 18, 706, DateTimeKind.Local).AddTicks(2136));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("ab3e4a26-9e2f-46fa-b510-08dd37ab7f11"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 21, 20, 7, 18, 706, DateTimeKind.Local).AddTicks(2184));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("af8d7e39-0f8f-42b9-b1c3-08dd37aa0f44"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 21, 20, 7, 18, 706, DateTimeKind.Local).AddTicks(2011));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("b3e0b271-f8e0-4b3a-a7e5-08dd37aa0f46"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 21, 20, 7, 18, 706, DateTimeKind.Local).AddTicks(2064));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("b8c1131e-c817-44ea-a258-08dd37ab6f04"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 21, 20, 7, 18, 706, DateTimeKind.Local).AddTicks(2096));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("bf3ea476-bc8f-4572-b504-08dd37ab7f05"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 21, 20, 7, 18, 706, DateTimeKind.Local).AddTicks(2148));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("c1e3b450-628f-4a43-b7e3-08dd37aa0f47"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 21, 20, 7, 18, 706, DateTimeKind.Local).AddTicks(2071));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("c7f3d234-9fc3-453a-b500-08dd37ab7f01"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 21, 20, 7, 18, 706, DateTimeKind.Local).AddTicks(2125));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("d52d29fb-80da-40b0-a259-08dd37ab6f05"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 21, 20, 7, 18, 706, DateTimeKind.Local).AddTicks(2103));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("d75d8d12-fdf9-45c8-b503-08dd37ab7f04"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 21, 20, 7, 18, 706, DateTimeKind.Local).AddTicks(2142));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("ef123b19-3b99-4c24-b507-08dd37ab7f08"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 21, 20, 7, 18, 706, DateTimeKind.Local).AddTicks(2167));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("f3e321eb-94d8-4b8d-b505-08dd37ab7f06"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 21, 20, 7, 18, 706, DateTimeKind.Local).AddTicks(2155));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("f9ad1d79-7325-497e-b501-08dd37ab7f02"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 21, 20, 7, 18, 706, DateTimeKind.Local).AddTicks(2130));

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("0c7938f9-e881-42fa-242b-08dd2592d1dd"),
                columns: new[] { "CreatedDate", "CreatedUserID" },
                values: new object[] { new DateTime(2025, 1, 21, 20, 7, 18, 706, DateTimeKind.Local).AddTicks(1934), new Guid("e3274ee1-6824-437e-865b-a8515cec019b") });

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("1f262031-5db7-47ae-893d-08dd0d86a8be"),
                columns: new[] { "CreatedDate", "CreatedUserID" },
                values: new object[] { new DateTime(2025, 1, 21, 20, 7, 18, 706, DateTimeKind.Local).AddTicks(1911), new Guid("e4e552a6-f0c5-4ac9-81ae-fbe016b68f04") });

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("2603e63f-9b46-4807-72be-08dd0d8f6f8f"),
                columns: new[] { "CreatedDate", "CreatedUserID" },
                values: new object[] { new DateTime(2025, 1, 21, 20, 7, 18, 706, DateTimeKind.Local).AddTicks(1923), new Guid("36c6c605-a8ff-41cc-92c7-2d385fc19b18") });

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("3a4086aa-1278-4325-242c-08dd2592d1dd"),
                columns: new[] { "CreatedDate", "CreatedUserID" },
                values: new object[] { new DateTime(2025, 1, 21, 20, 7, 18, 706, DateTimeKind.Local).AddTicks(1939), new Guid("e5edc047-0330-4f83-9ed1-c31f6dbab1fd") });

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("486c341e-03d9-4616-242e-08dd2592d1dd"),
                columns: new[] { "CreatedDate", "CreatedUserID" },
                values: new object[] { new DateTime(2025, 1, 21, 20, 7, 18, 706, DateTimeKind.Local).AddTicks(1948), new Guid("1e438e4e-6d56-4068-87d9-39e8cfa292cb") });

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("55a3337f-cfa5-4440-242a-08dd2592d1dd"),
                columns: new[] { "CreatedDate", "CreatedUserID" },
                values: new object[] { new DateTime(2025, 1, 21, 20, 7, 18, 706, DateTimeKind.Local).AddTicks(1928), new Guid("b324ff8b-2370-4503-b437-fa47c069cc69") });

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("ecf68ade-4b48-4307-242d-08dd2592d1dd"),
                columns: new[] { "CreatedDate", "CreatedUserID" },
                values: new object[] { new DateTime(2025, 1, 21, 20, 7, 18, 706, DateTimeKind.Local).AddTicks(1944), new Guid("4bcdb614-84fc-4a1d-a16b-f81ba5b0aa3a") });
        }
    }
}
