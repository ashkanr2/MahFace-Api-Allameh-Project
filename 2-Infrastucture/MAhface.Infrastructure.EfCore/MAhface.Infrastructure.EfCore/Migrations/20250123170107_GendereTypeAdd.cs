using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MAhface.Infrastructure.EfCore.Migrations
{
    /// <inheritdoc />
    public partial class GendereTypeAdd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GenderType",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("05c5b88d-af8c-407e-d068-08dd15005342"),
                column: "GenderType",
                value: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("282a7f03-1dca-4d15-b706-08dd20626fc4"),
                column: "GenderType",
                value: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("81e27342-10ef-4faf-74ca-08dd1ad120c3"),
                column: "GenderType",
                value: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("85f9967b-1011-40c0-a32e-87370b013966"),
                column: "GenderType",
                value: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9ceea18b-7117-4059-805c-08dd0d8a09bd"),
                column: "GenderType",
                value: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9f5dac63-d870-4424-7166-08dd2064841e"),
                column: "GenderType",
                value: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b373c277-e096-465f-a7e2-08dd33ff4451"),
                column: "GenderType",
                value: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("bd53a164-26df-45ab-bf5c-08dd0d797a44"),
                column: "GenderType",
                value: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c13acae2-6d50-47cf-f711-08dd347f841d"),
                column: "GenderType",
                value: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d5c19e8c-d8da-421c-a82c-08dd12f8ba89"),
                column: "GenderType",
                value: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e2caf058-47c5-4c10-3fc6-08dd1604c009"),
                column: "GenderType",
                value: 0);

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("13dc2597-a7a3-482e-b54a-23e83d2ab18b"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 23, 20, 31, 4, 596, DateTimeKind.Local).AddTicks(1609));

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("35f3bf57-7f05-41a7-8ecb-9b48bcd52fa7"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 23, 20, 31, 4, 596, DateTimeKind.Local).AddTicks(1628));

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("3cfad89a-7c7b-497e-acd6-9bfc97d48a9b"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 23, 20, 31, 4, 596, DateTimeKind.Local).AddTicks(1632));

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("463044b4-343f-4101-b2a3-73012d059ac9"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 23, 20, 31, 4, 596, DateTimeKind.Local).AddTicks(1620));

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("4a6ef880-e352-49dc-0976-08dd0d886873"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 23, 20, 31, 4, 596, DateTimeKind.Local).AddTicks(1592));

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("75f6493f-813e-4d97-a0ea-e4203b90f436"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 23, 20, 31, 4, 596, DateTimeKind.Local).AddTicks(1672));

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("7dbb7444-f7a7-46d7-aa82-d35f70b2165d"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 23, 20, 31, 4, 596, DateTimeKind.Local).AddTicks(1636));

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("a2a57c78-7043-42e3-a156-ea5ad99fc083"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 23, 20, 31, 4, 596, DateTimeKind.Local).AddTicks(1676));

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("a654d03d-4e58-47fb-b70c-5e9433677052"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 23, 20, 31, 4, 596, DateTimeKind.Local).AddTicks(1613));

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("c758ad65-5f5d-43cf-b676-8dac2d2cf948"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 23, 20, 31, 4, 596, DateTimeKind.Local).AddTicks(1624));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("12f272c9-f198-45c4-a260-08dd37ab6f06"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 23, 20, 31, 4, 596, DateTimeKind.Local).AddTicks(2320));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("39a2b245-8188-4b47-b508-08dd37ab7f09"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 23, 20, 31, 4, 596, DateTimeKind.Local).AddTicks(2374));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("42d99c9a-7d35-4a45-a256-08dd37ab6f02"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 23, 20, 31, 4, 596, DateTimeKind.Local).AddTicks(2298));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("5f2b414d-63ec-4d3b-bfd3-08dd37aa0f43"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 23, 20, 31, 4, 596, DateTimeKind.Local).AddTicks(2212));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("6d9c7e02-56c7-4a77-b506-08dd37ab7f07"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 23, 20, 31, 4, 596, DateTimeKind.Local).AddTicks(2363));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("71b3bede-4e8e-4207-a7d4-08dd37aa0f45"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 23, 20, 31, 4, 596, DateTimeKind.Local).AddTicks(2232));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("7f6f6aab-c44f-4d30-a257-08dd37ab6f03"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 23, 20, 31, 4, 596, DateTimeKind.Local).AddTicks(2304));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("876a3131-1dc9-4a21-b509-08dd37ab7f10"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 23, 20, 31, 4, 596, DateTimeKind.Local).AddTicks(2381));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("89e4b1db-9b95-4fa8-a261-08dd37ab6f07"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 23, 20, 31, 4, 596, DateTimeKind.Local).AddTicks(2325));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("9d7f57a8-26d1-4b9f-a255-08dd37ab6f01"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 23, 20, 31, 4, 596, DateTimeKind.Local).AddTicks(2293));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("a12c08e7-8827-4912-b502-08dd37ab7f03"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 23, 20, 31, 4, 596, DateTimeKind.Local).AddTicks(2340));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("ab3e4a26-9e2f-46fa-b510-08dd37ab7f11"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 23, 20, 31, 4, 596, DateTimeKind.Local).AddTicks(2387));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("af8d7e39-0f8f-42b9-b1c3-08dd37aa0f44"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 23, 20, 31, 4, 596, DateTimeKind.Local).AddTicks(2226));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("b3e0b271-f8e0-4b3a-a7e5-08dd37aa0f46"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 23, 20, 31, 4, 596, DateTimeKind.Local).AddTicks(2247));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("b8c1131e-c817-44ea-a258-08dd37ab6f04"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 23, 20, 31, 4, 596, DateTimeKind.Local).AddTicks(2309));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("bf3ea476-bc8f-4572-b504-08dd37ab7f05"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 23, 20, 31, 4, 596, DateTimeKind.Local).AddTicks(2351));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("c1e3b450-628f-4a43-b7e3-08dd37aa0f47"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 23, 20, 31, 4, 596, DateTimeKind.Local).AddTicks(2284));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("c7f3d234-9fc3-453a-b500-08dd37ab7f01"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 23, 20, 31, 4, 596, DateTimeKind.Local).AddTicks(2330));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("d52d29fb-80da-40b0-a259-08dd37ab6f05"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 23, 20, 31, 4, 596, DateTimeKind.Local).AddTicks(2315));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("d75d8d12-fdf9-45c8-b503-08dd37ab7f04"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 23, 20, 31, 4, 596, DateTimeKind.Local).AddTicks(2345));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("ef123b19-3b99-4c24-b507-08dd37ab7f08"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 23, 20, 31, 4, 596, DateTimeKind.Local).AddTicks(2369));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("f3e321eb-94d8-4b8d-b505-08dd37ab7f06"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 23, 20, 31, 4, 596, DateTimeKind.Local).AddTicks(2357));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("f9ad1d79-7325-497e-b501-08dd37ab7f02"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 23, 20, 31, 4, 596, DateTimeKind.Local).AddTicks(2335));

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("0c7938f9-e881-42fa-242b-08dd2592d1dd"),
                columns: new[] { "CreatedDate", "CreatedUserID" },
                values: new object[] { new DateTime(2025, 1, 23, 20, 31, 4, 596, DateTimeKind.Local).AddTicks(2119), new Guid("ea7232d4-f0d9-471a-872d-705e95b99363") });

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("1f262031-5db7-47ae-893d-08dd0d86a8be"),
                columns: new[] { "CreatedDate", "CreatedUserID" },
                values: new object[] { new DateTime(2025, 1, 23, 20, 31, 4, 596, DateTimeKind.Local).AddTicks(2104), new Guid("1d9f557d-795d-4169-b017-8b0cb502ce43") });

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("2603e63f-9b46-4807-72be-08dd0d8f6f8f"),
                columns: new[] { "CreatedDate", "CreatedUserID" },
                values: new object[] { new DateTime(2025, 1, 23, 20, 31, 4, 596, DateTimeKind.Local).AddTicks(2112), new Guid("54544540-0545-4859-a92a-b7e19d6d22d7") });

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("3a4086aa-1278-4325-242c-08dd2592d1dd"),
                columns: new[] { "CreatedDate", "CreatedUserID" },
                values: new object[] { new DateTime(2025, 1, 23, 20, 31, 4, 596, DateTimeKind.Local).AddTicks(2124), new Guid("d8a04f07-8c01-44c0-a134-2bf05f161a67") });

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("486c341e-03d9-4616-242e-08dd2592d1dd"),
                columns: new[] { "CreatedDate", "CreatedUserID" },
                values: new object[] { new DateTime(2025, 1, 23, 20, 31, 4, 596, DateTimeKind.Local).AddTicks(2137), new Guid("543d1372-3eba-4782-84c1-6f207f19e1fb") });

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("55a3337f-cfa5-4440-242a-08dd2592d1dd"),
                columns: new[] { "CreatedDate", "CreatedUserID" },
                values: new object[] { new DateTime(2025, 1, 23, 20, 31, 4, 596, DateTimeKind.Local).AddTicks(2116), new Guid("e9a73e3d-3651-4a12-9509-c80768bc3b7e") });

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("ecf68ade-4b48-4307-242d-08dd2592d1dd"),
                columns: new[] { "CreatedDate", "CreatedUserID" },
                values: new object[] { new DateTime(2025, 1, 23, 20, 31, 4, 596, DateTimeKind.Local).AddTicks(2129), new Guid("78751979-6fe2-40c1-9fc7-df4dd45ee6c5") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GenderType",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("13dc2597-a7a3-482e-b54a-23e83d2ab18b"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 23, 18, 43, 27, 64, DateTimeKind.Local).AddTicks(6053));

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("35f3bf57-7f05-41a7-8ecb-9b48bcd52fa7"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 23, 18, 43, 27, 64, DateTimeKind.Local).AddTicks(6070));

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("3cfad89a-7c7b-497e-acd6-9bfc97d48a9b"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 23, 18, 43, 27, 64, DateTimeKind.Local).AddTicks(6073));

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("463044b4-343f-4101-b2a3-73012d059ac9"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 23, 18, 43, 27, 64, DateTimeKind.Local).AddTicks(6062));

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("4a6ef880-e352-49dc-0976-08dd0d886873"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 23, 18, 43, 27, 64, DateTimeKind.Local).AddTicks(5962));

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("75f6493f-813e-4d97-a0ea-e4203b90f436"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 23, 18, 43, 27, 64, DateTimeKind.Local).AddTicks(6091));

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("7dbb7444-f7a7-46d7-aa82-d35f70b2165d"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 23, 18, 43, 27, 64, DateTimeKind.Local).AddTicks(6083));

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("a2a57c78-7043-42e3-a156-ea5ad99fc083"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 23, 18, 43, 27, 64, DateTimeKind.Local).AddTicks(6096));

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("a654d03d-4e58-47fb-b70c-5e9433677052"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 23, 18, 43, 27, 64, DateTimeKind.Local).AddTicks(6058));

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("c758ad65-5f5d-43cf-b676-8dac2d2cf948"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 23, 18, 43, 27, 64, DateTimeKind.Local).AddTicks(6065));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("12f272c9-f198-45c4-a260-08dd37ab6f06"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 23, 18, 43, 27, 64, DateTimeKind.Local).AddTicks(6776));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("39a2b245-8188-4b47-b508-08dd37ab7f09"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 23, 18, 43, 27, 64, DateTimeKind.Local).AddTicks(6833));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("42d99c9a-7d35-4a45-a256-08dd37ab6f02"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 23, 18, 43, 27, 64, DateTimeKind.Local).AddTicks(6753));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("5f2b414d-63ec-4d3b-bfd3-08dd37aa0f43"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 23, 18, 43, 27, 64, DateTimeKind.Local).AddTicks(6712));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("6d9c7e02-56c7-4a77-b506-08dd37ab7f07"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 23, 18, 43, 27, 64, DateTimeKind.Local).AddTicks(6821));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("71b3bede-4e8e-4207-a7d4-08dd37aa0f45"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 23, 18, 43, 27, 64, DateTimeKind.Local).AddTicks(6726));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("7f6f6aab-c44f-4d30-a257-08dd37ab6f03"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 23, 18, 43, 27, 64, DateTimeKind.Local).AddTicks(6758));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("876a3131-1dc9-4a21-b509-08dd37ab7f10"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 23, 18, 43, 27, 64, DateTimeKind.Local).AddTicks(6839));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("89e4b1db-9b95-4fa8-a261-08dd37ab6f07"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 23, 18, 43, 27, 64, DateTimeKind.Local).AddTicks(6781));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("9d7f57a8-26d1-4b9f-a255-08dd37ab6f01"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 23, 18, 43, 27, 64, DateTimeKind.Local).AddTicks(6746));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("a12c08e7-8827-4912-b502-08dd37ab7f03"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 23, 18, 43, 27, 64, DateTimeKind.Local).AddTicks(6798));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("ab3e4a26-9e2f-46fa-b510-08dd37ab7f11"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 23, 18, 43, 27, 64, DateTimeKind.Local).AddTicks(6844));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("af8d7e39-0f8f-42b9-b1c3-08dd37aa0f44"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 23, 18, 43, 27, 64, DateTimeKind.Local).AddTicks(6721));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("b3e0b271-f8e0-4b3a-a7e5-08dd37aa0f46"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 23, 18, 43, 27, 64, DateTimeKind.Local).AddTicks(6733));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("b8c1131e-c817-44ea-a258-08dd37ab6f04"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 23, 18, 43, 27, 64, DateTimeKind.Local).AddTicks(6763));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("bf3ea476-bc8f-4572-b504-08dd37ab7f05"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 23, 18, 43, 27, 64, DateTimeKind.Local).AddTicks(6809));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("c1e3b450-628f-4a43-b7e3-08dd37aa0f47"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 23, 18, 43, 27, 64, DateTimeKind.Local).AddTicks(6739));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("c7f3d234-9fc3-453a-b500-08dd37ab7f01"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 23, 18, 43, 27, 64, DateTimeKind.Local).AddTicks(6787));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("d52d29fb-80da-40b0-a259-08dd37ab6f05"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 23, 18, 43, 27, 64, DateTimeKind.Local).AddTicks(6770));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("d75d8d12-fdf9-45c8-b503-08dd37ab7f04"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 23, 18, 43, 27, 64, DateTimeKind.Local).AddTicks(6804));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("ef123b19-3b99-4c24-b507-08dd37ab7f08"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 23, 18, 43, 27, 64, DateTimeKind.Local).AddTicks(6828));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("f3e321eb-94d8-4b8d-b505-08dd37ab7f06"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 23, 18, 43, 27, 64, DateTimeKind.Local).AddTicks(6816));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("f9ad1d79-7325-497e-b501-08dd37ab7f02"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 23, 18, 43, 27, 64, DateTimeKind.Local).AddTicks(6793));

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("0c7938f9-e881-42fa-242b-08dd2592d1dd"),
                columns: new[] { "CreatedDate", "CreatedUserID" },
                values: new object[] { new DateTime(2025, 1, 23, 18, 43, 27, 64, DateTimeKind.Local).AddTicks(6576), new Guid("42d8b18d-cecc-49db-9b6d-fd64cc5ba465") });

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("1f262031-5db7-47ae-893d-08dd0d86a8be"),
                columns: new[] { "CreatedDate", "CreatedUserID" },
                values: new object[] { new DateTime(2025, 1, 23, 18, 43, 27, 64, DateTimeKind.Local).AddTicks(6561), new Guid("98438e02-92bd-444c-8fff-dde61665ae96") });

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("2603e63f-9b46-4807-72be-08dd0d8f6f8f"),
                columns: new[] { "CreatedDate", "CreatedUserID" },
                values: new object[] { new DateTime(2025, 1, 23, 18, 43, 27, 64, DateTimeKind.Local).AddTicks(6568), new Guid("82f80bf3-1c2a-4491-b980-9e49e433d57a") });

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("3a4086aa-1278-4325-242c-08dd2592d1dd"),
                columns: new[] { "CreatedDate", "CreatedUserID" },
                values: new object[] { new DateTime(2025, 1, 23, 18, 43, 27, 64, DateTimeKind.Local).AddTicks(6585), new Guid("8ebd124e-8cf2-43f9-9db2-62d25e5a31f0") });

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("486c341e-03d9-4616-242e-08dd2592d1dd"),
                columns: new[] { "CreatedDate", "CreatedUserID" },
                values: new object[] { new DateTime(2025, 1, 23, 18, 43, 27, 64, DateTimeKind.Local).AddTicks(6594), new Guid("a0fa8e5e-9ea2-4f14-b056-b22c452d44e3") });

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("55a3337f-cfa5-4440-242a-08dd2592d1dd"),
                columns: new[] { "CreatedDate", "CreatedUserID" },
                values: new object[] { new DateTime(2025, 1, 23, 18, 43, 27, 64, DateTimeKind.Local).AddTicks(6572), new Guid("79364c79-0621-4497-b81d-71427069055a") });

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("ecf68ade-4b48-4307-242d-08dd2592d1dd"),
                columns: new[] { "CreatedDate", "CreatedUserID" },
                values: new object[] { new DateTime(2025, 1, 23, 18, 43, 27, 64, DateTimeKind.Local).AddTicks(6590), new Guid("674f044e-8b5b-4d2f-ad5a-1bd9de2d40cd") });
        }
    }
}
