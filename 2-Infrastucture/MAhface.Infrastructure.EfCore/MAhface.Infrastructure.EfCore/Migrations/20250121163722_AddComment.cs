using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MAhface.Infrastructure.EfCore.Migrations
{
    /// <inheritdoc />
    public partial class AddComment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CourseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedUserID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedUserID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ISActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Comments_Course_CourseId",
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

            migrationBuilder.CreateIndex(
                name: "IX_Comments_CourseId",
                table: "Comments",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_UserId",
                table: "Comments",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("13dc2597-a7a3-482e-b54a-23e83d2ab18b"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 17, 23, 38, 38, 24, DateTimeKind.Local).AddTicks(8810));

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("35f3bf57-7f05-41a7-8ecb-9b48bcd52fa7"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 17, 23, 38, 38, 24, DateTimeKind.Local).AddTicks(8829));

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("3cfad89a-7c7b-497e-acd6-9bfc97d48a9b"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 17, 23, 38, 38, 24, DateTimeKind.Local).AddTicks(8832));

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("463044b4-343f-4101-b2a3-73012d059ac9"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 17, 23, 38, 38, 24, DateTimeKind.Local).AddTicks(8819));

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("4a6ef880-e352-49dc-0976-08dd0d886873"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 17, 23, 38, 38, 24, DateTimeKind.Local).AddTicks(8791));

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("75f6493f-813e-4d97-a0ea-e4203b90f436"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 17, 23, 38, 38, 24, DateTimeKind.Local).AddTicks(8839));

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("7dbb7444-f7a7-46d7-aa82-d35f70b2165d"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 17, 23, 38, 38, 24, DateTimeKind.Local).AddTicks(8836));

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("a2a57c78-7043-42e3-a156-ea5ad99fc083"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 17, 23, 38, 38, 24, DateTimeKind.Local).AddTicks(8844));

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("a654d03d-4e58-47fb-b70c-5e9433677052"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 17, 23, 38, 38, 24, DateTimeKind.Local).AddTicks(8814));

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("c758ad65-5f5d-43cf-b676-8dac2d2cf948"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 17, 23, 38, 38, 24, DateTimeKind.Local).AddTicks(8822));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("12f272c9-f198-45c4-a260-08dd37ab6f06"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 17, 23, 38, 38, 24, DateTimeKind.Local).AddTicks(9485));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("39a2b245-8188-4b47-b508-08dd37ab7f09"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 17, 23, 38, 38, 24, DateTimeKind.Local).AddTicks(9549));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("42d99c9a-7d35-4a45-a256-08dd37ab6f02"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 17, 23, 38, 38, 24, DateTimeKind.Local).AddTicks(9443));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("5f2b414d-63ec-4d3b-bfd3-08dd37aa0f43"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 17, 23, 38, 38, 24, DateTimeKind.Local).AddTicks(9401));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("6d9c7e02-56c7-4a77-b506-08dd37ab7f07"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 17, 23, 38, 38, 24, DateTimeKind.Local).AddTicks(9537));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("71b3bede-4e8e-4207-a7d4-08dd37aa0f45"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 17, 23, 38, 38, 24, DateTimeKind.Local).AddTicks(9417));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("7f6f6aab-c44f-4d30-a257-08dd37ab6f03"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 17, 23, 38, 38, 24, DateTimeKind.Local).AddTicks(9448));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("876a3131-1dc9-4a21-b509-08dd37ab7f10"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 17, 23, 38, 38, 24, DateTimeKind.Local).AddTicks(9555));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("89e4b1db-9b95-4fa8-a261-08dd37ab6f07"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 17, 23, 38, 38, 24, DateTimeKind.Local).AddTicks(9491));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("9d7f57a8-26d1-4b9f-a255-08dd37ab6f01"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 17, 23, 38, 38, 24, DateTimeKind.Local).AddTicks(9435));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("a12c08e7-8827-4912-b502-08dd37ab7f03"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 17, 23, 38, 38, 24, DateTimeKind.Local).AddTicks(9513));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("ab3e4a26-9e2f-46fa-b510-08dd37ab7f11"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 17, 23, 38, 38, 24, DateTimeKind.Local).AddTicks(9561));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("af8d7e39-0f8f-42b9-b1c3-08dd37aa0f44"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 17, 23, 38, 38, 24, DateTimeKind.Local).AddTicks(9411));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("b3e0b271-f8e0-4b3a-a7e5-08dd37aa0f46"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 17, 23, 38, 38, 24, DateTimeKind.Local).AddTicks(9423));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("b8c1131e-c817-44ea-a258-08dd37ab6f04"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 17, 23, 38, 38, 24, DateTimeKind.Local).AddTicks(9454));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("bf3ea476-bc8f-4572-b504-08dd37ab7f05"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 17, 23, 38, 38, 24, DateTimeKind.Local).AddTicks(9524));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("c1e3b450-628f-4a43-b7e3-08dd37aa0f47"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 17, 23, 38, 38, 24, DateTimeKind.Local).AddTicks(9428));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("c7f3d234-9fc3-453a-b500-08dd37ab7f01"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 17, 23, 38, 38, 24, DateTimeKind.Local).AddTicks(9501));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("d52d29fb-80da-40b0-a259-08dd37ab6f05"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 17, 23, 38, 38, 24, DateTimeKind.Local).AddTicks(9475));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("d75d8d12-fdf9-45c8-b503-08dd37ab7f04"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 17, 23, 38, 38, 24, DateTimeKind.Local).AddTicks(9518));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("ef123b19-3b99-4c24-b507-08dd37ab7f08"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 17, 23, 38, 38, 24, DateTimeKind.Local).AddTicks(9542));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("f3e321eb-94d8-4b8d-b505-08dd37ab7f06"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 17, 23, 38, 38, 24, DateTimeKind.Local).AddTicks(9531));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("f9ad1d79-7325-497e-b501-08dd37ab7f02"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 17, 23, 38, 38, 24, DateTimeKind.Local).AddTicks(9507));

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("0c7938f9-e881-42fa-242b-08dd2592d1dd"),
                columns: new[] { "CreatedDate", "CreatedUserID" },
                values: new object[] { new DateTime(2025, 1, 17, 23, 38, 38, 24, DateTimeKind.Local).AddTicks(9300), new Guid("f090514a-11bd-409c-899e-ad0570a96a0d") });

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("1f262031-5db7-47ae-893d-08dd0d86a8be"),
                columns: new[] { "CreatedDate", "CreatedUserID" },
                values: new object[] { new DateTime(2025, 1, 17, 23, 38, 38, 24, DateTimeKind.Local).AddTicks(9283), new Guid("9fbd6689-684d-42c6-918c-877eb16f77ff") });

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("2603e63f-9b46-4807-72be-08dd0d8f6f8f"),
                columns: new[] { "CreatedDate", "CreatedUserID" },
                values: new object[] { new DateTime(2025, 1, 17, 23, 38, 38, 24, DateTimeKind.Local).AddTicks(9291), new Guid("1b0a8077-ca24-4994-a4f8-5cfe8f790e1d") });

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("3a4086aa-1278-4325-242c-08dd2592d1dd"),
                columns: new[] { "CreatedDate", "CreatedUserID" },
                values: new object[] { new DateTime(2025, 1, 17, 23, 38, 38, 24, DateTimeKind.Local).AddTicks(9304), new Guid("d7d45db1-9e4a-4398-a45e-69a4194debae") });

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("486c341e-03d9-4616-242e-08dd2592d1dd"),
                columns: new[] { "CreatedDate", "CreatedUserID" },
                values: new object[] { new DateTime(2025, 1, 17, 23, 38, 38, 24, DateTimeKind.Local).AddTicks(9314), new Guid("3940def0-2d01-45af-a54e-448937e5166e") });

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("55a3337f-cfa5-4440-242a-08dd2592d1dd"),
                columns: new[] { "CreatedDate", "CreatedUserID" },
                values: new object[] { new DateTime(2025, 1, 17, 23, 38, 38, 24, DateTimeKind.Local).AddTicks(9296), new Guid("10080fb1-72a2-4ec2-93f3-25d32d9f0e6c") });

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("ecf68ade-4b48-4307-242d-08dd2592d1dd"),
                columns: new[] { "CreatedDate", "CreatedUserID" },
                values: new object[] { new DateTime(2025, 1, 17, 23, 38, 38, 24, DateTimeKind.Local).AddTicks(9310), new Guid("f51c68d2-a302-4d96-801b-dda5352596ca") });
        }
    }
}
