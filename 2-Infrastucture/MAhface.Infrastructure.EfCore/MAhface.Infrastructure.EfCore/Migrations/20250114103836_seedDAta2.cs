using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MAhface.Infrastructure.EfCore.Migrations
{
    /// <inheritdoc />
    public partial class seedDAta2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "BirthDate", "ConcurrencyStamp", "Email", "EmailConfirmed", "Firstname", "ImageId", "IsActived", "IsDeleted", "IsSystemAccount", "IsSystemAdmin", "IsTeacher", "LastName", "LockoutEnabled", "LockoutEnd", "NationalCode", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileImageId", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("05c5b88d-af8c-407e-d068-08dd15005342"), 0, new DateTime(2024, 12, 5, 7, 42, 7, 242, DateTimeKind.Unspecified), "d13c75ae-0918-4dbf-80c7-204c376b6f8a", "string", false, "string", null, false, false, false, false, true, "string", false, null, "string", null, null, null, "string", false, null, null, false, null });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "BirthDate", "ConcurrencyStamp", "Email", "EmailConfirmed", "Firstname", "ImageId", "IsActived", "IsDeleted", "IsStudent", "IsSystemAccount", "IsSystemAdmin", "IsTeacher", "LastName", "LockoutEnabled", "LockoutEnd", "NationalCode", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileImageId", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("282a7f03-1dca-4d15-b706-08dd20626fc4"), 0, new DateTime(2024, 12, 19, 19, 21, 28, 118, DateTimeKind.Unspecified), "bc6ef5cc-bc96-4f7c-b860-adfe26329956", "razaviash21@gmail.com", false, "test email", null, false, false, true, false, false, false, "ashkan", false, null, "1215", null, null, null, "0915215", false, null, null, false, null });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "BirthDate", "ConcurrencyStamp", "Email", "EmailConfirmed", "Firstname", "ImageId", "IsActived", "IsDeleted", "IsSystemAccount", "IsSystemAdmin", "IsTeacher", "LastName", "LockoutEnabled", "LockoutEnd", "NationalCode", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileImageId", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("81e27342-10ef-4faf-74ca-08dd1ad120c3"), 0, new DateTime(2004, 12, 12, 17, 22, 1, 253, DateTimeKind.Unspecified), "a04988c7-6754-45d1-9167-13bdcbf48e5d", "u@gmail.com", false, "sobhan", null, false, false, false, false, true, "saffari", false, null, "0005654789", null, null, null, "09121940087", false, null, null, false, null },
                    { new Guid("85f9967b-1011-40c0-a32e-87370b013966"), 0, new DateTime(2002, 11, 25, 17, 47, 55, 494, DateTimeKind.Unspecified), "efedf69e-1e5b-4c3d-a082-f85931e1cf54", "AshkanTeacher@gmail.com", false, "Admin", null, false, false, true, true, false, "Admini", false, null, "1234567890", null, null, null, "09123655654", false, null, null, false, null },
                    { new Guid("9ceea18b-7117-4059-805c-08dd0d8a09bd"), 0, new DateTime(2024, 11, 25, 19, 32, 45, 25, DateTimeKind.Unspecified), "7cfe16d4-57c6-4776-9825-9b2d4ce2a268", "jadi@gmail.com", false, "جادی", null, false, false, false, false, true, "میر میرانی", false, null, "1234567891", null, null, null, "09121236547", false, null, null, false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "BirthDate", "ConcurrencyStamp", "Email", "EmailConfirmed", "Firstname", "ImageId", "IsActived", "IsDeleted", "IsStudent", "IsSystemAccount", "IsSystemAdmin", "IsTeacher", "LastName", "LockoutEnabled", "LockoutEnd", "NationalCode", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileImageId", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("9f5dac63-d870-4424-7166-08dd2064841e"), 0, new DateTime(2024, 12, 19, 19, 36, 36, 471, DateTimeKind.Unspecified), "82c7102d-c3ec-4bde-a5e7-c6b10e778bb0", "string@", false, "5651", null, false, false, true, false, false, false, "hfyhb55", false, null, "366551", null, null, null, "21521", false, null, null, false, null },
                    { new Guid("b373c277-e096-465f-a7e2-08dd33ff4451"), 0, new DateTime(2000, 1, 18, 18, 21, 33, 105, DateTimeKind.Unspecified), "288403dd-5f74-43f0-9a77-9dfecbef406a", "abolfazlVafaDost@gmail.com", false, "ابوالفضل", null, false, false, true, false, false, false, " وفادوست", false, null, "1234567891", null, null, null, "09121234123", false, null, null, false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "BirthDate", "ConcurrencyStamp", "Email", "EmailConfirmed", "Firstname", "ImageId", "IsActived", "IsDeleted", "IsSystemAccount", "IsSystemAdmin", "IsTeacher", "LastName", "LockoutEnabled", "LockoutEnd", "NationalCode", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileImageId", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("bd53a164-26df-45ab-bf5c-08dd0d797a44"), 0, new DateTime(2002, 11, 25, 17, 47, 55, 494, DateTimeKind.Unspecified), "fca38817-e7b2-4008-b7b5-4997c17c5640", "AshkanTeacher@gmail.com", false, "Ashkan", null, false, false, false, false, true, "Teacher", false, null, "1234567890", null, null, null, "09123655654", false, null, null, false, null });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "BirthDate", "ConcurrencyStamp", "Email", "EmailConfirmed", "Firstname", "ImageId", "IsActived", "IsDeleted", "IsStudent", "IsSystemAccount", "IsSystemAdmin", "IsTeacher", "LastName", "LockoutEnabled", "LockoutEnd", "NationalCode", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileImageId", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("c13acae2-6d50-47cf-f711-08dd347f841d"), 0, new DateTime(2025, 1, 14, 9, 39, 55, 273, DateTimeKind.Unspecified), "115bae18-ff53-4cd7-a36d-6b7fbaf9f3fb", "s", false, "s", null, false, false, true, false, false, false, "2", false, null, "b", null, null, null, "f", false, null, null, false, null });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "BirthDate", "ConcurrencyStamp", "Email", "EmailConfirmed", "Firstname", "ImageId", "IsActived", "IsDeleted", "IsSystemAccount", "IsSystemAdmin", "IsTeacher", "LastName", "LockoutEnabled", "LockoutEnd", "NationalCode", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileImageId", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("d5c19e8c-d8da-421c-a82c-08dd12f8ba89"), 0, new DateTime(2002, 11, 2, 17, 41, 12, 121, DateTimeKind.Unspecified), "a0980366-5d48-424b-acde-84b50c54d110", "vahidJF@gmail.com", false, "وحید", null, false, false, false, false, true, "2جعفری", false, null, "", null, null, null, "09129129120", false, null, null, false, null });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "BirthDate", "ConcurrencyStamp", "Email", "EmailConfirmed", "Firstname", "ImageId", "IsActived", "IsDeleted", "IsStudent", "IsSystemAccount", "IsSystemAdmin", "IsTeacher", "LastName", "LockoutEnabled", "LockoutEnd", "NationalCode", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileImageId", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("e2caf058-47c5-4c10-3fc6-08dd1604c009"), 0, new DateTime(2024, 12, 6, 14, 45, 29, 103, DateTimeKind.Unspecified), "bfacce47-239f-49a9-9a61-683d747acfbd", "sobhandanger81@gmail.com", false, "sopo", null, false, false, true, false, false, false, "saffari", false, null, "002510174", null, null, null, "09917358742", false, null, null, false, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("05c5b88d-af8c-407e-d068-08dd15005342"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("282a7f03-1dca-4d15-b706-08dd20626fc4"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("81e27342-10ef-4faf-74ca-08dd1ad120c3"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("85f9967b-1011-40c0-a32e-87370b013966"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9ceea18b-7117-4059-805c-08dd0d8a09bd"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9f5dac63-d870-4424-7166-08dd2064841e"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b373c277-e096-465f-a7e2-08dd33ff4451"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("bd53a164-26df-45ab-bf5c-08dd0d797a44"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c13acae2-6d50-47cf-f711-08dd347f841d"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d5c19e8c-d8da-421c-a82c-08dd12f8ba89"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e2caf058-47c5-4c10-3fc6-08dd1604c009"));
        }
    }
}
