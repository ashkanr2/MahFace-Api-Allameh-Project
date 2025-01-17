using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MAhface.Infrastructure.EfCore.Migrations
{
    /// <inheritdoc />
    public partial class fakeView : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Number",
                schema: "Study",
                table: "Views",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("05c5b88d-af8c-407e-d068-08dd15005342"),
                column: "ConcurrencyStamp",
                value: "4d7e8a8d-0065-4ab5-b168-eddbfcf89416");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("282a7f03-1dca-4d15-b706-08dd20626fc4"),
                column: "ConcurrencyStamp",
                value: "0a26fa40-6e55-4662-83e3-a46206dd64f3");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("81e27342-10ef-4faf-74ca-08dd1ad120c3"),
                column: "ConcurrencyStamp",
                value: "7f9a4602-082f-44b2-a52e-291ef9613174");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("85f9967b-1011-40c0-a32e-87370b013966"),
                column: "ConcurrencyStamp",
                value: "09959c9d-dfb2-42f3-b16f-b022ffb8c98b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9ceea18b-7117-4059-805c-08dd0d8a09bd"),
                column: "ConcurrencyStamp",
                value: "7876e1d4-42f2-444f-be75-b8c12c712f1f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9f5dac63-d870-4424-7166-08dd2064841e"),
                column: "ConcurrencyStamp",
                value: "d5130526-24e7-4a87-8fad-28c98754cbb0");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b373c277-e096-465f-a7e2-08dd33ff4451"),
                column: "ConcurrencyStamp",
                value: "64aa571b-094c-492a-94c5-d26bfabe66e7");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("bd53a164-26df-45ab-bf5c-08dd0d797a44"),
                column: "ConcurrencyStamp",
                value: "e9b45d98-2fae-4137-9c4c-a7bd3c2d79be");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c13acae2-6d50-47cf-f711-08dd347f841d"),
                column: "ConcurrencyStamp",
                value: "c8821e8e-8d12-4d9d-86ed-394d5dc67bbc");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d5c19e8c-d8da-421c-a82c-08dd12f8ba89"),
                column: "ConcurrencyStamp",
                value: "5a77d87f-27e8-416e-888d-ec7f85eb3382");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e2caf058-47c5-4c10-3fc6-08dd1604c009"),
                column: "ConcurrencyStamp",
                value: "a7fa9018-844b-418a-97b9-7a508e7eb298");

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("13dc2597-a7a3-482e-b54a-23e83d2ab18b"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 17, 22, 38, 18, 17, DateTimeKind.Local).AddTicks(9134));

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("35f3bf57-7f05-41a7-8ecb-9b48bcd52fa7"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 17, 22, 38, 18, 17, DateTimeKind.Local).AddTicks(9149));

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("3cfad89a-7c7b-497e-acd6-9bfc97d48a9b"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 17, 22, 38, 18, 17, DateTimeKind.Local).AddTicks(9152));

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("463044b4-343f-4101-b2a3-73012d059ac9"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 17, 22, 38, 18, 17, DateTimeKind.Local).AddTicks(9141));

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("4a6ef880-e352-49dc-0976-08dd0d886873"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 17, 22, 38, 18, 17, DateTimeKind.Local).AddTicks(9118));

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("75f6493f-813e-4d97-a0ea-e4203b90f436"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 17, 22, 38, 18, 17, DateTimeKind.Local).AddTicks(9159));

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("7dbb7444-f7a7-46d7-aa82-d35f70b2165d"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 17, 22, 38, 18, 17, DateTimeKind.Local).AddTicks(9155));

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("a2a57c78-7043-42e3-a156-ea5ad99fc083"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 17, 22, 38, 18, 17, DateTimeKind.Local).AddTicks(9163));

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("a654d03d-4e58-47fb-b70c-5e9433677052"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 17, 22, 38, 18, 17, DateTimeKind.Local).AddTicks(9137));

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("c758ad65-5f5d-43cf-b676-8dac2d2cf948"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 17, 22, 38, 18, 17, DateTimeKind.Local).AddTicks(9144));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("12f272c9-f198-45c4-a260-08dd37ab6f06"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 17, 22, 38, 18, 17, DateTimeKind.Local).AddTicks(9708));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("39a2b245-8188-4b47-b508-08dd37ab7f09"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 17, 22, 38, 18, 17, DateTimeKind.Local).AddTicks(9803));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("42d99c9a-7d35-4a45-a256-08dd37ab6f02"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 17, 22, 38, 18, 17, DateTimeKind.Local).AddTicks(9685));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("5f2b414d-63ec-4d3b-bfd3-08dd37aa0f43"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 17, 22, 38, 18, 17, DateTimeKind.Local).AddTicks(9651));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("6d9c7e02-56c7-4a77-b506-08dd37ab7f07"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 17, 22, 38, 18, 17, DateTimeKind.Local).AddTicks(9786));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("71b3bede-4e8e-4207-a7d4-08dd37aa0f45"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 17, 22, 38, 18, 17, DateTimeKind.Local).AddTicks(9663));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("7f6f6aab-c44f-4d30-a257-08dd37ab6f03"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 17, 22, 38, 18, 17, DateTimeKind.Local).AddTicks(9690));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("876a3131-1dc9-4a21-b509-08dd37ab7f10"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 17, 22, 38, 18, 17, DateTimeKind.Local).AddTicks(9816));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("89e4b1db-9b95-4fa8-a261-08dd37ab6f07"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 17, 22, 38, 18, 17, DateTimeKind.Local).AddTicks(9714));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("9d7f57a8-26d1-4b9f-a255-08dd37ab6f01"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 17, 22, 38, 18, 17, DateTimeKind.Local).AddTicks(9680));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("a12c08e7-8827-4912-b502-08dd37ab7f03"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 17, 22, 38, 18, 17, DateTimeKind.Local).AddTicks(9757));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("ab3e4a26-9e2f-46fa-b510-08dd37ab7f11"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 17, 22, 38, 18, 17, DateTimeKind.Local).AddTicks(9821));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("af8d7e39-0f8f-42b9-b1c3-08dd37aa0f44"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 17, 22, 38, 18, 17, DateTimeKind.Local).AddTicks(9658));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("b3e0b271-f8e0-4b3a-a7e5-08dd37aa0f46"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 17, 22, 38, 18, 17, DateTimeKind.Local).AddTicks(9669));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("b8c1131e-c817-44ea-a258-08dd37ab6f04"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 17, 22, 38, 18, 17, DateTimeKind.Local).AddTicks(9696));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("bf3ea476-bc8f-4572-b504-08dd37ab7f05"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 17, 22, 38, 18, 17, DateTimeKind.Local).AddTicks(9768));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("c1e3b450-628f-4a43-b7e3-08dd37aa0f47"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 17, 22, 38, 18, 17, DateTimeKind.Local).AddTicks(9674));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("c7f3d234-9fc3-453a-b500-08dd37ab7f01"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 17, 22, 38, 18, 17, DateTimeKind.Local).AddTicks(9719));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("d52d29fb-80da-40b0-a259-08dd37ab6f05"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 17, 22, 38, 18, 17, DateTimeKind.Local).AddTicks(9703));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("d75d8d12-fdf9-45c8-b503-08dd37ab7f04"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 17, 22, 38, 18, 17, DateTimeKind.Local).AddTicks(9763));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("ef123b19-3b99-4c24-b507-08dd37ab7f08"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 17, 22, 38, 18, 17, DateTimeKind.Local).AddTicks(9793));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("f3e321eb-94d8-4b8d-b505-08dd37ab7f06"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 17, 22, 38, 18, 17, DateTimeKind.Local).AddTicks(9781));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("f9ad1d79-7325-497e-b501-08dd37ab7f02"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 17, 22, 38, 18, 17, DateTimeKind.Local).AddTicks(9751));

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("0c7938f9-e881-42fa-242b-08dd2592d1dd"),
                columns: new[] { "CreatedDate", "CreatedUserID" },
                values: new object[] { new DateTime(2025, 1, 17, 22, 38, 18, 17, DateTimeKind.Local).AddTicks(9592), new Guid("0eb4db21-b506-47d2-b5ca-4ad050f4b9d3") });

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("1f262031-5db7-47ae-893d-08dd0d86a8be"),
                columns: new[] { "CreatedDate", "CreatedUserID" },
                values: new object[] { new DateTime(2025, 1, 17, 22, 38, 18, 17, DateTimeKind.Local).AddTicks(9575), new Guid("ad4a3118-0538-42c1-a20f-01c85facc605") });

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("2603e63f-9b46-4807-72be-08dd0d8f6f8f"),
                columns: new[] { "CreatedDate", "CreatedUserID" },
                values: new object[] { new DateTime(2025, 1, 17, 22, 38, 18, 17, DateTimeKind.Local).AddTicks(9583), new Guid("14a5a1a0-302a-4fd4-8435-170ff4caeafc") });

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("3a4086aa-1278-4325-242c-08dd2592d1dd"),
                columns: new[] { "CreatedDate", "CreatedUserID" },
                values: new object[] { new DateTime(2025, 1, 17, 22, 38, 18, 17, DateTimeKind.Local).AddTicks(9595), new Guid("d8ee2dec-4b4d-4383-bf6f-dcd98b2193bf") });

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("486c341e-03d9-4616-242e-08dd2592d1dd"),
                columns: new[] { "CreatedDate", "CreatedUserID" },
                values: new object[] { new DateTime(2025, 1, 17, 22, 38, 18, 17, DateTimeKind.Local).AddTicks(9604), new Guid("301ee2f6-5b12-4c85-aaf3-a5a92321ad28") });

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("55a3337f-cfa5-4440-242a-08dd2592d1dd"),
                columns: new[] { "CreatedDate", "CreatedUserID" },
                values: new object[] { new DateTime(2025, 1, 17, 22, 38, 18, 17, DateTimeKind.Local).AddTicks(9588), new Guid("04a8ad86-814f-40a7-b734-a703f2bfb0c1") });

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("ecf68ade-4b48-4307-242d-08dd2592d1dd"),
                columns: new[] { "CreatedDate", "CreatedUserID" },
                values: new object[] { new DateTime(2025, 1, 17, 22, 38, 18, 17, DateTimeKind.Local).AddTicks(9600), new Guid("535ac033-f6a6-4a0f-8020-92423e21d0bd") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Number",
                schema: "Study",
                table: "Views");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("05c5b88d-af8c-407e-d068-08dd15005342"),
                column: "ConcurrencyStamp",
                value: "738cb7cd-5dea-41a2-a99f-28b42ba97a19");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("282a7f03-1dca-4d15-b706-08dd20626fc4"),
                column: "ConcurrencyStamp",
                value: "3459d17b-68d2-4e32-8746-890f51564bab");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("81e27342-10ef-4faf-74ca-08dd1ad120c3"),
                column: "ConcurrencyStamp",
                value: "136b5974-f0f4-4041-9c89-06f9a67c6b41");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("85f9967b-1011-40c0-a32e-87370b013966"),
                column: "ConcurrencyStamp",
                value: "d716e4bb-bfff-487c-95bc-7822abdc9721");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9ceea18b-7117-4059-805c-08dd0d8a09bd"),
                column: "ConcurrencyStamp",
                value: "99816dba-dba0-4601-add4-9ea3d02e5d10");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9f5dac63-d870-4424-7166-08dd2064841e"),
                column: "ConcurrencyStamp",
                value: "74bf6b3c-8f3e-4f9c-88f6-78baa1657e7c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b373c277-e096-465f-a7e2-08dd33ff4451"),
                column: "ConcurrencyStamp",
                value: "afdfc366-00e0-4628-ae90-2feb64b6fc1f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("bd53a164-26df-45ab-bf5c-08dd0d797a44"),
                column: "ConcurrencyStamp",
                value: "ac995c2e-edc6-4816-90e7-c5330e99881c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c13acae2-6d50-47cf-f711-08dd347f841d"),
                column: "ConcurrencyStamp",
                value: "492eea8d-c477-493e-8b54-131917756377");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d5c19e8c-d8da-421c-a82c-08dd12f8ba89"),
                column: "ConcurrencyStamp",
                value: "ff799f78-12c8-49f3-b9e2-390036c77aa9");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e2caf058-47c5-4c10-3fc6-08dd1604c009"),
                column: "ConcurrencyStamp",
                value: "76dcbc56-c595-4b5f-9e55-1dff559759a3");

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("13dc2597-a7a3-482e-b54a-23e83d2ab18b"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 17, 21, 57, 30, 779, DateTimeKind.Local).AddTicks(4928));

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("35f3bf57-7f05-41a7-8ecb-9b48bcd52fa7"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 17, 21, 57, 30, 779, DateTimeKind.Local).AddTicks(4945));

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("3cfad89a-7c7b-497e-acd6-9bfc97d48a9b"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 17, 21, 57, 30, 779, DateTimeKind.Local).AddTicks(4949));

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("463044b4-343f-4101-b2a3-73012d059ac9"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 17, 21, 57, 30, 779, DateTimeKind.Local).AddTicks(4935));

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("4a6ef880-e352-49dc-0976-08dd0d886873"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 17, 21, 57, 30, 779, DateTimeKind.Local).AddTicks(4909));

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("75f6493f-813e-4d97-a0ea-e4203b90f436"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 17, 21, 57, 30, 779, DateTimeKind.Local).AddTicks(4957));

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("7dbb7444-f7a7-46d7-aa82-d35f70b2165d"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 17, 21, 57, 30, 779, DateTimeKind.Local).AddTicks(4954));

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("a2a57c78-7043-42e3-a156-ea5ad99fc083"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 17, 21, 57, 30, 779, DateTimeKind.Local).AddTicks(4962));

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("a654d03d-4e58-47fb-b70c-5e9433677052"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 17, 21, 57, 30, 779, DateTimeKind.Local).AddTicks(4932));

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("c758ad65-5f5d-43cf-b676-8dac2d2cf948"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 17, 21, 57, 30, 779, DateTimeKind.Local).AddTicks(4939));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("12f272c9-f198-45c4-a260-08dd37ab6f06"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 17, 21, 57, 30, 779, DateTimeKind.Local).AddTicks(5615));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("39a2b245-8188-4b47-b508-08dd37ab7f09"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 17, 21, 57, 30, 779, DateTimeKind.Local).AddTicks(5722));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("42d99c9a-7d35-4a45-a256-08dd37ab6f02"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 17, 21, 57, 30, 779, DateTimeKind.Local).AddTicks(5591));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("5f2b414d-63ec-4d3b-bfd3-08dd37aa0f43"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 17, 21, 57, 30, 779, DateTimeKind.Local).AddTicks(5553));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("6d9c7e02-56c7-4a77-b506-08dd37ab7f07"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 17, 21, 57, 30, 779, DateTimeKind.Local).AddTicks(5710));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("71b3bede-4e8e-4207-a7d4-08dd37aa0f45"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 17, 21, 57, 30, 779, DateTimeKind.Local).AddTicks(5567));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("7f6f6aab-c44f-4d30-a257-08dd37ab6f03"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 17, 21, 57, 30, 779, DateTimeKind.Local).AddTicks(5597));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("876a3131-1dc9-4a21-b509-08dd37ab7f10"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 17, 21, 57, 30, 779, DateTimeKind.Local).AddTicks(5728));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("89e4b1db-9b95-4fa8-a261-08dd37ab6f07"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 17, 21, 57, 30, 779, DateTimeKind.Local).AddTicks(5661));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("9d7f57a8-26d1-4b9f-a255-08dd37ab6f01"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 17, 21, 57, 30, 779, DateTimeKind.Local).AddTicks(5586));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("a12c08e7-8827-4912-b502-08dd37ab7f03"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 17, 21, 57, 30, 779, DateTimeKind.Local).AddTicks(5684));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("ab3e4a26-9e2f-46fa-b510-08dd37ab7f11"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 17, 21, 57, 30, 779, DateTimeKind.Local).AddTicks(5734));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("af8d7e39-0f8f-42b9-b1c3-08dd37aa0f44"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 17, 21, 57, 30, 779, DateTimeKind.Local).AddTicks(5561));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("b3e0b271-f8e0-4b3a-a7e5-08dd37aa0f46"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 17, 21, 57, 30, 779, DateTimeKind.Local).AddTicks(5573));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("b8c1131e-c817-44ea-a258-08dd37ab6f04"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 17, 21, 57, 30, 779, DateTimeKind.Local).AddTicks(5603));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("bf3ea476-bc8f-4572-b504-08dd37ab7f05"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 17, 21, 57, 30, 779, DateTimeKind.Local).AddTicks(5697));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("c1e3b450-628f-4a43-b7e3-08dd37aa0f47"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 17, 21, 57, 30, 779, DateTimeKind.Local).AddTicks(5579));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("c7f3d234-9fc3-453a-b500-08dd37ab7f01"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 17, 21, 57, 30, 779, DateTimeKind.Local).AddTicks(5673));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("d52d29fb-80da-40b0-a259-08dd37ab6f05"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 17, 21, 57, 30, 779, DateTimeKind.Local).AddTicks(5609));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("d75d8d12-fdf9-45c8-b503-08dd37ab7f04"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 17, 21, 57, 30, 779, DateTimeKind.Local).AddTicks(5690));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("ef123b19-3b99-4c24-b507-08dd37ab7f08"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 17, 21, 57, 30, 779, DateTimeKind.Local).AddTicks(5716));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("f3e321eb-94d8-4b8d-b505-08dd37ab7f06"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 17, 21, 57, 30, 779, DateTimeKind.Local).AddTicks(5704));

            migrationBuilder.UpdateData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("f9ad1d79-7325-497e-b501-08dd37ab7f02"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 17, 21, 57, 30, 779, DateTimeKind.Local).AddTicks(5679));

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("0c7938f9-e881-42fa-242b-08dd2592d1dd"),
                columns: new[] { "CreatedDate", "CreatedUserID" },
                values: new object[] { new DateTime(2025, 1, 17, 21, 57, 30, 779, DateTimeKind.Local).AddTicks(5481), new Guid("9904db92-c8bf-460c-bc47-2b809ba78554") });

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("1f262031-5db7-47ae-893d-08dd0d86a8be"),
                columns: new[] { "CreatedDate", "CreatedUserID" },
                values: new object[] { new DateTime(2025, 1, 17, 21, 57, 30, 779, DateTimeKind.Local).AddTicks(5459), new Guid("76ff161d-b79c-40c6-8260-e1e25c3b7ea4") });

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("2603e63f-9b46-4807-72be-08dd0d8f6f8f"),
                columns: new[] { "CreatedDate", "CreatedUserID" },
                values: new object[] { new DateTime(2025, 1, 17, 21, 57, 30, 779, DateTimeKind.Local).AddTicks(5468), new Guid("891294b1-1877-4613-aacd-14b046afe14f") });

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("3a4086aa-1278-4325-242c-08dd2592d1dd"),
                columns: new[] { "CreatedDate", "CreatedUserID" },
                values: new object[] { new DateTime(2025, 1, 17, 21, 57, 30, 779, DateTimeKind.Local).AddTicks(5485), new Guid("c0865aa7-e2c7-463b-b32e-9a7895c56982") });

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("486c341e-03d9-4616-242e-08dd2592d1dd"),
                columns: new[] { "CreatedDate", "CreatedUserID" },
                values: new object[] { new DateTime(2025, 1, 17, 21, 57, 30, 779, DateTimeKind.Local).AddTicks(5494), new Guid("2385e5c7-423f-481a-a7f4-7dfe08127e9e") });

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("55a3337f-cfa5-4440-242a-08dd2592d1dd"),
                columns: new[] { "CreatedDate", "CreatedUserID" },
                values: new object[] { new DateTime(2025, 1, 17, 21, 57, 30, 779, DateTimeKind.Local).AddTicks(5476), new Guid("cfaf4145-926a-4366-ad51-0884efa152e2") });

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("ecf68ade-4b48-4307-242d-08dd2592d1dd"),
                columns: new[] { "CreatedDate", "CreatedUserID" },
                values: new object[] { new DateTime(2025, 1, 17, 21, 57, 30, 779, DateTimeKind.Local).AddTicks(5490), new Guid("707c40ed-2330-4516-a7c0-a7021223c38c") });
        }
    }
}
