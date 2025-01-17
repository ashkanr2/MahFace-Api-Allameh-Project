using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MAhface.Infrastructure.EfCore.Migrations
{
    /// <inheritdoc />
    public partial class seedFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("05c5b88d-af8c-407e-d068-08dd15005342"),
                column: "ConcurrencyStamp",
                value: "76b0637b-8b16-4777-bed5-7efc0223e0a3");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("282a7f03-1dca-4d15-b706-08dd20626fc4"),
                column: "ConcurrencyStamp",
                value: "a8674cde-11fd-4cc7-8908-5276f28b3389");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("81e27342-10ef-4faf-74ca-08dd1ad120c3"),
                column: "ConcurrencyStamp",
                value: "0736d6b5-00cd-48e2-80f8-8babd9c9df38");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("85f9967b-1011-40c0-a32e-87370b013966"),
                column: "ConcurrencyStamp",
                value: "7c6fb654-f015-42a7-82c5-6e6fe5a80527");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9ceea18b-7117-4059-805c-08dd0d8a09bd"),
                column: "ConcurrencyStamp",
                value: "d7d37749-e003-489b-a2d7-5c9a2210900e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9f5dac63-d870-4424-7166-08dd2064841e"),
                column: "ConcurrencyStamp",
                value: "0dc1d380-dceb-4253-8e1e-86990db80523");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b373c277-e096-465f-a7e2-08dd33ff4451"),
                column: "ConcurrencyStamp",
                value: "a1ccd59b-eae5-4497-898a-1d97e2143a4f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("bd53a164-26df-45ab-bf5c-08dd0d797a44"),
                column: "ConcurrencyStamp",
                value: "6c345f7a-9586-438c-8752-6a0e6bed9675");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c13acae2-6d50-47cf-f711-08dd347f841d"),
                column: "ConcurrencyStamp",
                value: "5c9b4099-558c-400b-898f-b5415b16474e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d5c19e8c-d8da-421c-a82c-08dd12f8ba89"),
                column: "ConcurrencyStamp",
                value: "c9e822f2-e254-4a1f-9ede-2f7b15772d02");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e2caf058-47c5-4c10-3fc6-08dd1604c009"),
                column: "ConcurrencyStamp",
                value: "0d19e10b-4d3d-4cbb-84bb-a9429d9add08");

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("13dc2597-a7a3-482e-b54a-23e83d2ab18b"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 14, 14, 33, 36, 906, DateTimeKind.Local).AddTicks(507));

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("35f3bf57-7f05-41a7-8ecb-9b48bcd52fa7"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 14, 14, 33, 36, 906, DateTimeKind.Local).AddTicks(525));

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("3cfad89a-7c7b-497e-acd6-9bfc97d48a9b"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 14, 14, 33, 36, 906, DateTimeKind.Local).AddTicks(528));

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("463044b4-343f-4101-b2a3-73012d059ac9"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 14, 14, 33, 36, 906, DateTimeKind.Local).AddTicks(515));

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("4a6ef880-e352-49dc-0976-08dd0d886873"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 14, 14, 33, 36, 906, DateTimeKind.Local).AddTicks(490));

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("75f6493f-813e-4d97-a0ea-e4203b90f436"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 14, 14, 33, 36, 906, DateTimeKind.Local).AddTicks(533));

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("7dbb7444-f7a7-46d7-aa82-d35f70b2165d"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 14, 14, 33, 36, 906, DateTimeKind.Local).AddTicks(530));

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("a2a57c78-7043-42e3-a156-ea5ad99fc083"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 14, 14, 33, 36, 906, DateTimeKind.Local).AddTicks(537));

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("a654d03d-4e58-47fb-b70c-5e9433677052"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 14, 14, 33, 36, 906, DateTimeKind.Local).AddTicks(511));

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("c758ad65-5f5d-43cf-b676-8dac2d2cf948"),
                column: "CreatedDate",
                value: new DateTime(2025, 1, 14, 14, 33, 36, 906, DateTimeKind.Local).AddTicks(518));

            migrationBuilder.InsertData(
                schema: "BasicInfo",
                table: "Teacher",
                columns: new[] { "Id", "Code", "CreatedDate", "CreatedUserID", "DeletedDate", "DeletedUserID", "Description", "ISActive", "IsDeleted", "UserId" },
                values: new object[,]
                {
                    { new Guid("0c7938f9-e881-42fa-242b-08dd2592d1dd"), 4, new DateTime(2025, 1, 14, 14, 33, 36, 906, DateTimeKind.Local).AddTicks(940), new Guid("e55b13d5-0af7-4056-89d0-f7e2216dcf6a"), null, null, null, true, false, new Guid("05c5b88d-af8c-407e-d068-08dd15005342") },
                    { new Guid("1f262031-5db7-47ae-893d-08dd0d86a8be"), 1, new DateTime(2025, 1, 14, 14, 33, 36, 906, DateTimeKind.Local).AddTicks(921), new Guid("031d1542-f9c8-47e6-b57e-ee69919725bb"), null, null, null, true, false, new Guid("bd53a164-26df-45ab-bf5c-08dd0d797a44") },
                    { new Guid("2603e63f-9b46-4807-72be-08dd0d8f6f8f"), 2, new DateTime(2025, 1, 14, 14, 33, 36, 906, DateTimeKind.Local).AddTicks(928), new Guid("650f1d2c-b980-4033-b794-b60eafe7029f"), null, null, null, true, false, new Guid("9ceea18b-7117-4059-805c-08dd0d8a09bd") },
                    { new Guid("3a4086aa-1278-4325-242c-08dd2592d1dd"), 5, new DateTime(2025, 1, 14, 14, 33, 36, 906, DateTimeKind.Local).AddTicks(944), new Guid("88728a2e-a276-4a9f-b21c-22217eb0b56c"), null, null, null, true, false, new Guid("05c5b88d-af8c-407e-d068-08dd15005342") },
                    { new Guid("486c341e-03d9-4616-242e-08dd2592d1dd"), 7, new DateTime(2025, 1, 14, 14, 33, 36, 906, DateTimeKind.Local).AddTicks(953), new Guid("19e78b23-7042-46a7-8bbb-791554a17b0a"), null, null, null, true, false, new Guid("05c5b88d-af8c-407e-d068-08dd15005342") },
                    { new Guid("55a3337f-cfa5-4440-242a-08dd2592d1dd"), 3, new DateTime(2025, 1, 14, 14, 33, 36, 906, DateTimeKind.Local).AddTicks(936), new Guid("2653973f-3e72-4a44-83bf-6d1cce1cbafc"), null, null, null, true, false, new Guid("05c5b88d-af8c-407e-d068-08dd15005342") },
                    { new Guid("ecf68ade-4b48-4307-242d-08dd2592d1dd"), 6, new DateTime(2025, 1, 14, 14, 33, 36, 906, DateTimeKind.Local).AddTicks(949), new Guid("4cb117b2-faff-411c-a188-edbf7195946f"), null, null, null, true, false, new Guid("05c5b88d-af8c-407e-d068-08dd15005342") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "BasicInfo",
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("0c7938f9-e881-42fa-242b-08dd2592d1dd"));

            migrationBuilder.DeleteData(
                schema: "BasicInfo",
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("1f262031-5db7-47ae-893d-08dd0d86a8be"));

            migrationBuilder.DeleteData(
                schema: "BasicInfo",
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("2603e63f-9b46-4807-72be-08dd0d8f6f8f"));

            migrationBuilder.DeleteData(
                schema: "BasicInfo",
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("3a4086aa-1278-4325-242c-08dd2592d1dd"));

            migrationBuilder.DeleteData(
                schema: "BasicInfo",
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("486c341e-03d9-4616-242e-08dd2592d1dd"));

            migrationBuilder.DeleteData(
                schema: "BasicInfo",
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("55a3337f-cfa5-4440-242a-08dd2592d1dd"));

            migrationBuilder.DeleteData(
                schema: "BasicInfo",
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("ecf68ade-4b48-4307-242d-08dd2592d1dd"));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("05c5b88d-af8c-407e-d068-08dd15005342"),
                column: "ConcurrencyStamp",
                value: "d13c75ae-0918-4dbf-80c7-204c376b6f8a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("282a7f03-1dca-4d15-b706-08dd20626fc4"),
                column: "ConcurrencyStamp",
                value: "bc6ef5cc-bc96-4f7c-b860-adfe26329956");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("81e27342-10ef-4faf-74ca-08dd1ad120c3"),
                column: "ConcurrencyStamp",
                value: "a04988c7-6754-45d1-9167-13bdcbf48e5d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("85f9967b-1011-40c0-a32e-87370b013966"),
                column: "ConcurrencyStamp",
                value: "efedf69e-1e5b-4c3d-a082-f85931e1cf54");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9ceea18b-7117-4059-805c-08dd0d8a09bd"),
                column: "ConcurrencyStamp",
                value: "7cfe16d4-57c6-4776-9825-9b2d4ce2a268");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9f5dac63-d870-4424-7166-08dd2064841e"),
                column: "ConcurrencyStamp",
                value: "82c7102d-c3ec-4bde-a5e7-c6b10e778bb0");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b373c277-e096-465f-a7e2-08dd33ff4451"),
                column: "ConcurrencyStamp",
                value: "288403dd-5f74-43f0-9a77-9dfecbef406a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("bd53a164-26df-45ab-bf5c-08dd0d797a44"),
                column: "ConcurrencyStamp",
                value: "fca38817-e7b2-4008-b7b5-4997c17c5640");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c13acae2-6d50-47cf-f711-08dd347f841d"),
                column: "ConcurrencyStamp",
                value: "115bae18-ff53-4cd7-a36d-6b7fbaf9f3fb");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d5c19e8c-d8da-421c-a82c-08dd12f8ba89"),
                column: "ConcurrencyStamp",
                value: "a0980366-5d48-424b-acde-84b50c54d110");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e2caf058-47c5-4c10-3fc6-08dd1604c009"),
                column: "ConcurrencyStamp",
                value: "bfacce47-239f-49a9-9a61-683d747acfbd");

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("13dc2597-a7a3-482e-b54a-23e83d2ab18b"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 25, 22, 50, 46, 123, DateTimeKind.Unspecified).AddTicks(3333));

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("35f3bf57-7f05-41a7-8ecb-9b48bcd52fa7"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 25, 22, 50, 24, 423, DateTimeKind.Unspecified).AddTicks(3333));

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("3cfad89a-7c7b-497e-acd6-9bfc97d48a9b"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 25, 22, 49, 8, 46, DateTimeKind.Unspecified).AddTicks(6667));

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("463044b4-343f-4101-b2a3-73012d059ac9"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 25, 22, 51, 16, 403, DateTimeKind.Unspecified).AddTicks(3333));

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("4a6ef880-e352-49dc-0976-08dd0d886873"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 25, 23, 6, 7, 541, DateTimeKind.Unspecified).AddTicks(9737));

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("75f6493f-813e-4d97-a0ea-e4203b90f436"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 25, 22, 51, 6, 316, DateTimeKind.Unspecified).AddTicks(6667));

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("7dbb7444-f7a7-46d7-aa82-d35f70b2165d"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 25, 22, 50, 4, 16, DateTimeKind.Unspecified).AddTicks(6667));

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("a2a57c78-7043-42e3-a156-ea5ad99fc083"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 25, 22, 49, 40, 350, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("a654d03d-4e58-47fb-b70c-5e9433677052"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 25, 22, 49, 22, 566, DateTimeKind.Unspecified).AddTicks(6667));

            migrationBuilder.UpdateData(
                schema: "BasicInfo",
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("c758ad65-5f5d-43cf-b676-8dac2d2cf948"),
                column: "CreatedDate",
                value: new DateTime(2024, 11, 25, 22, 48, 45, 830, DateTimeKind.Unspecified));
        }
    }
}
