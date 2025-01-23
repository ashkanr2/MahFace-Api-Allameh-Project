using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MAhface.Infrastructure.EfCore.Migrations
{
    /// <inheritdoc />
    public partial class seedDAtas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "BirthDate", "ConcurrencyStamp", "Email", "EmailConfirmed", "Firstname", "ImageId", "IsActived", "IsDeleted", "IsSystemAccount", "IsSystemAdmin", "IsTeacher", "LastName", "LockoutEnabled", "LockoutEnd", "NationalCode", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileImageId", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("05c5b88d-af8c-407e-d068-08dd15005342"), 0, new DateTime(2024, 12, 5, 7, 42, 7, 242, DateTimeKind.Unspecified), "76b1da8d-1986-4020-840f-bbba1a97a295", "string", false, "string", null, false, false, false, false, true, "string", false, null, "string", null, null, null, "string", false, null, null, false, null });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "BirthDate", "ConcurrencyStamp", "Email", "EmailConfirmed", "Firstname", "ImageId", "IsActived", "IsDeleted", "IsStudent", "IsSystemAccount", "IsSystemAdmin", "IsTeacher", "LastName", "LockoutEnabled", "LockoutEnd", "NationalCode", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileImageId", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("282a7f03-1dca-4d15-b706-08dd20626fc4"), 0, new DateTime(2024, 12, 19, 19, 21, 28, 118, DateTimeKind.Unspecified), "76b1da8d-1986-4020-840f-bbba1a97a295", "razaviash21@gmail.com", false, "test email", null, false, false, true, false, false, false, "ashkan", false, null, "1215", null, null, null, "0915215", false, null, null, false, null });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "BirthDate", "ConcurrencyStamp", "Email", "EmailConfirmed", "Firstname", "ImageId", "IsActived", "IsDeleted", "IsSystemAccount", "IsSystemAdmin", "IsTeacher", "LastName", "LockoutEnabled", "LockoutEnd", "NationalCode", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileImageId", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("81e27342-10ef-4faf-74ca-08dd1ad120c3"), 0, new DateTime(2004, 12, 12, 17, 22, 1, 253, DateTimeKind.Unspecified), "76b1da8d-1986-4020-840f-bbba1a97a295", "u@gmail.com", false, "sobhan", null, false, false, false, false, true, "saffari", false, null, "0005654789", null, null, null, "09121940087", false, null, null, false, null },
                    { new Guid("85f9967b-1011-40c0-a32e-87370b013966"), 0, new DateTime(2002, 11, 25, 17, 47, 55, 494, DateTimeKind.Unspecified), "76b1da8d-1986-4020-840f-bbba1a97a295", "AshkanTeacher@gmail.com", false, "Admin", null, false, false, true, true, false, "Admini", false, null, "1234567890", null, null, null, "09123655654", false, null, null, false, null },
                    { new Guid("9ceea18b-7117-4059-805c-08dd0d8a09bd"), 0, new DateTime(2024, 11, 25, 19, 32, 45, 25, DateTimeKind.Unspecified), "76b1da8d-1986-4020-840f-bbba1a97a295", "jadi@gmail.com", false, "جادی", null, false, false, false, false, true, "میر میرانی", false, null, "1234567891", null, null, null, "09121236547", false, null, null, false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "BirthDate", "ConcurrencyStamp", "Email", "EmailConfirmed", "Firstname", "ImageId", "IsActived", "IsDeleted", "IsStudent", "IsSystemAccount", "IsSystemAdmin", "IsTeacher", "LastName", "LockoutEnabled", "LockoutEnd", "NationalCode", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileImageId", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("9f5dac63-d870-4424-7166-08dd2064841e"), 0, new DateTime(2024, 12, 19, 19, 36, 36, 471, DateTimeKind.Unspecified), "76b1da8d-1986-4020-840f-bbba1a97a295", "string@", false, "5651", null, false, false, true, false, false, false, "hfyhb55", false, null, "366551", null, null, null, "21521", false, null, null, false, null },
                    { new Guid("b373c277-e096-465f-a7e2-08dd33ff4451"), 0, new DateTime(2000, 1, 18, 18, 21, 33, 105, DateTimeKind.Unspecified), "76b1da8d-1986-4020-840f-bbba1a97a295", "abolfazlVafaDost@gmail.com", false, "ابوالفضل", null, false, false, true, false, false, false, " وفادوست", false, null, "1234567891", null, null, null, "09121234123", false, null, null, false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "BirthDate", "ConcurrencyStamp", "Email", "EmailConfirmed", "Firstname", "ImageId", "IsActived", "IsDeleted", "IsSystemAccount", "IsSystemAdmin", "IsTeacher", "LastName", "LockoutEnabled", "LockoutEnd", "NationalCode", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileImageId", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("bd53a164-26df-45ab-bf5c-08dd0d797a44"), 0, new DateTime(2002, 11, 25, 17, 47, 55, 494, DateTimeKind.Unspecified), "76b1da8d-1986-4020-840f-bbba1a97a295", "AshkanTeacher@gmail.com", false, "Ashkan", null, false, false, false, false, true, "Teacher", false, null, "1234567890", null, null, null, "09123655654", false, null, null, false, null });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "BirthDate", "ConcurrencyStamp", "Email", "EmailConfirmed", "Firstname", "ImageId", "IsActived", "IsDeleted", "IsStudent", "IsSystemAccount", "IsSystemAdmin", "IsTeacher", "LastName", "LockoutEnabled", "LockoutEnd", "NationalCode", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileImageId", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("c13acae2-6d50-47cf-f711-08dd347f841d"), 0, new DateTime(2025, 1, 14, 9, 39, 55, 273, DateTimeKind.Unspecified), "76b1da8d-1986-4020-840f-bbba1a97a295", "s", false, "s", null, false, false, true, false, false, false, "2", false, null, "b", null, null, null, "f", false, null, null, false, null });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "BirthDate", "ConcurrencyStamp", "Email", "EmailConfirmed", "Firstname", "ImageId", "IsActived", "IsDeleted", "IsSystemAccount", "IsSystemAdmin", "IsTeacher", "LastName", "LockoutEnabled", "LockoutEnd", "NationalCode", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileImageId", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("d5c19e8c-d8da-421c-a82c-08dd12f8ba89"), 0, new DateTime(2002, 11, 2, 17, 41, 12, 121, DateTimeKind.Unspecified), "76b1da8d-1986-4020-840f-bbba1a97a295", "vahidJF@gmail.com", false, "وحید", null, false, false, false, false, true, "2جعفری", false, null, "", null, null, null, "09129129120", false, null, null, false, null });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "BirthDate", "ConcurrencyStamp", "Email", "EmailConfirmed", "Firstname", "ImageId", "IsActived", "IsDeleted", "IsStudent", "IsSystemAccount", "IsSystemAdmin", "IsTeacher", "LastName", "LockoutEnabled", "LockoutEnd", "NationalCode", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileImageId", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("e2caf058-47c5-4c10-3fc6-08dd1604c009"), 0, new DateTime(2024, 12, 6, 14, 45, 29, 103, DateTimeKind.Unspecified), "76b1da8d-1986-4020-840f-bbba1a97a295", "sobhandanger81@gmail.com", false, "sopo", null, false, false, true, false, false, false, "saffari", false, null, "002510174", null, null, null, "09917358742", false, null, null, false, null });

            migrationBuilder.InsertData(
                schema: "BasicInfo",
                table: "Category",
                columns: new[] { "Id", "CreatedDate", "CreatedUserID", "DeletedDate", "DeletedUserID", "Description", "ISActive", "IsDeleted", "OrderNo", "ParentCategoryId", "Title" },
                values: new object[,]
                {
                    { new Guid("13dc2597-a7a3-482e-b54a-23e83d2ab18b"), new DateTime(2025, 1, 23, 18, 43, 27, 64, DateTimeKind.Local).AddTicks(6053), new Guid("85f9967b-1011-40c0-a32e-87370b013966"), null, null, "", true, false, 7, null, "دانشگاهی علوم پایه پزشکی" },
                    { new Guid("35f3bf57-7f05-41a7-8ecb-9b48bcd52fa7"), new DateTime(2025, 1, 23, 18, 43, 27, 64, DateTimeKind.Local).AddTicks(6070), new Guid("85f9967b-1011-40c0-a32e-87370b013966"), null, null, "", true, false, 6, null, "دانشگاهی فنی و مهندسی" },
                    { new Guid("3cfad89a-7c7b-497e-acd6-9bfc97d48a9b"), new DateTime(2025, 1, 23, 18, 43, 27, 64, DateTimeKind.Local).AddTicks(6073), new Guid("85f9967b-1011-40c0-a32e-87370b013966"), null, null, "", true, false, 2, null, "آی تی  و نرم افزار" },
                    { new Guid("463044b4-343f-4101-b2a3-73012d059ac9"), new DateTime(2025, 1, 23, 18, 43, 27, 64, DateTimeKind.Local).AddTicks(6062), new Guid("85f9967b-1011-40c0-a32e-87370b013966"), null, null, "", true, false, 9, null, "هنر" },
                    { new Guid("4a6ef880-e352-49dc-0976-08dd0d886873"), new DateTime(2025, 1, 23, 18, 43, 27, 64, DateTimeKind.Local).AddTicks(5962), new Guid("85f9967b-1011-40c0-a32e-87370b013966"), null, null, "string", true, false, 0, null, "تستی" },
                    { new Guid("75f6493f-813e-4d97-a0ea-e4203b90f436"), new DateTime(2025, 1, 23, 18, 43, 27, 64, DateTimeKind.Local).AddTicks(6091), new Guid("85f9967b-1011-40c0-a32e-87370b013966"), null, null, "", true, false, 8, null, "علوم پایه" },
                    { new Guid("7dbb7444-f7a7-46d7-aa82-d35f70b2165d"), new DateTime(2025, 1, 23, 18, 43, 27, 64, DateTimeKind.Local).AddTicks(6083), new Guid("85f9967b-1011-40c0-a32e-87370b013966"), null, null, "", true, false, 5, null, "مالی و سرمایه گذاری" },
                    { new Guid("a2a57c78-7043-42e3-a156-ea5ad99fc083"), new DateTime(2025, 1, 23, 18, 43, 27, 64, DateTimeKind.Local).AddTicks(6096), new Guid("85f9967b-1011-40c0-a32e-87370b013966"), null, null, "", true, false, 4, null, "مدیریت و کسب وکار" },
                    { new Guid("a654d03d-4e58-47fb-b70c-5e9433677052"), new DateTime(2025, 1, 23, 18, 43, 27, 64, DateTimeKind.Local).AddTicks(6058), new Guid("85f9967b-1011-40c0-a32e-87370b013966"), null, null, "", true, false, 3, null, "زبان های خارجی" },
                    { new Guid("c758ad65-5f5d-43cf-b676-8dac2d2cf948"), new DateTime(2025, 1, 23, 18, 43, 27, 64, DateTimeKind.Local).AddTicks(6065), new Guid("85f9967b-1011-40c0-a32e-87370b013966"), null, null, "", true, false, 1, null, "برنامه نویسی" }
                });

            migrationBuilder.InsertData(
                schema: "BasicInfo",
                table: "Teacher",
                columns: new[] { "Id", "Code", "CreatedDate", "CreatedUserID", "DeletedDate", "DeletedUserID", "Description", "ISActive", "IsDeleted", "UserId" },
                values: new object[,]
                {
                    { new Guid("0c7938f9-e881-42fa-242b-08dd2592d1dd"), 4, new DateTime(2025, 1, 23, 18, 43, 27, 64, DateTimeKind.Local).AddTicks(6576), new Guid("42d8b18d-cecc-49db-9b6d-fd64cc5ba465"), null, null, null, true, false, new Guid("05c5b88d-af8c-407e-d068-08dd15005342") },
                    { new Guid("1f262031-5db7-47ae-893d-08dd0d86a8be"), 1, new DateTime(2025, 1, 23, 18, 43, 27, 64, DateTimeKind.Local).AddTicks(6561), new Guid("98438e02-92bd-444c-8fff-dde61665ae96"), null, null, null, true, false, new Guid("bd53a164-26df-45ab-bf5c-08dd0d797a44") },
                    { new Guid("2603e63f-9b46-4807-72be-08dd0d8f6f8f"), 2, new DateTime(2025, 1, 23, 18, 43, 27, 64, DateTimeKind.Local).AddTicks(6568), new Guid("82f80bf3-1c2a-4491-b980-9e49e433d57a"), null, null, null, true, false, new Guid("9ceea18b-7117-4059-805c-08dd0d8a09bd") },
                    { new Guid("3a4086aa-1278-4325-242c-08dd2592d1dd"), 5, new DateTime(2025, 1, 23, 18, 43, 27, 64, DateTimeKind.Local).AddTicks(6585), new Guid("8ebd124e-8cf2-43f9-9db2-62d25e5a31f0"), null, null, null, true, false, new Guid("05c5b88d-af8c-407e-d068-08dd15005342") },
                    { new Guid("486c341e-03d9-4616-242e-08dd2592d1dd"), 7, new DateTime(2025, 1, 23, 18, 43, 27, 64, DateTimeKind.Local).AddTicks(6594), new Guid("a0fa8e5e-9ea2-4f14-b056-b22c452d44e3"), null, null, null, true, false, new Guid("05c5b88d-af8c-407e-d068-08dd15005342") },
                    { new Guid("55a3337f-cfa5-4440-242a-08dd2592d1dd"), 3, new DateTime(2025, 1, 23, 18, 43, 27, 64, DateTimeKind.Local).AddTicks(6572), new Guid("79364c79-0621-4497-b81d-71427069055a"), null, null, null, true, false, new Guid("05c5b88d-af8c-407e-d068-08dd15005342") },
                    { new Guid("ecf68ade-4b48-4307-242d-08dd2592d1dd"), 6, new DateTime(2025, 1, 23, 18, 43, 27, 64, DateTimeKind.Local).AddTicks(6590), new Guid("674f044e-8b5b-4d2f-ad5a-1bd9de2d40cd"), null, null, null, true, false, new Guid("05c5b88d-af8c-407e-d068-08dd15005342") }
                });

            migrationBuilder.InsertData(
                schema: "Study",
                table: "Course",
                columns: new[] { "Id", "CategoryId", "Code", "Cost", "CourseDescription", "CourseLevelId", "CreatedDate", "CreatedUserID", "DeletedDate", "DeletedUserID", "Description", "ISActive", "ImageId", "IsDeleted", "StarsNumber", "TeacherId", "Title" },
                values: new object[,]
                {
                    { new Guid("12f272c9-f198-45c4-a260-08dd37ab6f06"), new Guid("c758ad65-5f5d-43cf-b676-8dac2d2cf948"), 206, 2000000m, "آموزش پیشرفته پایتون برای تحلیل داده، هوش مصنوعی و طراحی سیستم.", 2, new DateTime(2025, 1, 23, 18, 43, 27, 64, DateTimeKind.Local).AddTicks(6776), new Guid("bd53a164-26df-45ab-bf5c-08dd0d797a44"), null, null, null, true, null, false, 5, new Guid("1f262031-5db7-47ae-893d-08dd0d86a8be"), "برنامه‌نویسی پیشرفته با پایتون" },
                    { new Guid("39a2b245-8188-4b47-b508-08dd37ab7f09"), new Guid("c758ad65-5f5d-43cf-b676-8dac2d2cf948"), 216, 2500000m, "آموزش ساخت برنامه‌های تحت وب بااستفاده از ASP.NETCore.", 2, new DateTime(2025, 1, 23, 18, 43, 27, 64, DateTimeKind.Local).AddTicks(6833), new Guid("05c5b88d-af8c-407e-d068-08dd15005342"), null, null, null, true, null, false, 5, new Guid("486c341e-03d9-4616-242e-08dd2592d1dd"), "توسعه وب ASP.NET Core" },
                    { new Guid("42d99c9a-7d35-4a45-a256-08dd37ab6f02"), new Guid("a654d03d-4e58-47fb-b70c-5e9433677052"), 202, 800000m, "آشنایی با مفاهیم پایه‌ای فیزیک و حل مسائل کاربردی.", 1, new DateTime(2025, 1, 23, 18, 43, 27, 64, DateTimeKind.Local).AddTicks(6753), new Guid("9ceea18b-7117-4059-805c-08dd0d8a09bd"), null, null, null, true, null, false, 5, new Guid("2603e63f-9b46-4807-72be-08dd0d8f6f8f"), "فیزیک عمومی 1" },
                    { new Guid("5f2b414d-63ec-4d3b-bfd3-08dd37aa0f43"), new Guid("c758ad65-5f5d-43cf-b676-8dac2d2cf948"), 101, 1200000m, "دوره جامع و پروژه محور سی‌شارپ مناسب برای مبتدی تا پیشرفته.", 1, new DateTime(2025, 1, 23, 18, 43, 27, 64, DateTimeKind.Local).AddTicks(6712), new Guid("bd53a164-26df-45ab-bf5c-08dd0d797a44"), null, null, null, true, null, false, 5, new Guid("1f262031-5db7-47ae-893d-08dd0d86a8be"), "آموزش برنامه‌نویسی سی‌شارپ" },
                    { new Guid("6d9c7e02-56c7-4a77-b506-08dd37ab7f07"), new Guid("7dbb7444-f7a7-46d7-aa82-d35f70b2165d"), 214, 1700000m, "آشنایی با تکنیک‌ها و ابزارهای مدیریت پروژه‌های نرم‌افزاری.", 2, new DateTime(2025, 1, 23, 18, 43, 27, 64, DateTimeKind.Local).AddTicks(6821), new Guid("bd53a164-26df-45ab-bf5c-08dd0d797a44"), null, null, null, true, null, false, 5, new Guid("1f262031-5db7-47ae-893d-08dd0d86a8be"), "مدیریت پروژه‌های نرم‌افزاری" },
                    { new Guid("71b3bede-4e8e-4207-a7d4-08dd37aa0f45"), new Guid("a654d03d-4e58-47fb-b70c-5e9433677052"), 103, 800000m, "دوره ویژه یادگیری زبان انگلیسی از سطح پایه با استفاده از روش‌های کاربردی.", 1, new DateTime(2025, 1, 23, 18, 43, 27, 64, DateTimeKind.Local).AddTicks(6726), new Guid("05c5b88d-af8c-407e-d068-08dd15005342"), null, null, null, true, null, false, 5, new Guid("55a3337f-cfa5-4440-242a-08dd2592d1dd"), "آموزش زبان  برای مبتدیان" },
                    { new Guid("7f6f6aab-c44f-4d30-a257-08dd37ab6f03"), new Guid("3cfad89a-7c7b-497e-acd6-9bfc97d48a9b"), 203, 1000000m, "یادگیری مفاهیم آمار و احتمالات برای حل مسائل مهندسی.", 2, new DateTime(2025, 1, 23, 18, 43, 27, 64, DateTimeKind.Local).AddTicks(6758), new Guid("05c5b88d-af8c-407e-d068-08dd15005342"), null, null, null, true, null, false, 5, new Guid("55a3337f-cfa5-4440-242a-08dd2592d1dd"), "آمار و احتمالات مهندسی" },
                    { new Guid("876a3131-1dc9-4a21-b509-08dd37ab7f10"), new Guid("7dbb7444-f7a7-46d7-aa82-d35f70b2165d"), 217, 1800000m, "یادگیری اصول و تکنیک‌های پایه‌ای هوش مصنوعی.", 1, new DateTime(2025, 1, 23, 18, 43, 27, 64, DateTimeKind.Local).AddTicks(6839), new Guid("bd53a164-26df-45ab-bf5c-08dd0d797a44"), null, null, null, true, null, false, 4, new Guid("1f262031-5db7-47ae-893d-08dd0d86a8be"), "آموزش مقدماتی هوش مصنوعی" },
                    { new Guid("89e4b1db-9b95-4fa8-a261-08dd37ab6f07"), new Guid("463044b4-343f-4101-b2a3-73012d059ac9"), 207, 1800000m, "آشنایی با ابزارها و تکنیک‌های طراحی سه‌بعدی در نرم‌افزار Blender.", 2, new DateTime(2025, 1, 23, 18, 43, 27, 64, DateTimeKind.Local).AddTicks(6781), new Guid("05c5b88d-af8c-407e-d068-08dd15005342"), null, null, null, true, null, false, 4, new Guid("486c341e-03d9-4616-242e-08dd2592d1dd"), "طراحی و مدل‌سازی  با Blender" },
                    { new Guid("9d7f57a8-26d1-4b9f-a255-08dd37ab6f01"), new Guid("c758ad65-5f5d-43cf-b676-8dac2d2cf948"), 201, 500000m, "دوره‌ای مناسب برای آشنایی با اصول اولیه ریاضیات پایه و کاربردهای آن.", 1, new DateTime(2025, 1, 23, 18, 43, 27, 64, DateTimeKind.Local).AddTicks(6746), new Guid("bd53a164-26df-45ab-bf5c-08dd0d797a44"), null, null, null, true, null, false, 4, new Guid("1f262031-5db7-47ae-893d-08dd0d86a8be"), "مبانی ریاضیات پایه" },
                    { new Guid("a12c08e7-8827-4912-b502-08dd37ab7f03"), new Guid("3cfad89a-7c7b-497e-acd6-9bfc97d48a9b"), 210, 1500000m, "آموزش تحلیل داده‌های سازمانی با استفاده از زبان SQL.", 2, new DateTime(2025, 1, 23, 18, 43, 27, 64, DateTimeKind.Local).AddTicks(6798), new Guid("bd53a164-26df-45ab-bf5c-08dd0d797a44"), null, null, null, true, null, false, 5, new Guid("1f262031-5db7-47ae-893d-08dd0d86a8be"), "تحلیل داده با SQL" },
                    { new Guid("ab3e4a26-9e2f-46fa-b510-08dd37ab7f11"), new Guid("c758ad65-5f5d-43cf-b676-8dac2d2cf948"), 218, 2000000m, "آموزش مفاهیم شیءگرایی و پیاده‌سازی آن با زبان C#.", 2, new DateTime(2025, 1, 23, 18, 43, 27, 64, DateTimeKind.Local).AddTicks(6844), new Guid("05c5b88d-af8c-407e-d068-08dd15005342"), null, null, null, true, null, false, 5, new Guid("486c341e-03d9-4616-242e-08dd2592d1dd"), "برنامه‌نویسی شیءگرا با C#" },
                    { new Guid("af8d7e39-0f8f-42b9-b1c3-08dd37aa0f44"), new Guid("7dbb7444-f7a7-46d7-aa82-d35f70b2165d"), 102, 1500000m, "آشنایی با اصول مدیریت مالی و تکنیک‌های سرمایه‌گذاری در بازار.", 2, new DateTime(2025, 1, 23, 18, 43, 27, 64, DateTimeKind.Local).AddTicks(6721), new Guid("9ceea18b-7117-4059-805c-08dd0d8a09bd"), null, null, null, true, null, false, 4, new Guid("2603e63f-9b46-4807-72be-08dd0d8f6f8f"), "مدیریت مالی و سرمایه‌گذاری" },
                    { new Guid("b3e0b271-f8e0-4b3a-a7e5-08dd37aa0f46"), new Guid("463044b4-343f-4101-b2a3-73012d059ac9"), 104, 900000m, "آشنایی با اصول طراحی و نقاشی برای هنرجویان مبتدی.", 1, new DateTime(2025, 1, 23, 18, 43, 27, 64, DateTimeKind.Local).AddTicks(6733), new Guid("05c5b88d-af8c-407e-d068-08dd15005342"), null, null, null, true, null, false, 4, new Guid("486c341e-03d9-4616-242e-08dd2592d1dd"), "مبانی هنر و طراحی" },
                    { new Guid("b8c1131e-c817-44ea-a258-08dd37ab6f04"), new Guid("7dbb7444-f7a7-46d7-aa82-d35f70b2165d"), 204, 1500000m, "آشنایی با اصول بازاریابی در دنیای دیجیتال و راه‌های جذب مشتری.", 1, new DateTime(2025, 1, 23, 18, 43, 27, 64, DateTimeKind.Local).AddTicks(6763), new Guid("bd53a164-26df-45ab-bf5c-08dd0d797a44"), null, null, null, true, null, false, 5, new Guid("1f262031-5db7-47ae-893d-08dd0d86a8be"), "اصول بازاریابی دیجیتال" },
                    { new Guid("bf3ea476-bc8f-4572-b504-08dd37ab7f05"), new Guid("a654d03d-4e58-47fb-b70c-5e9433677052"), 212, 800000m, "یادگیری اصول پایه‌ای مدارهای الکترونیکی و کاربردهای آن‌ها.", 1, new DateTime(2025, 1, 23, 18, 43, 27, 64, DateTimeKind.Local).AddTicks(6809), new Guid("05c5b88d-af8c-407e-d068-08dd15005342"), null, null, null, true, null, false, 4, new Guid("55a3337f-cfa5-4440-242a-08dd2592d1dd"), "مبانی برق و الکترونیک" },
                    { new Guid("c1e3b450-628f-4a43-b7e3-08dd37aa0f47"), new Guid("3cfad89a-7c7b-497e-acd6-9bfc97d48a9b"), 105, 2000000m, "دوره تخصصی برای یادگیری اصول هوش مصنوعی و پیاده‌سازی الگوریتم‌های یادگیری ماشین.", 3, new DateTime(2025, 1, 23, 18, 43, 27, 64, DateTimeKind.Local).AddTicks(6739), new Guid("bd53a164-26df-45ab-bf5c-08dd0d797a44"), null, null, null, true, null, false, 5, new Guid("1f262031-5db7-47ae-893d-08dd0d86a8be"), "هوش مصنوعی و یادگیری ماشین" },
                    { new Guid("c7f3d234-9fc3-453a-b500-08dd37ab7f01"), new Guid("c758ad65-5f5d-43cf-b676-8dac2d2cf948"), 208, 900000m, "آموزش مفاهیم اولیه برنامه‌نویسی با زبان جاوا برای مبتدیان.", 1, new DateTime(2025, 1, 23, 18, 43, 27, 64, DateTimeKind.Local).AddTicks(6787), new Guid("9ceea18b-7117-4059-805c-08dd0d8a09bd"), null, null, null, true, null, false, 4, new Guid("2603e63f-9b46-4807-72be-08dd0d8f6f8f"), "آموزش مقدماتی زبان جاوا" },
                    { new Guid("d52d29fb-80da-40b0-a259-08dd37ab6f05"), new Guid("463044b4-343f-4101-b2a3-73012d059ac9"), 205, 1200000m, "دوره‌ای جامع برای یادگیری طراحی صفحات وب با HTML و CSS.", 1, new DateTime(2025, 1, 23, 18, 43, 27, 64, DateTimeKind.Local).AddTicks(6770), new Guid("05c5b88d-af8c-407e-d068-08dd15005342"), null, null, null, true, null, false, 4, new Guid("486c341e-03d9-4616-242e-08dd2592d1dd"), "طراحی وب با HTML و CSS" },
                    { new Guid("d75d8d12-fdf9-45c8-b503-08dd37ab7f04"), new Guid("7dbb7444-f7a7-46d7-aa82-d35f70b2165d"), 211, 2500000m, "آموزش مفاهیم پایه‌ای یادگیری ماشین و الگوریتم‌های آن.", 1, new DateTime(2025, 1, 23, 18, 43, 27, 64, DateTimeKind.Local).AddTicks(6804), new Guid("9ceea18b-7117-4059-805c-08dd0d8a09bd"), null, null, null, true, null, false, 5, new Guid("2603e63f-9b46-4807-72be-08dd0d8f6f8f"), "یادگیری ماشین برای مبتدیان" },
                    { new Guid("ef123b19-3b99-4c24-b507-08dd37ab7f08"), new Guid("463044b4-343f-4101-b2a3-73012d059ac9"), 215, 1200000m, "آموزش طراحی رابط کاربری زیبا و کاربردی با ابزارهای مدرن.", 1, new DateTime(2025, 1, 23, 18, 43, 27, 64, DateTimeKind.Local).AddTicks(6828), new Guid("9ceea18b-7117-4059-805c-08dd0d8a09bd"), null, null, null, true, null, false, 4, new Guid("2603e63f-9b46-4807-72be-08dd0d8f6f8f"), "طراحی رابط کاربری (UI)" },
                    { new Guid("f3e321eb-94d8-4b8d-b505-08dd37ab7f06"), new Guid("c758ad65-5f5d-43cf-b676-8dac2d2cf948"), 213, 2200000m, "آموزش ساخت اپلیکیشن‌های موبایل برای اندروید و iOS با Flutter.", 2, new DateTime(2025, 1, 23, 18, 43, 27, 64, DateTimeKind.Local).AddTicks(6816), new Guid("05c5b88d-af8c-407e-d068-08dd15005342"), null, null, null, true, null, false, 5, new Guid("486c341e-03d9-4616-242e-08dd2592d1dd"), "توسعه اپلیکیشن‌های موبایل با Flutter" },
                    { new Guid("f9ad1d79-7325-497e-b501-08dd37ab7f02"), new Guid("463044b4-343f-4101-b2a3-73012d059ac9"), 209, 1100000m, "آشنایی با اصول پایه شبکه‌های کامپیوتری و پروتکل‌های ارتباطی.", 1, new DateTime(2025, 1, 23, 18, 43, 27, 64, DateTimeKind.Local).AddTicks(6793), new Guid("05c5b88d-af8c-407e-d068-08dd15005342"), null, null, null, true, null, false, 5, new Guid("486c341e-03d9-4616-242e-08dd2592d1dd"), "اصول شبکه‌های کامپیوتری" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                keyValue: new Guid("9f5dac63-d870-4424-7166-08dd2064841e"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b373c277-e096-465f-a7e2-08dd33ff4451"));

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
                keyValue: new Guid("a2a57c78-7043-42e3-a156-ea5ad99fc083"));

            migrationBuilder.DeleteData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("12f272c9-f198-45c4-a260-08dd37ab6f06"));

            migrationBuilder.DeleteData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("39a2b245-8188-4b47-b508-08dd37ab7f09"));

            migrationBuilder.DeleteData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("42d99c9a-7d35-4a45-a256-08dd37ab6f02"));

            migrationBuilder.DeleteData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("5f2b414d-63ec-4d3b-bfd3-08dd37aa0f43"));

            migrationBuilder.DeleteData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("6d9c7e02-56c7-4a77-b506-08dd37ab7f07"));

            migrationBuilder.DeleteData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("71b3bede-4e8e-4207-a7d4-08dd37aa0f45"));

            migrationBuilder.DeleteData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("7f6f6aab-c44f-4d30-a257-08dd37ab6f03"));

            migrationBuilder.DeleteData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("876a3131-1dc9-4a21-b509-08dd37ab7f10"));

            migrationBuilder.DeleteData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("89e4b1db-9b95-4fa8-a261-08dd37ab6f07"));

            migrationBuilder.DeleteData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("9d7f57a8-26d1-4b9f-a255-08dd37ab6f01"));

            migrationBuilder.DeleteData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("a12c08e7-8827-4912-b502-08dd37ab7f03"));

            migrationBuilder.DeleteData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("ab3e4a26-9e2f-46fa-b510-08dd37ab7f11"));

            migrationBuilder.DeleteData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("af8d7e39-0f8f-42b9-b1c3-08dd37aa0f44"));

            migrationBuilder.DeleteData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("b3e0b271-f8e0-4b3a-a7e5-08dd37aa0f46"));

            migrationBuilder.DeleteData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("b8c1131e-c817-44ea-a258-08dd37ab6f04"));

            migrationBuilder.DeleteData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("bf3ea476-bc8f-4572-b504-08dd37ab7f05"));

            migrationBuilder.DeleteData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("c1e3b450-628f-4a43-b7e3-08dd37aa0f47"));

            migrationBuilder.DeleteData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("c7f3d234-9fc3-453a-b500-08dd37ab7f01"));

            migrationBuilder.DeleteData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("d52d29fb-80da-40b0-a259-08dd37ab6f05"));

            migrationBuilder.DeleteData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("d75d8d12-fdf9-45c8-b503-08dd37ab7f04"));

            migrationBuilder.DeleteData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("ef123b19-3b99-4c24-b507-08dd37ab7f08"));

            migrationBuilder.DeleteData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("f3e321eb-94d8-4b8d-b505-08dd37ab7f06"));

            migrationBuilder.DeleteData(
                schema: "Study",
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("f9ad1d79-7325-497e-b501-08dd37ab7f02"));

            migrationBuilder.DeleteData(
                schema: "BasicInfo",
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("0c7938f9-e881-42fa-242b-08dd2592d1dd"));

            migrationBuilder.DeleteData(
                schema: "BasicInfo",
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("3a4086aa-1278-4325-242c-08dd2592d1dd"));

            migrationBuilder.DeleteData(
                schema: "BasicInfo",
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("ecf68ade-4b48-4307-242d-08dd2592d1dd"));

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
                keyValue: new Guid("7dbb7444-f7a7-46d7-aa82-d35f70b2165d"));

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
                keyValue: new Guid("486c341e-03d9-4616-242e-08dd2592d1dd"));

            migrationBuilder.DeleteData(
                schema: "BasicInfo",
                table: "Teacher",
                keyColumn: "Id",
                keyValue: new Guid("55a3337f-cfa5-4440-242a-08dd2592d1dd"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("05c5b88d-af8c-407e-d068-08dd15005342"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9ceea18b-7117-4059-805c-08dd0d8a09bd"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("bd53a164-26df-45ab-bf5c-08dd0d797a44"));
        }
    }
}
