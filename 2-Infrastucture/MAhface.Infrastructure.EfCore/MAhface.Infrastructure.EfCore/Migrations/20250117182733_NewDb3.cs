using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MAhface.Infrastructure.EfCore.Migrations
{
    /// <inheritdoc />
    public partial class NewDb3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "BasicInfo");

            migrationBuilder.EnsureSchema(
                name: "Study");

            migrationBuilder.EnsureSchema(
                name: "System");

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Category",
                schema: "BasicInfo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ParentCategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    OrderNo = table.Column<int>(type: "int", nullable: true),
                    Code = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedUserID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedUserID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ISActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmailSetting",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SMTPHost = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SMTPPort = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailSetting", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ErrorLog",
                schema: "System",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Entityname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ActionType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ActionName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Exeption = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ErrorLog", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Image",
                schema: "BasicInfo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Base64File = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    table.PrimaryKey("PK_Image", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Otps",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OtpCode = table.Column<int>(type: "int", nullable: false),
                    EmailOrPhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpireTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Otps", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Firstname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NationalCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    IsSystemAccount = table.Column<bool>(type: "bit", nullable: false),
                    IsSystemAdmin = table.Column<bool>(type: "bit", nullable: false),
                    IsStudent = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    IsTeacher = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActived = table.Column<bool>(type: "bit", nullable: false),
                    ImageId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ProfileImageId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Image_ImageId",
                        column: x => x.ImageId,
                        principalSchema: "BasicInfo",
                        principalTable: "Image",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmailLogs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ToEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Subject = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ErrorDetails = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SentByUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsSuccess = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailLogs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmailLogs_AspNetUsers_SentByUserId",
                        column: x => x.SentByUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Student",
                schema: "BasicInfo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    table.PrimaryKey("PK_Student", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Student_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Teacher",
                schema: "BasicInfo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    table.PrimaryKey("PK_Teacher", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Teacher_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TeacherRequests",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserRequestDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AdminDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdminResponseDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    StatusCode = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeacherRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TeacherRequests_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Views",
                schema: "Study",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CourseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastVideoTime = table.Column<TimeOnly>(type: "time", nullable: false),
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
                    table.PrimaryKey("PK_Views", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Views_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Course",
                schema: "Study",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    CourseLevelId = table.Column<int>(type: "int", nullable: true),
                    StarsNumber = table.Column<int>(type: "int", maxLength: 5, nullable: false),
                    TeacherId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CourseDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ImageId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
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
                    table.PrimaryKey("PK_Course", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Course_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalSchema: "BasicInfo",
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Course_Image_ImageId",
                        column: x => x.ImageId,
                        principalSchema: "BasicInfo",
                        principalTable: "Image",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Course_Teacher_TeacherId",
                        column: x => x.TeacherId,
                        principalSchema: "BasicInfo",
                        principalTable: "Teacher",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CoursesStudent",
                columns: table => new
                {
                    CoursesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StudentsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoursesStudent", x => new { x.CoursesId, x.StudentsId });
                    table.ForeignKey(
                        name: "FK_CoursesStudent_Course_CoursesId",
                        column: x => x.CoursesId,
                        principalSchema: "Study",
                        principalTable: "Course",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CoursesStudent_Student_StudentsId",
                        column: x => x.StudentsId,
                        principalSchema: "BasicInfo",
                        principalTable: "Student",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Season",
                schema: "Study",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CourseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SeasonsDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    table.PrimaryKey("PK_Season", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Season_Course_CourseId",
                        column: x => x.CourseId,
                        principalSchema: "Study",
                        principalTable: "Course",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Episodes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "BirthDate", "ConcurrencyStamp", "Email", "EmailConfirmed", "Firstname", "ImageId", "IsActived", "IsDeleted", "IsSystemAccount", "IsSystemAdmin", "IsTeacher", "LastName", "LockoutEnabled", "LockoutEnd", "NationalCode", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileImageId", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("05c5b88d-af8c-407e-d068-08dd15005342"), 0, new DateTime(2024, 12, 5, 7, 42, 7, 242, DateTimeKind.Unspecified), "738cb7cd-5dea-41a2-a99f-28b42ba97a19", "string", false, "string", null, false, false, false, false, true, "string", false, null, "string", null, null, null, "string", false, null, null, false, null });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "BirthDate", "ConcurrencyStamp", "Email", "EmailConfirmed", "Firstname", "ImageId", "IsActived", "IsDeleted", "IsStudent", "IsSystemAccount", "IsSystemAdmin", "IsTeacher", "LastName", "LockoutEnabled", "LockoutEnd", "NationalCode", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileImageId", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("282a7f03-1dca-4d15-b706-08dd20626fc4"), 0, new DateTime(2024, 12, 19, 19, 21, 28, 118, DateTimeKind.Unspecified), "3459d17b-68d2-4e32-8746-890f51564bab", "razaviash21@gmail.com", false, "test email", null, false, false, true, false, false, false, "ashkan", false, null, "1215", null, null, null, "0915215", false, null, null, false, null });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "BirthDate", "ConcurrencyStamp", "Email", "EmailConfirmed", "Firstname", "ImageId", "IsActived", "IsDeleted", "IsSystemAccount", "IsSystemAdmin", "IsTeacher", "LastName", "LockoutEnabled", "LockoutEnd", "NationalCode", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileImageId", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("81e27342-10ef-4faf-74ca-08dd1ad120c3"), 0, new DateTime(2004, 12, 12, 17, 22, 1, 253, DateTimeKind.Unspecified), "136b5974-f0f4-4041-9c89-06f9a67c6b41", "u@gmail.com", false, "sobhan", null, false, false, false, false, true, "saffari", false, null, "0005654789", null, null, null, "09121940087", false, null, null, false, null },
                    { new Guid("85f9967b-1011-40c0-a32e-87370b013966"), 0, new DateTime(2002, 11, 25, 17, 47, 55, 494, DateTimeKind.Unspecified), "d716e4bb-bfff-487c-95bc-7822abdc9721", "AshkanTeacher@gmail.com", false, "Admin", null, false, false, true, true, false, "Admini", false, null, "1234567890", null, null, null, "09123655654", false, null, null, false, null },
                    { new Guid("9ceea18b-7117-4059-805c-08dd0d8a09bd"), 0, new DateTime(2024, 11, 25, 19, 32, 45, 25, DateTimeKind.Unspecified), "99816dba-dba0-4601-add4-9ea3d02e5d10", "jadi@gmail.com", false, "جادی", null, false, false, false, false, true, "میر میرانی", false, null, "1234567891", null, null, null, "09121236547", false, null, null, false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "BirthDate", "ConcurrencyStamp", "Email", "EmailConfirmed", "Firstname", "ImageId", "IsActived", "IsDeleted", "IsStudent", "IsSystemAccount", "IsSystemAdmin", "IsTeacher", "LastName", "LockoutEnabled", "LockoutEnd", "NationalCode", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileImageId", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("9f5dac63-d870-4424-7166-08dd2064841e"), 0, new DateTime(2024, 12, 19, 19, 36, 36, 471, DateTimeKind.Unspecified), "74bf6b3c-8f3e-4f9c-88f6-78baa1657e7c", "string@", false, "5651", null, false, false, true, false, false, false, "hfyhb55", false, null, "366551", null, null, null, "21521", false, null, null, false, null },
                    { new Guid("b373c277-e096-465f-a7e2-08dd33ff4451"), 0, new DateTime(2000, 1, 18, 18, 21, 33, 105, DateTimeKind.Unspecified), "afdfc366-00e0-4628-ae90-2feb64b6fc1f", "abolfazlVafaDost@gmail.com", false, "ابوالفضل", null, false, false, true, false, false, false, " وفادوست", false, null, "1234567891", null, null, null, "09121234123", false, null, null, false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "BirthDate", "ConcurrencyStamp", "Email", "EmailConfirmed", "Firstname", "ImageId", "IsActived", "IsDeleted", "IsSystemAccount", "IsSystemAdmin", "IsTeacher", "LastName", "LockoutEnabled", "LockoutEnd", "NationalCode", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileImageId", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("bd53a164-26df-45ab-bf5c-08dd0d797a44"), 0, new DateTime(2002, 11, 25, 17, 47, 55, 494, DateTimeKind.Unspecified), "ac995c2e-edc6-4816-90e7-c5330e99881c", "AshkanTeacher@gmail.com", false, "Ashkan", null, false, false, false, false, true, "Teacher", false, null, "1234567890", null, null, null, "09123655654", false, null, null, false, null });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "BirthDate", "ConcurrencyStamp", "Email", "EmailConfirmed", "Firstname", "ImageId", "IsActived", "IsDeleted", "IsStudent", "IsSystemAccount", "IsSystemAdmin", "IsTeacher", "LastName", "LockoutEnabled", "LockoutEnd", "NationalCode", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileImageId", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("c13acae2-6d50-47cf-f711-08dd347f841d"), 0, new DateTime(2025, 1, 14, 9, 39, 55, 273, DateTimeKind.Unspecified), "492eea8d-c477-493e-8b54-131917756377", "s", false, "s", null, false, false, true, false, false, false, "2", false, null, "b", null, null, null, "f", false, null, null, false, null });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "BirthDate", "ConcurrencyStamp", "Email", "EmailConfirmed", "Firstname", "ImageId", "IsActived", "IsDeleted", "IsSystemAccount", "IsSystemAdmin", "IsTeacher", "LastName", "LockoutEnabled", "LockoutEnd", "NationalCode", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileImageId", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("d5c19e8c-d8da-421c-a82c-08dd12f8ba89"), 0, new DateTime(2002, 11, 2, 17, 41, 12, 121, DateTimeKind.Unspecified), "ff799f78-12c8-49f3-b9e2-390036c77aa9", "vahidJF@gmail.com", false, "وحید", null, false, false, false, false, true, "2جعفری", false, null, "", null, null, null, "09129129120", false, null, null, false, null });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "BirthDate", "ConcurrencyStamp", "Email", "EmailConfirmed", "Firstname", "ImageId", "IsActived", "IsDeleted", "IsStudent", "IsSystemAccount", "IsSystemAdmin", "IsTeacher", "LastName", "LockoutEnabled", "LockoutEnd", "NationalCode", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileImageId", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("e2caf058-47c5-4c10-3fc6-08dd1604c009"), 0, new DateTime(2024, 12, 6, 14, 45, 29, 103, DateTimeKind.Unspecified), "76dcbc56-c595-4b5f-9e55-1dff559759a3", "sobhandanger81@gmail.com", false, "sopo", null, false, false, true, false, false, false, "saffari", false, null, "002510174", null, null, null, "09917358742", false, null, null, false, null });

            migrationBuilder.InsertData(
                schema: "BasicInfo",
                table: "Category",
                columns: new[] { "Id", "CreatedDate", "CreatedUserID", "DeletedDate", "DeletedUserID", "Description", "ISActive", "IsDeleted", "OrderNo", "ParentCategoryId", "Title" },
                values: new object[,]
                {
                    { new Guid("13dc2597-a7a3-482e-b54a-23e83d2ab18b"), new DateTime(2025, 1, 17, 21, 57, 30, 779, DateTimeKind.Local).AddTicks(4928), new Guid("85f9967b-1011-40c0-a32e-87370b013966"), null, null, "", true, false, 7, null, "دانشگاهی علوم پایه پزشکی" },
                    { new Guid("35f3bf57-7f05-41a7-8ecb-9b48bcd52fa7"), new DateTime(2025, 1, 17, 21, 57, 30, 779, DateTimeKind.Local).AddTicks(4945), new Guid("85f9967b-1011-40c0-a32e-87370b013966"), null, null, "", true, false, 6, null, "دانشگاهی فنی و مهندسی" },
                    { new Guid("3cfad89a-7c7b-497e-acd6-9bfc97d48a9b"), new DateTime(2025, 1, 17, 21, 57, 30, 779, DateTimeKind.Local).AddTicks(4949), new Guid("85f9967b-1011-40c0-a32e-87370b013966"), null, null, "", true, false, 2, null, "آی تی  و نرم افزار" },
                    { new Guid("463044b4-343f-4101-b2a3-73012d059ac9"), new DateTime(2025, 1, 17, 21, 57, 30, 779, DateTimeKind.Local).AddTicks(4935), new Guid("85f9967b-1011-40c0-a32e-87370b013966"), null, null, "", true, false, 9, null, "هنر" },
                    { new Guid("4a6ef880-e352-49dc-0976-08dd0d886873"), new DateTime(2025, 1, 17, 21, 57, 30, 779, DateTimeKind.Local).AddTicks(4909), new Guid("85f9967b-1011-40c0-a32e-87370b013966"), null, null, "string", true, false, 0, null, "تستی" },
                    { new Guid("75f6493f-813e-4d97-a0ea-e4203b90f436"), new DateTime(2025, 1, 17, 21, 57, 30, 779, DateTimeKind.Local).AddTicks(4957), new Guid("85f9967b-1011-40c0-a32e-87370b013966"), null, null, "", true, false, 8, null, "علوم پایه" },
                    { new Guid("7dbb7444-f7a7-46d7-aa82-d35f70b2165d"), new DateTime(2025, 1, 17, 21, 57, 30, 779, DateTimeKind.Local).AddTicks(4954), new Guid("85f9967b-1011-40c0-a32e-87370b013966"), null, null, "", true, false, 5, null, "مالی و سرمایه گذاری" },
                    { new Guid("a2a57c78-7043-42e3-a156-ea5ad99fc083"), new DateTime(2025, 1, 17, 21, 57, 30, 779, DateTimeKind.Local).AddTicks(4962), new Guid("85f9967b-1011-40c0-a32e-87370b013966"), null, null, "", true, false, 4, null, "مدیریت و کسب وکار" },
                    { new Guid("a654d03d-4e58-47fb-b70c-5e9433677052"), new DateTime(2025, 1, 17, 21, 57, 30, 779, DateTimeKind.Local).AddTicks(4932), new Guid("85f9967b-1011-40c0-a32e-87370b013966"), null, null, "", true, false, 3, null, "زبان های خارجی" },
                    { new Guid("c758ad65-5f5d-43cf-b676-8dac2d2cf948"), new DateTime(2025, 1, 17, 21, 57, 30, 779, DateTimeKind.Local).AddTicks(4939), new Guid("85f9967b-1011-40c0-a32e-87370b013966"), null, null, "", true, false, 1, null, "برنامه نویسی" }
                });

            migrationBuilder.InsertData(
                table: "EmailSetting",
                columns: new[] { "Id", "EmailAddress", "Password", "SMTPHost", "SMTPPort" },
                values: new object[] { new Guid("d4819e1b-3dab-4d13-9ee5-dfb6c2aee0ff"), "Register@mahface-allameh.ir", "MahfaceAllamEh", "mail.mahface-allameh.ir", 587 });

            migrationBuilder.InsertData(
                schema: "BasicInfo",
                table: "Teacher",
                columns: new[] { "Id", "Code", "CreatedDate", "CreatedUserID", "DeletedDate", "DeletedUserID", "Description", "ISActive", "IsDeleted", "UserId" },
                values: new object[,]
                {
                    { new Guid("0c7938f9-e881-42fa-242b-08dd2592d1dd"), 4, new DateTime(2025, 1, 17, 21, 57, 30, 779, DateTimeKind.Local).AddTicks(5481), new Guid("9904db92-c8bf-460c-bc47-2b809ba78554"), null, null, null, true, false, new Guid("05c5b88d-af8c-407e-d068-08dd15005342") },
                    { new Guid("1f262031-5db7-47ae-893d-08dd0d86a8be"), 1, new DateTime(2025, 1, 17, 21, 57, 30, 779, DateTimeKind.Local).AddTicks(5459), new Guid("76ff161d-b79c-40c6-8260-e1e25c3b7ea4"), null, null, null, true, false, new Guid("bd53a164-26df-45ab-bf5c-08dd0d797a44") },
                    { new Guid("2603e63f-9b46-4807-72be-08dd0d8f6f8f"), 2, new DateTime(2025, 1, 17, 21, 57, 30, 779, DateTimeKind.Local).AddTicks(5468), new Guid("891294b1-1877-4613-aacd-14b046afe14f"), null, null, null, true, false, new Guid("9ceea18b-7117-4059-805c-08dd0d8a09bd") },
                    { new Guid("3a4086aa-1278-4325-242c-08dd2592d1dd"), 5, new DateTime(2025, 1, 17, 21, 57, 30, 779, DateTimeKind.Local).AddTicks(5485), new Guid("c0865aa7-e2c7-463b-b32e-9a7895c56982"), null, null, null, true, false, new Guid("05c5b88d-af8c-407e-d068-08dd15005342") },
                    { new Guid("486c341e-03d9-4616-242e-08dd2592d1dd"), 7, new DateTime(2025, 1, 17, 21, 57, 30, 779, DateTimeKind.Local).AddTicks(5494), new Guid("2385e5c7-423f-481a-a7f4-7dfe08127e9e"), null, null, null, true, false, new Guid("05c5b88d-af8c-407e-d068-08dd15005342") },
                    { new Guid("55a3337f-cfa5-4440-242a-08dd2592d1dd"), 3, new DateTime(2025, 1, 17, 21, 57, 30, 779, DateTimeKind.Local).AddTicks(5476), new Guid("cfaf4145-926a-4366-ad51-0884efa152e2"), null, null, null, true, false, new Guid("05c5b88d-af8c-407e-d068-08dd15005342") },
                    { new Guid("ecf68ade-4b48-4307-242d-08dd2592d1dd"), 6, new DateTime(2025, 1, 17, 21, 57, 30, 779, DateTimeKind.Local).AddTicks(5490), new Guid("707c40ed-2330-4516-a7c0-a7021223c38c"), null, null, null, true, false, new Guid("05c5b88d-af8c-407e-d068-08dd15005342") }
                });

            migrationBuilder.InsertData(
                schema: "Study",
                table: "Course",
                columns: new[] { "Id", "CategoryId", "Code", "Cost", "CourseDescription", "CourseLevelId", "CreatedDate", "CreatedUserID", "DeletedDate", "DeletedUserID", "Description", "ISActive", "ImageId", "IsDeleted", "StarsNumber", "TeacherId", "Title" },
                values: new object[,]
                {
                    { new Guid("12f272c9-f198-45c4-a260-08dd37ab6f06"), new Guid("c758ad65-5f5d-43cf-b676-8dac2d2cf948"), 206, 2000000m, "آموزش پیشرفته پایتون برای تحلیل داده، هوش مصنوعی و طراحی سیستم.", 2, new DateTime(2025, 1, 17, 21, 57, 30, 779, DateTimeKind.Local).AddTicks(5615), new Guid("bd53a164-26df-45ab-bf5c-08dd0d797a44"), null, null, null, true, null, false, 5, new Guid("1f262031-5db7-47ae-893d-08dd0d86a8be"), "برنامه‌نویسی پیشرفته با پایتون" },
                    { new Guid("39a2b245-8188-4b47-b508-08dd37ab7f09"), new Guid("c758ad65-5f5d-43cf-b676-8dac2d2cf948"), 216, 2500000m, "آموزش ساخت برنامه‌های تحت وب بااستفاده از ASP.NETCore.", 2, new DateTime(2025, 1, 17, 21, 57, 30, 779, DateTimeKind.Local).AddTicks(5722), new Guid("05c5b88d-af8c-407e-d068-08dd15005342"), null, null, null, true, null, false, 5, new Guid("486c341e-03d9-4616-242e-08dd2592d1dd"), "توسعه وب ASP.NET Core" },
                    { new Guid("42d99c9a-7d35-4a45-a256-08dd37ab6f02"), new Guid("a654d03d-4e58-47fb-b70c-5e9433677052"), 202, 800000m, "آشنایی با مفاهیم پایه‌ای فیزیک و حل مسائل کاربردی.", 1, new DateTime(2025, 1, 17, 21, 57, 30, 779, DateTimeKind.Local).AddTicks(5591), new Guid("9ceea18b-7117-4059-805c-08dd0d8a09bd"), null, null, null, true, null, false, 5, new Guid("2603e63f-9b46-4807-72be-08dd0d8f6f8f"), "فیزیک عمومی 1" },
                    { new Guid("5f2b414d-63ec-4d3b-bfd3-08dd37aa0f43"), new Guid("c758ad65-5f5d-43cf-b676-8dac2d2cf948"), 101, 1200000m, "دوره جامع و پروژه محور سی‌شارپ مناسب برای مبتدی تا پیشرفته.", 1, new DateTime(2025, 1, 17, 21, 57, 30, 779, DateTimeKind.Local).AddTicks(5553), new Guid("bd53a164-26df-45ab-bf5c-08dd0d797a44"), null, null, null, true, null, false, 5, new Guid("1f262031-5db7-47ae-893d-08dd0d86a8be"), "آموزش برنامه‌نویسی سی‌شارپ" },
                    { new Guid("6d9c7e02-56c7-4a77-b506-08dd37ab7f07"), new Guid("7dbb7444-f7a7-46d7-aa82-d35f70b2165d"), 214, 1700000m, "آشنایی با تکنیک‌ها و ابزارهای مدیریت پروژه‌های نرم‌افزاری.", 2, new DateTime(2025, 1, 17, 21, 57, 30, 779, DateTimeKind.Local).AddTicks(5710), new Guid("bd53a164-26df-45ab-bf5c-08dd0d797a44"), null, null, null, true, null, false, 5, new Guid("1f262031-5db7-47ae-893d-08dd0d86a8be"), "مدیریت پروژه‌های نرم‌افزاری" },
                    { new Guid("71b3bede-4e8e-4207-a7d4-08dd37aa0f45"), new Guid("a654d03d-4e58-47fb-b70c-5e9433677052"), 103, 800000m, "دوره ویژه یادگیری زبان انگلیسی از سطح پایه با استفاده از روش‌های کاربردی.", 1, new DateTime(2025, 1, 17, 21, 57, 30, 779, DateTimeKind.Local).AddTicks(5567), new Guid("05c5b88d-af8c-407e-d068-08dd15005342"), null, null, null, true, null, false, 5, new Guid("55a3337f-cfa5-4440-242a-08dd2592d1dd"), "آموزش زبان  برای مبتدیان" },
                    { new Guid("7f6f6aab-c44f-4d30-a257-08dd37ab6f03"), new Guid("3cfad89a-7c7b-497e-acd6-9bfc97d48a9b"), 203, 1000000m, "یادگیری مفاهیم آمار و احتمالات برای حل مسائل مهندسی.", 2, new DateTime(2025, 1, 17, 21, 57, 30, 779, DateTimeKind.Local).AddTicks(5597), new Guid("05c5b88d-af8c-407e-d068-08dd15005342"), null, null, null, true, null, false, 5, new Guid("55a3337f-cfa5-4440-242a-08dd2592d1dd"), "آمار و احتمالات مهندسی" },
                    { new Guid("876a3131-1dc9-4a21-b509-08dd37ab7f10"), new Guid("7dbb7444-f7a7-46d7-aa82-d35f70b2165d"), 217, 1800000m, "یادگیری اصول و تکنیک‌های پایه‌ای هوش مصنوعی.", 1, new DateTime(2025, 1, 17, 21, 57, 30, 779, DateTimeKind.Local).AddTicks(5728), new Guid("bd53a164-26df-45ab-bf5c-08dd0d797a44"), null, null, null, true, null, false, 4, new Guid("1f262031-5db7-47ae-893d-08dd0d86a8be"), "آموزش مقدماتی هوش مصنوعی" },
                    { new Guid("89e4b1db-9b95-4fa8-a261-08dd37ab6f07"), new Guid("463044b4-343f-4101-b2a3-73012d059ac9"), 207, 1800000m, "آشنایی با ابزارها و تکنیک‌های طراحی سه‌بعدی در نرم‌افزار Blender.", 2, new DateTime(2025, 1, 17, 21, 57, 30, 779, DateTimeKind.Local).AddTicks(5661), new Guid("05c5b88d-af8c-407e-d068-08dd15005342"), null, null, null, true, null, false, 4, new Guid("486c341e-03d9-4616-242e-08dd2592d1dd"), "طراحی و مدل‌سازی  با Blender" },
                    { new Guid("9d7f57a8-26d1-4b9f-a255-08dd37ab6f01"), new Guid("c758ad65-5f5d-43cf-b676-8dac2d2cf948"), 201, 500000m, "دوره‌ای مناسب برای آشنایی با اصول اولیه ریاضیات پایه و کاربردهای آن.", 1, new DateTime(2025, 1, 17, 21, 57, 30, 779, DateTimeKind.Local).AddTicks(5586), new Guid("bd53a164-26df-45ab-bf5c-08dd0d797a44"), null, null, null, true, null, false, 4, new Guid("1f262031-5db7-47ae-893d-08dd0d86a8be"), "مبانی ریاضیات پایه" },
                    { new Guid("a12c08e7-8827-4912-b502-08dd37ab7f03"), new Guid("3cfad89a-7c7b-497e-acd6-9bfc97d48a9b"), 210, 1500000m, "آموزش تحلیل داده‌های سازمانی با استفاده از زبان SQL.", 2, new DateTime(2025, 1, 17, 21, 57, 30, 779, DateTimeKind.Local).AddTicks(5684), new Guid("bd53a164-26df-45ab-bf5c-08dd0d797a44"), null, null, null, true, null, false, 5, new Guid("1f262031-5db7-47ae-893d-08dd0d86a8be"), "تحلیل داده با SQL" },
                    { new Guid("ab3e4a26-9e2f-46fa-b510-08dd37ab7f11"), new Guid("c758ad65-5f5d-43cf-b676-8dac2d2cf948"), 218, 2000000m, "آموزش مفاهیم شیءگرایی و پیاده‌سازی آن با زبان C#.", 2, new DateTime(2025, 1, 17, 21, 57, 30, 779, DateTimeKind.Local).AddTicks(5734), new Guid("05c5b88d-af8c-407e-d068-08dd15005342"), null, null, null, true, null, false, 5, new Guid("486c341e-03d9-4616-242e-08dd2592d1dd"), "برنامه‌نویسی شیءگرا با C#" },
                    { new Guid("af8d7e39-0f8f-42b9-b1c3-08dd37aa0f44"), new Guid("7dbb7444-f7a7-46d7-aa82-d35f70b2165d"), 102, 1500000m, "آشنایی با اصول مدیریت مالی و تکنیک‌های سرمایه‌گذاری در بازار.", 2, new DateTime(2025, 1, 17, 21, 57, 30, 779, DateTimeKind.Local).AddTicks(5561), new Guid("9ceea18b-7117-4059-805c-08dd0d8a09bd"), null, null, null, true, null, false, 4, new Guid("2603e63f-9b46-4807-72be-08dd0d8f6f8f"), "مدیریت مالی و سرمایه‌گذاری" },
                    { new Guid("b3e0b271-f8e0-4b3a-a7e5-08dd37aa0f46"), new Guid("463044b4-343f-4101-b2a3-73012d059ac9"), 104, 900000m, "آشنایی با اصول طراحی و نقاشی برای هنرجویان مبتدی.", 1, new DateTime(2025, 1, 17, 21, 57, 30, 779, DateTimeKind.Local).AddTicks(5573), new Guid("05c5b88d-af8c-407e-d068-08dd15005342"), null, null, null, true, null, false, 4, new Guid("486c341e-03d9-4616-242e-08dd2592d1dd"), "مبانی هنر و طراحی" },
                    { new Guid("b8c1131e-c817-44ea-a258-08dd37ab6f04"), new Guid("7dbb7444-f7a7-46d7-aa82-d35f70b2165d"), 204, 1500000m, "آشنایی با اصول بازاریابی در دنیای دیجیتال و راه‌های جذب مشتری.", 1, new DateTime(2025, 1, 17, 21, 57, 30, 779, DateTimeKind.Local).AddTicks(5603), new Guid("bd53a164-26df-45ab-bf5c-08dd0d797a44"), null, null, null, true, null, false, 5, new Guid("1f262031-5db7-47ae-893d-08dd0d86a8be"), "اصول بازاریابی دیجیتال" },
                    { new Guid("bf3ea476-bc8f-4572-b504-08dd37ab7f05"), new Guid("a654d03d-4e58-47fb-b70c-5e9433677052"), 212, 800000m, "یادگیری اصول پایه‌ای مدارهای الکترونیکی و کاربردهای آن‌ها.", 1, new DateTime(2025, 1, 17, 21, 57, 30, 779, DateTimeKind.Local).AddTicks(5697), new Guid("05c5b88d-af8c-407e-d068-08dd15005342"), null, null, null, true, null, false, 4, new Guid("55a3337f-cfa5-4440-242a-08dd2592d1dd"), "مبانی برق و الکترونیک" },
                    { new Guid("c1e3b450-628f-4a43-b7e3-08dd37aa0f47"), new Guid("3cfad89a-7c7b-497e-acd6-9bfc97d48a9b"), 105, 2000000m, "دوره تخصصی برای یادگیری اصول هوش مصنوعی و پیاده‌سازی الگوریتم‌های یادگیری ماشین.", 3, new DateTime(2025, 1, 17, 21, 57, 30, 779, DateTimeKind.Local).AddTicks(5579), new Guid("bd53a164-26df-45ab-bf5c-08dd0d797a44"), null, null, null, true, null, false, 5, new Guid("1f262031-5db7-47ae-893d-08dd0d86a8be"), "هوش مصنوعی و یادگیری ماشین" },
                    { new Guid("c7f3d234-9fc3-453a-b500-08dd37ab7f01"), new Guid("c758ad65-5f5d-43cf-b676-8dac2d2cf948"), 208, 900000m, "آموزش مفاهیم اولیه برنامه‌نویسی با زبان جاوا برای مبتدیان.", 1, new DateTime(2025, 1, 17, 21, 57, 30, 779, DateTimeKind.Local).AddTicks(5673), new Guid("9ceea18b-7117-4059-805c-08dd0d8a09bd"), null, null, null, true, null, false, 4, new Guid("2603e63f-9b46-4807-72be-08dd0d8f6f8f"), "آموزش مقدماتی زبان جاوا" },
                    { new Guid("d52d29fb-80da-40b0-a259-08dd37ab6f05"), new Guid("463044b4-343f-4101-b2a3-73012d059ac9"), 205, 1200000m, "دوره‌ای جامع برای یادگیری طراحی صفحات وب با HTML و CSS.", 1, new DateTime(2025, 1, 17, 21, 57, 30, 779, DateTimeKind.Local).AddTicks(5609), new Guid("05c5b88d-af8c-407e-d068-08dd15005342"), null, null, null, true, null, false, 4, new Guid("486c341e-03d9-4616-242e-08dd2592d1dd"), "طراحی وب با HTML و CSS" },
                    { new Guid("d75d8d12-fdf9-45c8-b503-08dd37ab7f04"), new Guid("7dbb7444-f7a7-46d7-aa82-d35f70b2165d"), 211, 2500000m, "آموزش مفاهیم پایه‌ای یادگیری ماشین و الگوریتم‌های آن.", 1, new DateTime(2025, 1, 17, 21, 57, 30, 779, DateTimeKind.Local).AddTicks(5690), new Guid("9ceea18b-7117-4059-805c-08dd0d8a09bd"), null, null, null, true, null, false, 5, new Guid("2603e63f-9b46-4807-72be-08dd0d8f6f8f"), "یادگیری ماشین برای مبتدیان" },
                    { new Guid("ef123b19-3b99-4c24-b507-08dd37ab7f08"), new Guid("463044b4-343f-4101-b2a3-73012d059ac9"), 215, 1200000m, "آموزش طراحی رابط کاربری زیبا و کاربردی با ابزارهای مدرن.", 1, new DateTime(2025, 1, 17, 21, 57, 30, 779, DateTimeKind.Local).AddTicks(5716), new Guid("9ceea18b-7117-4059-805c-08dd0d8a09bd"), null, null, null, true, null, false, 4, new Guid("2603e63f-9b46-4807-72be-08dd0d8f6f8f"), "طراحی رابط کاربری (UI)" },
                    { new Guid("f3e321eb-94d8-4b8d-b505-08dd37ab7f06"), new Guid("c758ad65-5f5d-43cf-b676-8dac2d2cf948"), 213, 2200000m, "آموزش ساخت اپلیکیشن‌های موبایل برای اندروید و iOS با Flutter.", 2, new DateTime(2025, 1, 17, 21, 57, 30, 779, DateTimeKind.Local).AddTicks(5704), new Guid("05c5b88d-af8c-407e-d068-08dd15005342"), null, null, null, true, null, false, 5, new Guid("486c341e-03d9-4616-242e-08dd2592d1dd"), "توسعه اپلیکیشن‌های موبایل با Flutter" },
                    { new Guid("f9ad1d79-7325-497e-b501-08dd37ab7f02"), new Guid("463044b4-343f-4101-b2a3-73012d059ac9"), 209, 1100000m, "آشنایی با اصول پایه شبکه‌های کامپیوتری و پروتکل‌های ارتباطی.", 1, new DateTime(2025, 1, 17, 21, 57, 30, 779, DateTimeKind.Local).AddTicks(5679), new Guid("05c5b88d-af8c-407e-d068-08dd15005342"), null, null, null, true, null, false, 5, new Guid("486c341e-03d9-4616-242e-08dd2592d1dd"), "اصول شبکه‌های کامپیوتری" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_ImageId",
                table: "AspNetUsers",
                column: "ImageId");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Course_CategoryId",
                schema: "Study",
                table: "Course",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Course_ImageId",
                schema: "Study",
                table: "Course",
                column: "ImageId");

            migrationBuilder.CreateIndex(
                name: "IX_Course_TeacherId",
                schema: "Study",
                table: "Course",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_CoursesStudent_StudentsId",
                table: "CoursesStudent",
                column: "StudentsId");

            migrationBuilder.CreateIndex(
                name: "IX_EmailLogs_SentByUserId",
                table: "EmailLogs",
                column: "SentByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Episodes_SeasonId",
                table: "Episodes",
                column: "SeasonId");

            migrationBuilder.CreateIndex(
                name: "IX_Season_CourseId",
                schema: "Study",
                table: "Season",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Student_UserId",
                schema: "BasicInfo",
                table: "Student",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Teacher_UserId",
                schema: "BasicInfo",
                table: "Teacher",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_TeacherRequests_UserId",
                table: "TeacherRequests",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Views_UserId",
                schema: "Study",
                table: "Views",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "CoursesStudent");

            migrationBuilder.DropTable(
                name: "EmailLogs");

            migrationBuilder.DropTable(
                name: "EmailSetting");

            migrationBuilder.DropTable(
                name: "Episodes");

            migrationBuilder.DropTable(
                name: "ErrorLog",
                schema: "System");

            migrationBuilder.DropTable(
                name: "Otps");

            migrationBuilder.DropTable(
                name: "TeacherRequests");

            migrationBuilder.DropTable(
                name: "Views",
                schema: "Study");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Student",
                schema: "BasicInfo");

            migrationBuilder.DropTable(
                name: "Season",
                schema: "Study");

            migrationBuilder.DropTable(
                name: "Course",
                schema: "Study");

            migrationBuilder.DropTable(
                name: "Category",
                schema: "BasicInfo");

            migrationBuilder.DropTable(
                name: "Teacher",
                schema: "BasicInfo");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Image",
                schema: "BasicInfo");
        }
    }
}
