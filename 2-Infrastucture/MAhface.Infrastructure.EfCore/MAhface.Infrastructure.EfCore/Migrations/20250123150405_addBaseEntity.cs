using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MAhface.Infrastructure.EfCore.Migrations
{
    /// <inheritdoc />
    public partial class addBaseEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Code",
                schema: "Study",
                table: "StudentCourseRegistrations",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                schema: "Study",
                table: "StudentCourseRegistrations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedUserID",
                schema: "Study",
                table: "StudentCourseRegistrations",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                schema: "Study",
                table: "StudentCourseRegistrations",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DeletedUserID",
                schema: "Study",
                table: "StudentCourseRegistrations",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                schema: "Study",
                table: "StudentCourseRegistrations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "ISActive",
                schema: "Study",
                table: "StudentCourseRegistrations",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "Study",
                table: "StudentCourseRegistrations",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("13dc2597-a7a3-482e-b54a-23e83d2ab18b"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 23, 18, 34, 4, 235, DateTimeKind.Local).AddTicks(9969));

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("35f3bf57-7f05-41a7-8ecb-9b48bcd52fa7"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 23, 18, 34, 4, 235, DateTimeKind.Local).AddTicks(9986));

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("3cfad89a-7c7b-497e-acd6-9bfc97d48a9b"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 23, 18, 34, 4, 235, DateTimeKind.Local).AddTicks(9990));

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("463044b4-343f-4101-b2a3-73012d059ac9"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 23, 18, 34, 4, 235, DateTimeKind.Local).AddTicks(9978));

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("4a6ef880-e352-49dc-0976-08dd0d886873"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 23, 18, 34, 4, 235, DateTimeKind.Local).AddTicks(9949));

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("75f6493f-813e-4d97-a0ea-e4203b90f436"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 23, 18, 34, 4, 235, DateTimeKind.Local).AddTicks(9997));

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("7dbb7444-f7a7-46d7-aa82-d35f70b2165d"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 23, 18, 34, 4, 235, DateTimeKind.Local).AddTicks(9994));

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("a2a57c78-7043-42e3-a156-ea5ad99fc083"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 23, 18, 34, 4, 236, DateTimeKind.Local).AddTicks(1));

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("a654d03d-4e58-47fb-b70c-5e9433677052"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 23, 18, 34, 4, 235, DateTimeKind.Local).AddTicks(9974));

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("c758ad65-5f5d-43cf-b676-8dac2d2cf948"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 23, 18, 34, 4, 235, DateTimeKind.Local).AddTicks(9981));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("12f272c9-f198-45c4-a260-08dd37ab6f06"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 23, 18, 34, 4, 236, DateTimeKind.Local).AddTicks(667));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("39a2b245-8188-4b47-b508-08dd37ab7f09"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 23, 18, 34, 4, 236, DateTimeKind.Local).AddTicks(729));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("42d99c9a-7d35-4a45-a256-08dd37ab6f02"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 23, 18, 34, 4, 236, DateTimeKind.Local).AddTicks(593));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("5f2b414d-63ec-4d3b-bfd3-08dd37aa0f43"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 23, 18, 34, 4, 236, DateTimeKind.Local).AddTicks(557));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("6d9c7e02-56c7-4a77-b506-08dd37ab7f07"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 23, 18, 34, 4, 236, DateTimeKind.Local).AddTicks(717));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("71b3bede-4e8e-4207-a7d4-08dd37aa0f45"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 23, 18, 34, 4, 236, DateTimeKind.Local).AddTicks(570));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("7f6f6aab-c44f-4d30-a257-08dd37ab6f03"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 23, 18, 34, 4, 236, DateTimeKind.Local).AddTicks(600));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("876a3131-1dc9-4a21-b509-08dd37ab7f10"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 23, 18, 34, 4, 236, DateTimeKind.Local).AddTicks(735));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("89e4b1db-9b95-4fa8-a261-08dd37ab6f07"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 23, 18, 34, 4, 236, DateTimeKind.Local).AddTicks(673));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("9d7f57a8-26d1-4b9f-a255-08dd37ab6f01"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 23, 18, 34, 4, 236, DateTimeKind.Local).AddTicks(588));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("a12c08e7-8827-4912-b502-08dd37ab7f03"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 23, 18, 34, 4, 236, DateTimeKind.Local).AddTicks(691));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("ab3e4a26-9e2f-46fa-b510-08dd37ab7f11"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 23, 18, 34, 4, 236, DateTimeKind.Local).AddTicks(740));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("af8d7e39-0f8f-42b9-b1c3-08dd37aa0f44"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 23, 18, 34, 4, 236, DateTimeKind.Local).AddTicks(564));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("b3e0b271-f8e0-4b3a-a7e5-08dd37aa0f46"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 23, 18, 34, 4, 236, DateTimeKind.Local).AddTicks(576));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("b8c1131e-c817-44ea-a258-08dd37ab6f04"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 23, 18, 34, 4, 236, DateTimeKind.Local).AddTicks(605));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("bf3ea476-bc8f-4572-b504-08dd37ab7f05"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 23, 18, 34, 4, 236, DateTimeKind.Local).AddTicks(703));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("c1e3b450-628f-4a43-b7e3-08dd37aa0f47"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 23, 18, 34, 4, 236, DateTimeKind.Local).AddTicks(581));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("c7f3d234-9fc3-453a-b500-08dd37ab7f01"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 23, 18, 34, 4, 236, DateTimeKind.Local).AddTicks(680));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("d52d29fb-80da-40b0-a259-08dd37ab6f05"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 23, 18, 34, 4, 236, DateTimeKind.Local).AddTicks(660));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("d75d8d12-fdf9-45c8-b503-08dd37ab7f04"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 23, 18, 34, 4, 236, DateTimeKind.Local).AddTicks(697));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("ef123b19-3b99-4c24-b507-08dd37ab7f08"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 23, 18, 34, 4, 236, DateTimeKind.Local).AddTicks(722));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("f3e321eb-94d8-4b8d-b505-08dd37ab7f06"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 23, 18, 34, 4, 236, DateTimeKind.Local).AddTicks(711));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("f9ad1d79-7325-497e-b501-08dd37ab7f02"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 23, 18, 34, 4, 236, DateTimeKind.Local).AddTicks(685));

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("0c7938f9-e881-42fa-242b-08dd2592d1dd"),
                columns: new[] { "CreatedDate", "CreatedUserID" },
                values: new object[] { new DateTime(2025, 1, 23, 18, 34, 4, 236, DateTimeKind.Local).AddTicks(490), new Guid("04ced44a-f92c-4025-9ed7-68181251f7f4") });

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("1f262031-5db7-47ae-893d-08dd0d86a8be"),
                columns: new[] { "CreatedDate", "CreatedUserID" },
                values: new object[] { new DateTime(2025, 1, 23, 18, 34, 4, 236, DateTimeKind.Local).AddTicks(470), new Guid("18f2f82d-9012-4862-b3a6-30dd9bf61636") });

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("2603e63f-9b46-4807-72be-08dd0d8f6f8f"),
                columns: new[] { "CreatedDate", "CreatedUserID" },
                values: new object[] { new DateTime(2025, 1, 23, 18, 34, 4, 236, DateTimeKind.Local).AddTicks(477), new Guid("06b8f4a5-cebc-4344-90e1-5e18284f0084") });

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("3a4086aa-1278-4325-242c-08dd2592d1dd"),
                columns: new[] { "CreatedDate", "CreatedUserID" },
                values: new object[] { new DateTime(2025, 1, 23, 18, 34, 4, 236, DateTimeKind.Local).AddTicks(494), new Guid("596c8278-e9cf-4e4f-a165-9c47a02085e3") });

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("486c341e-03d9-4616-242e-08dd2592d1dd"),
                columns: new[] { "CreatedDate", "CreatedUserID" },
                values: new object[] { new DateTime(2025, 1, 23, 18, 34, 4, 236, DateTimeKind.Local).AddTicks(504), new Guid("137b4a09-29a7-4c3c-bffc-a3546b4fc62a") });

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("55a3337f-cfa5-4440-242a-08dd2592d1dd"),
                columns: new[] { "CreatedDate", "CreatedUserID" },
                values: new object[] { new DateTime(2025, 1, 23, 18, 34, 4, 236, DateTimeKind.Local).AddTicks(482), new Guid("952b30dd-a6cf-4450-9771-6061d5a443ee") });

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("ecf68ade-4b48-4307-242d-08dd2592d1dd"),
                columns: new[] { "CreatedDate", "CreatedUserID" },
                values: new object[] { new DateTime(2025, 1, 23, 18, 34, 4, 236, DateTimeKind.Local).AddTicks(499), new Guid("f0731b19-d64b-4ad7-8598-3dfcd52bc88f") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Code",
                schema: "Study",
                table: "StudentCourseRegistrations");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                schema: "Study",
                table: "StudentCourseRegistrations");

            migrationBuilder.DropColumn(
                name: "CreatedUserID",
                schema: "Study",
                table: "StudentCourseRegistrations");

            migrationBuilder.DropColumn(
                name: "DeletedDate",
                schema: "Study",
                table: "StudentCourseRegistrations");

            migrationBuilder.DropColumn(
                name: "DeletedUserID",
                schema: "Study",
                table: "StudentCourseRegistrations");

            migrationBuilder.DropColumn(
                name: "Description",
                schema: "Study",
                table: "StudentCourseRegistrations");

            migrationBuilder.DropColumn(
                name: "ISActive",
                schema: "Study",
                table: "StudentCourseRegistrations");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "Study",
                table: "StudentCourseRegistrations");

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("13dc2597-a7a3-482e-b54a-23e83d2ab18b"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 23, 18, 23, 51, 839, DateTimeKind.Local).AddTicks(7964));

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("35f3bf57-7f05-41a7-8ecb-9b48bcd52fa7"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 23, 18, 23, 51, 839, DateTimeKind.Local).AddTicks(7979));

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("3cfad89a-7c7b-497e-acd6-9bfc97d48a9b"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 23, 18, 23, 51, 839, DateTimeKind.Local).AddTicks(7982));

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("463044b4-343f-4101-b2a3-73012d059ac9"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 23, 18, 23, 51, 839, DateTimeKind.Local).AddTicks(7971));

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("4a6ef880-e352-49dc-0976-08dd0d886873"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 23, 18, 23, 51, 839, DateTimeKind.Local).AddTicks(7944));

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("75f6493f-813e-4d97-a0ea-e4203b90f436"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 23, 18, 23, 51, 839, DateTimeKind.Local).AddTicks(7988));

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("7dbb7444-f7a7-46d7-aa82-d35f70b2165d"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 23, 18, 23, 51, 839, DateTimeKind.Local).AddTicks(7985));

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("a2a57c78-7043-42e3-a156-ea5ad99fc083"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 23, 18, 23, 51, 839, DateTimeKind.Local).AddTicks(7992));

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("a654d03d-4e58-47fb-b70c-5e9433677052"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 23, 18, 23, 51, 839, DateTimeKind.Local).AddTicks(7967));

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("c758ad65-5f5d-43cf-b676-8dac2d2cf948"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 23, 18, 23, 51, 839, DateTimeKind.Local).AddTicks(7974));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("12f272c9-f198-45c4-a260-08dd37ab6f06"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 23, 18, 23, 51, 839, DateTimeKind.Local).AddTicks(8634));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("39a2b245-8188-4b47-b508-08dd37ab7f09"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 23, 18, 23, 51, 839, DateTimeKind.Local).AddTicks(8727));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("42d99c9a-7d35-4a45-a256-08dd37ab6f02"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 23, 18, 23, 51, 839, DateTimeKind.Local).AddTicks(8609));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("5f2b414d-63ec-4d3b-bfd3-08dd37aa0f43"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 23, 18, 23, 51, 839, DateTimeKind.Local).AddTicks(8572));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("6d9c7e02-56c7-4a77-b506-08dd37ab7f07"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 23, 18, 23, 51, 839, DateTimeKind.Local).AddTicks(8683));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("71b3bede-4e8e-4207-a7d4-08dd37aa0f45"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 23, 18, 23, 51, 839, DateTimeKind.Local).AddTicks(8586));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("7f6f6aab-c44f-4d30-a257-08dd37ab6f03"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 23, 18, 23, 51, 839, DateTimeKind.Local).AddTicks(8616));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("876a3131-1dc9-4a21-b509-08dd37ab7f10"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 23, 18, 23, 51, 839, DateTimeKind.Local).AddTicks(8734));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("89e4b1db-9b95-4fa8-a261-08dd37ab6f07"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 23, 18, 23, 51, 839, DateTimeKind.Local).AddTicks(8639));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("9d7f57a8-26d1-4b9f-a255-08dd37ab6f01"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 23, 18, 23, 51, 839, DateTimeKind.Local).AddTicks(8604));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("a12c08e7-8827-4912-b502-08dd37ab7f03"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 23, 18, 23, 51, 839, DateTimeKind.Local).AddTicks(8659));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("ab3e4a26-9e2f-46fa-b510-08dd37ab7f11"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 23, 18, 23, 51, 839, DateTimeKind.Local).AddTicks(8739));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("af8d7e39-0f8f-42b9-b1c3-08dd37aa0f44"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 23, 18, 23, 51, 839, DateTimeKind.Local).AddTicks(8580));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("b3e0b271-f8e0-4b3a-a7e5-08dd37aa0f46"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 23, 18, 23, 51, 839, DateTimeKind.Local).AddTicks(8591));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("b8c1131e-c817-44ea-a258-08dd37ab6f04"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 23, 18, 23, 51, 839, DateTimeKind.Local).AddTicks(8622));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("bf3ea476-bc8f-4572-b504-08dd37ab7f05"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 23, 18, 23, 51, 839, DateTimeKind.Local).AddTicks(8671));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("c1e3b450-628f-4a43-b7e3-08dd37aa0f47"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 23, 18, 23, 51, 839, DateTimeKind.Local).AddTicks(8597));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("c7f3d234-9fc3-453a-b500-08dd37ab7f01"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 23, 18, 23, 51, 839, DateTimeKind.Local).AddTicks(8648));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("d52d29fb-80da-40b0-a259-08dd37ab6f05"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 23, 18, 23, 51, 839, DateTimeKind.Local).AddTicks(8628));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("d75d8d12-fdf9-45c8-b503-08dd37ab7f04"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 23, 18, 23, 51, 839, DateTimeKind.Local).AddTicks(8666));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("ef123b19-3b99-4c24-b507-08dd37ab7f08"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 23, 18, 23, 51, 839, DateTimeKind.Local).AddTicks(8689));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("f3e321eb-94d8-4b8d-b505-08dd37ab7f06"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 23, 18, 23, 51, 839, DateTimeKind.Local).AddTicks(8677));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("f9ad1d79-7325-497e-b501-08dd37ab7f02"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 23, 18, 23, 51, 839, DateTimeKind.Local).AddTicks(8653));

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("0c7938f9-e881-42fa-242b-08dd2592d1dd"),
                columns: new[] { "CreatedDate", "CreatedUserID" },
                values: new object[] { new DateTime(2025, 1, 23, 18, 23, 51, 839, DateTimeKind.Local).AddTicks(8502), new Guid("535de415-4cf1-459d-a550-075cc3ae161e") });

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("1f262031-5db7-47ae-893d-08dd0d86a8be"),
                columns: new[] { "CreatedDate", "CreatedUserID" },
                values: new object[] { new DateTime(2025, 1, 23, 18, 23, 51, 839, DateTimeKind.Local).AddTicks(8487), new Guid("9cac872c-7b0e-4500-9b15-58514f69f07f") });

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("2603e63f-9b46-4807-72be-08dd0d8f6f8f"),
                columns: new[] { "CreatedDate", "CreatedUserID" },
                values: new object[] { new DateTime(2025, 1, 23, 18, 23, 51, 839, DateTimeKind.Local).AddTicks(8494), new Guid("7848a846-3e43-4539-9c0b-0e12480893c2") });

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("3a4086aa-1278-4325-242c-08dd2592d1dd"),
                columns: new[] { "CreatedDate", "CreatedUserID" },
                values: new object[] { new DateTime(2025, 1, 23, 18, 23, 51, 839, DateTimeKind.Local).AddTicks(8506), new Guid("3c5a7e8d-a03e-4b8d-90e9-ae415650981f") });

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("486c341e-03d9-4616-242e-08dd2592d1dd"),
                columns: new[] { "CreatedDate", "CreatedUserID" },
                values: new object[] { new DateTime(2025, 1, 23, 18, 23, 51, 839, DateTimeKind.Local).AddTicks(8519), new Guid("8edb3c14-77b1-4a5c-abe3-9ca427408aab") });

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("55a3337f-cfa5-4440-242a-08dd2592d1dd"),
                columns: new[] { "CreatedDate", "CreatedUserID" },
                values: new object[] { new DateTime(2025, 1, 23, 18, 23, 51, 839, DateTimeKind.Local).AddTicks(8498), new Guid("91cca867-0db7-494d-a239-70ccef1a2dd6") });

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("ecf68ade-4b48-4307-242d-08dd2592d1dd"),
                columns: new[] { "CreatedDate", "CreatedUserID" },
                values: new object[] { new DateTime(2025, 1, 23, 18, 23, 51, 839, DateTimeKind.Local).AddTicks(8515), new Guid("8c9b2464-8b03-4689-94e5-ccabf86ba609") });
        }
    }
}
