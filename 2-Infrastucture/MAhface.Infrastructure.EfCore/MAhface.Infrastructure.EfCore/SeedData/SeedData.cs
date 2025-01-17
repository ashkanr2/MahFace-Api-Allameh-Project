using MAhface.Domain.Core.Entities.BasicInfo.Accounting;
using MAhface.Domain.Core.Entities.BasicInfo.Business;
using MAhface.Domain.Core.Entities.Study.Course;
using MAhface.Domain.Core.Entities.Study.Season;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAhface.Infrastructure.EfCore.SeedData
{


    public static class SeedData
    {
        #region Categories
        public static IEnumerable<Category> GetCategories()
        {
            return new List<Category>
        {
            new Category
            {
                Id = Guid.Parse("4a6ef880-e352-49dc-0976-08dd0d886873"),
                Title = "تستی",
                Description = "string",
                ParentCategoryId = null,
                OrderNo = 0,
                CreatedUserID = Guid.Parse("85f9967b-1011-40c0-a32e-87370b013966"),
                CreatedDate = DateTime.Now ,
                ISActive = true,
                IsDeleted = false
            },
            new Category
            {
                Id = Guid.Parse("13dc2597-a7a3-482e-b54a-23e83d2ab18b"),
                Title = "دانشگاهی علوم پایه پزشکی",
                Description = "",
                ParentCategoryId = null,
                OrderNo = 7,
                CreatedUserID = Guid.Parse("85f9967b-1011-40c0-a32e-87370b013966"),
                CreatedDate = DateTime.Now ,
                ISActive = true,
                IsDeleted = false
            },
            new Category
            {
                Id = Guid.Parse("a654d03d-4e58-47fb-b70c-5e9433677052"),
                Title = "زبان های خارجی",
                Description = "",
                ParentCategoryId = null,
                OrderNo = 3,
                CreatedUserID = Guid.Parse("85f9967b-1011-40c0-a32e-87370b013966"),
                CreatedDate = DateTime.Now,
                ISActive = true,
                IsDeleted = false
            },
            new Category
            {
                Id = Guid.Parse("463044b4-343f-4101-b2a3-73012d059ac9"),
                Title = "هنر",
                Description = "",
                ParentCategoryId = null,
                OrderNo = 9,
                CreatedUserID = Guid.Parse("85f9967b-1011-40c0-a32e-87370b013966"),
                CreatedDate = DateTime.Now,
                ISActive = true,
                IsDeleted = false
            },
            new Category
            {
                Id = Guid.Parse("c758ad65-5f5d-43cf-b676-8dac2d2cf948"),
                Title = "برنامه نویسی",
                Description = "",
                ParentCategoryId = null,
                OrderNo = 1,
                CreatedUserID = Guid.Parse("85f9967b-1011-40c0-a32e-87370b013966"),
                CreatedDate = DateTime.Now,
                ISActive = true,
                IsDeleted = false
            },
            new Category
            {
                Id = Guid.Parse("35f3bf57-7f05-41a7-8ecb-9b48bcd52fa7"),
                Title = "دانشگاهی فنی و مهندسی",
                Description = "",
                ParentCategoryId = null,
                OrderNo = 6,
                CreatedUserID = Guid.Parse("85f9967b-1011-40c0-a32e-87370b013966"),
                CreatedDate = DateTime.Now,
                ISActive = true,
                IsDeleted = false
            },
            new Category
            {
                Id = Guid.Parse("3cfad89a-7c7b-497e-acd6-9bfc97d48a9b"),
                Title = "آی تی  و نرم افزار",
                Description = "",
                ParentCategoryId = null,
                OrderNo = 2,
                CreatedUserID = Guid.Parse("85f9967b-1011-40c0-a32e-87370b013966"),
                CreatedDate = DateTime.Now,
                ISActive = true,
                IsDeleted = false
            },
            new Category
            {
                Id = Guid.Parse("7dbb7444-f7a7-46d7-aa82-d35f70b2165d"),
                Title = "مالی و سرمایه گذاری",
                Description = "",
                ParentCategoryId = null,
                OrderNo = 5,
                CreatedUserID = Guid.Parse("85f9967b-1011-40c0-a32e-87370b013966"),
                CreatedDate = DateTime.Now,
                ISActive = true,
                IsDeleted = false
            },
            new Category
            {
                Id = Guid.Parse("75f6493f-813e-4d97-a0ea-e4203b90f436"),
                Title = "علوم پایه",
                Description = "",
                ParentCategoryId = null,
                OrderNo = 8,
                CreatedUserID = Guid.Parse("85f9967b-1011-40c0-a32e-87370b013966"),
                CreatedDate = DateTime.Now,
                ISActive = true,
                IsDeleted = false
            },
            new Category
            {
                Id = Guid.Parse("a2a57c78-7043-42e3-a156-ea5ad99fc083"),
                Title = "مدیریت و کسب وکار",
                Description = "",
                ParentCategoryId = null,
                OrderNo = 4,
                CreatedUserID = Guid.Parse("85f9967b-1011-40c0-a32e-87370b013966"),
                CreatedDate = DateTime.Now,
                ISActive = true,
                IsDeleted = false
            }
        };
        }

        #endregion

        #region Users
        public static IEnumerable<User> GetUsers()
        {

            return new List<User>
            {
                new User
                {
                    Id = Guid.Parse("bd53a164-26df-45ab-bf5c-08dd0d797a44"),
                    Firstname = "Ashkan",
                    LastName = "Teacher",
                    BirthDate = new DateTime(2002, 11, 25, 17, 47, 55, 494),
                    NationalCode = "1234567890",
                    IsSystemAccount = false,
                    IsSystemAdmin = false,
                    IsStudent = false,
                    IsTeacher = true,
                    IsDeleted = false,
                    IsActived = false,
                    Email = "AshkanTeacher@gmail.com",
                    PhoneNumber = "09123655654",
                    Image = null,
                    ProfileImageId = null
                },
                new User
                {
                    Id = Guid.Parse("9ceea18b-7117-4059-805c-08dd0d8a09bd"),
                    Firstname = "جادی",
                    LastName = "میر میرانی",
                    BirthDate = new DateTime(2024, 11, 25, 19, 32, 45, 25),
                    NationalCode = "1234567891",
                    IsSystemAccount = false,
                    IsSystemAdmin = false,
                    IsStudent = false,
                    IsTeacher = true,
                    IsDeleted = false,
                    IsActived = false,
                    Email = "jadi@gmail.com",
                    PhoneNumber = "09121236547",
                    Image = null,
                    ProfileImageId = null
                },
                new User
                {
                    Id = Guid.Parse("d5c19e8c-d8da-421c-a82c-08dd12f8ba89"),
                    Firstname = "وحید",
                    LastName = "2جعفری",
                    BirthDate = new DateTime(2002, 11, 2, 17, 41, 12, 121),
                    NationalCode = "",
                    IsSystemAccount = false,
                    IsSystemAdmin = false,
                    IsStudent = false,
                    IsTeacher = true,
                    IsDeleted = false,
                    IsActived = false,
                    Email = "vahidJF@gmail.com",
                    PhoneNumber = "09129129120",
                    Image = null,
                    ProfileImageId = null
                },
                new User
                {
                    Id = Guid.Parse("05c5b88d-af8c-407e-d068-08dd15005342"),
                    Firstname = "string",
                    LastName = "string",
                    BirthDate = new DateTime(2024, 12, 5, 7, 42, 7, 242),
                    NationalCode = "string",
                    IsSystemAccount = false,
                    IsSystemAdmin = false,
                    IsStudent = false,
                    IsTeacher = true,
                    IsDeleted = false,
                    IsActived = false,
                    Email = "string",
                    PhoneNumber = "string",
                    Image = null,
                    ProfileImageId = null
                },
                new User
                {
                    Id = Guid.Parse("e2caf058-47c5-4c10-3fc6-08dd1604c009"),
                    Firstname = "sopo",
                    LastName = "saffari",
                    BirthDate = new DateTime(2024, 12, 6, 14, 45, 29, 103),
                    NationalCode = "002510174",
                    IsSystemAccount = false,
                    IsSystemAdmin = false,
                    IsStudent = true,
                    IsTeacher = false,
                    IsDeleted = false,
                    IsActived = false,
                    Email = "sobhandanger81@gmail.com",
                    PhoneNumber = "09917358742",
                    Image = null,
                    ProfileImageId = null
                },
                new User
                {
                    Id = Guid.Parse("81e27342-10ef-4faf-74ca-08dd1ad120c3"),
                    Firstname = "sobhan",
                    LastName = "saffari",
                    BirthDate = new DateTime(2004, 12, 12, 17, 22, 1, 253),
                    NationalCode = "0005654789",
                    IsSystemAccount = false,
                    IsSystemAdmin = false,
                    IsStudent = false,
                    IsTeacher = true,
                    IsDeleted = false,
                    IsActived = false,
                    Email = "u@gmail.com",
                    PhoneNumber = "09121940087",
                    Image = null,
                    ProfileImageId = null
                },
                new User
                {
                    Id = Guid.Parse("282a7f03-1dca-4d15-b706-08dd20626fc4"),
                    Firstname = "test email",
                    LastName = "ashkan",
                    BirthDate = new DateTime(2024, 12, 19, 19, 21, 28, 118),
                    NationalCode = "1215",
                    IsSystemAccount = false,
                    IsSystemAdmin = false,
                    IsStudent = true,
                    IsTeacher = false,
                    IsDeleted = false,
                    IsActived = false,
                    Email = "razaviash21@gmail.com",
                    PhoneNumber = "0915215",
                    Image = null,
                    ProfileImageId = null
                },
                new User
                {
                    Id = Guid.Parse("9f5dac63-d870-4424-7166-08dd2064841e"),
                    Firstname = "5651",
                    LastName = "hfyhb55",
                    BirthDate = new DateTime(2024, 12, 19, 19, 36, 36, 471),
                    NationalCode = "366551",
                    IsSystemAccount = false,
                    IsSystemAdmin = false,
                    IsStudent = true,
                    IsTeacher = false,
                    IsDeleted = false,
                    IsActived = false,
                    Email = "string@",
                    PhoneNumber = "21521",
                    Image = null,
                    ProfileImageId = null
                },
                new User
                {
                    Id = Guid.Parse("b373c277-e096-465f-a7e2-08dd33ff4451"),
                    Firstname = "ابوالفضل",
                    LastName = " وفادوست",
                    BirthDate = new DateTime(2000, 1, 18, 18, 21, 33, 105),
                    NationalCode = "1234567891",
                    IsSystemAccount = false,
                    IsSystemAdmin = false,
                    IsStudent = true,
                    IsTeacher = false,
                    IsDeleted = false,
                    IsActived = false,
                    Email = "abolfazlVafaDost@gmail.com",
                    PhoneNumber = "09121234123",
                    Image = null,
                    ProfileImageId = null
                },
                new User
                {
                    Id = Guid.Parse("c13acae2-6d50-47cf-f711-08dd347f841d"),
                    Firstname = "s",
                    LastName = "2",
                    BirthDate = new DateTime(2025, 1, 14, 9, 39, 55, 273),
                    NationalCode = "b",
                    IsSystemAccount = false,
                    IsSystemAdmin = false,
                    IsStudent = true,
                    IsTeacher = false,
                    IsDeleted = false,
                    IsActived = false,
                    Email = "s",
                    PhoneNumber = "f",
                    Image = null,
                    ProfileImageId = null
                },
                new User
                {
                    Id = Guid.Parse("85f9967b-1011-40c0-a32e-87370b013966"),
                    Firstname = "Admin",
                    LastName = "Admini",
                    BirthDate = new DateTime(2002, 11, 25, 17, 47, 55, 494),
                    NationalCode = "1234567890",
                    IsSystemAccount = true,
                    IsSystemAdmin = true,
                    IsStudent = false,
                    IsTeacher = false,
                    IsDeleted = false,
                    IsActived = false,
                    Email = "AshkanTeacher@gmail.com",
                    PhoneNumber = "09123655654",
                    Image = null,
                    ProfileImageId = null
                }

            };
        }

        #endregion

        #region Teachers    
        public static IEnumerable<Teacher> GetTeachers()
        {
            return new List<Teacher>
    {
        new Teacher
        {
            Id = Guid.Parse("1f262031-5db7-47ae-893d-08dd0d86a8be"),
            UserId = Guid.Parse("bd53a164-26df-45ab-bf5c-08dd0d797a44"),
            Code = 1,
            Description = null,
            CreatedUserID = Guid.NewGuid(),
            CreatedDate = DateTime.Now,
            DeletedUserID = null,
            DeletedDate = null,
            ISActive = true,
            IsDeleted = false
        },
        new Teacher
        {
            Id = Guid.Parse("2603e63f-9b46-4807-72be-08dd0d8f6f8f"),
            UserId = Guid.Parse("9ceea18b-7117-4059-805c-08dd0d8a09bd"),
            Code = 2,
            Description = null,
            CreatedUserID = Guid.NewGuid(),
            CreatedDate = DateTime.Now,
            DeletedUserID = null,
            DeletedDate = null,
            ISActive = true,
            IsDeleted = false
        },
        new Teacher
        {
            Id = Guid.Parse("55a3337f-cfa5-4440-242a-08dd2592d1dd"),
            UserId = Guid.Parse("05c5b88d-af8c-407e-d068-08dd15005342"),
            Code = 3,
            Description = null,
            CreatedUserID = Guid.NewGuid(),
            CreatedDate = DateTime.Now,
            DeletedUserID = null,
            DeletedDate = null,
            ISActive = true,
            IsDeleted = false
        },
        new Teacher
        {
            Id = Guid.Parse("0c7938f9-e881-42fa-242b-08dd2592d1dd"),
            UserId = Guid.Parse("05c5b88d-af8c-407e-d068-08dd15005342"),
            Code = 4,
            Description = null,
            CreatedUserID = Guid.NewGuid(),
            CreatedDate = DateTime.Now,
            DeletedUserID = null,
            DeletedDate = null,
            ISActive = true,
            IsDeleted = false
        },
        new Teacher
        {
            Id = Guid.Parse("3a4086aa-1278-4325-242c-08dd2592d1dd"),
            UserId = Guid.Parse("05c5b88d-af8c-407e-d068-08dd15005342"),
            Code = 5,
            Description = null,
            CreatedUserID = Guid.NewGuid(),
            CreatedDate = DateTime.Now,
            DeletedUserID = null,
            DeletedDate = null,
            ISActive = true,
            IsDeleted = false
        },
        new Teacher
        {
            Id = Guid.Parse("ecf68ade-4b48-4307-242d-08dd2592d1dd"),
            UserId = Guid.Parse("05c5b88d-af8c-407e-d068-08dd15005342"),
            Code = 6,
            Description = null,
            CreatedUserID = Guid.NewGuid(),
            CreatedDate = DateTime.Now,
            DeletedUserID = null,
            DeletedDate = null,
            ISActive = true,
            IsDeleted = false
        },
        new Teacher
        {
            Id = Guid.Parse("486c341e-03d9-4616-242e-08dd2592d1dd"),
            UserId = Guid.Parse("05c5b88d-af8c-407e-d068-08dd15005342"),
            Code = 7,
            Description = null,
            CreatedUserID = Guid.NewGuid(),
            CreatedDate = DateTime.Now,
            DeletedUserID = null,
            DeletedDate = null,
            ISActive = true,
            IsDeleted = false
        }
    };
        }
        #endregion

        #region Courses
        public static IEnumerable<Courses> GetCourses()
        {
            return new List<Courses>
            {
              new Courses
              {
                  Id = Guid.Parse("5f2b414d-63ec-4d3b-bfd3-08dd37aa0f43"),
                  Code = 101,
                  Title = "آموزش برنامه‌نویسی سی‌شارپ",
                  CourseLevelId = 1,
                  StarsNumber = 5,
                  TeacherId = Guid.Parse("1f262031-5db7-47ae-893d-08dd0d86a8be"),
                  CategoryId = Guid.Parse("c758ad65-5f5d-43cf-b676-8dac2d2cf948"), // برنامه‌نویسی
                  CourseDescription = "دوره جامع و پروژه محور سی‌شارپ مناسب برای مبتدی تا پیشرفته.",
                  Cost = 1200000,
                  CreatedUserID = Guid.Parse("bd53a164-26df-45ab-bf5c-08dd0d797a44"),
                  CreatedDate = DateTime.Now,
                  DeletedUserID = null,
                  DeletedDate = null,
                  ISActive = true,
                  IsDeleted = false
              },
              new Courses
              {
                  Id = Guid.Parse("af8d7e39-0f8f-42b9-b1c3-08dd37aa0f44"),
                  Code = 102,
                  Title = "مدیریت مالی و سرمایه‌گذاری",
                  CourseLevelId = 2,
                  StarsNumber = 4,
                  TeacherId = Guid.Parse("2603e63f-9b46-4807-72be-08dd0d8f6f8f"),
                  CategoryId = Guid.Parse("7dbb7444-f7a7-46d7-aa82-d35f70b2165d"), // مالی و سرمایه‌گذاری
                  CourseDescription = "آشنایی با اصول مدیریت مالی و تکنیک‌های سرمایه‌گذاری در بازار.",
                  Cost = 1500000,
                  CreatedUserID = Guid.Parse("9ceea18b-7117-4059-805c-08dd0d8a09bd"),
                  CreatedDate = DateTime.Now,
                  DeletedUserID = null,
                  DeletedDate = null,
                  ISActive = true,
                  IsDeleted = false
              },
              new Courses
              {
                  Id = Guid.Parse("71b3bede-4e8e-4207-a7d4-08dd37aa0f45"),
                  Code = 103,
                  Title = "آموزش زبان  برای مبتدیان",
                  CourseLevelId = 1,
                  StarsNumber = 5,
                  TeacherId = Guid.Parse("55a3337f-cfa5-4440-242a-08dd2592d1dd"),
                  CategoryId = Guid.Parse("a654d03d-4e58-47fb-b70c-5e9433677052"), // زبان‌های خارجی
                  CourseDescription = "دوره ویژه یادگیری زبان انگلیسی از سطح پایه با استفاده از روش‌های کاربردی.",
                  Cost = 800000,
                  CreatedUserID = Guid.Parse("05c5b88d-af8c-407e-d068-08dd15005342"),
                  CreatedDate = DateTime.Now,
                  DeletedUserID = null,
                  DeletedDate = null,
                  ISActive = true,
                  IsDeleted = false
              },
             new Courses
             {
                  Id = Guid.Parse("b3e0b271-f8e0-4b3a-a7e5-08dd37aa0f46"),
                  Code = 104,
                  Title = "مبانی هنر و طراحی",
                  CourseLevelId = 1,
                  StarsNumber = 4,
                  TeacherId = Guid.Parse("486c341e-03d9-4616-242e-08dd2592d1dd"),
                  CategoryId = Guid.Parse("463044b4-343f-4101-b2a3-73012d059ac9"), // هنر
                  CourseDescription = "آشنایی با اصول طراحی و نقاشی برای هنرجویان مبتدی.",
                 Cost = 900000,
                 CreatedUserID = Guid.Parse("05c5b88d-af8c-407e-d068-08dd15005342"),
                 CreatedDate = DateTime.Now,
                 DeletedUserID = null,
                 DeletedDate = null,
                 ISActive = true,
                 IsDeleted = false
             },
             new Courses
             {
                 Id = Guid.Parse("c1e3b450-628f-4a43-b7e3-08dd37aa0f47"),
                 Code = 105,
                 Title = "هوش مصنوعی و یادگیری ماشین",
                 CourseLevelId = 3,
                 StarsNumber = 5,
                 TeacherId = Guid.Parse("1f262031-5db7-47ae-893d-08dd0d86a8be"),
                 CategoryId = Guid.Parse("3cfad89a-7c7b-497e-acd6-9bfc97d48a9b"), // آی‌تی و نرم‌افزار
                 CourseDescription = "دوره تخصصی برای یادگیری اصول هوش مصنوعی و پیاده‌سازی الگوریتم‌های یادگیری ماشین.",
                 Cost = 2000000,
                 CreatedUserID = Guid.Parse("bd53a164-26df-45ab-bf5c-08dd0d797a44"),
                 CreatedDate = DateTime.Now,
                 DeletedUserID = null,
                 DeletedDate = null,
                 ISActive = true,
                 IsDeleted = false
             },
              new Courses
             {
                 Id = Guid.Parse("9d7f57a8-26d1-4b9f-a255-08dd37ab6f01"),
                 Code = 201,
                 Title = "مبانی ریاضیات پایه",
                 CourseLevelId = 1,
                 StarsNumber = 4,
                 TeacherId = Guid.Parse("1f262031-5db7-47ae-893d-08dd0d86a8be"),
                 CategoryId = Guid.Parse("c758ad65-5f5d-43cf-b676-8dac2d2cf948"), // ریاضی
                 CourseDescription = "دوره‌ای مناسب برای آشنایی با اصول اولیه ریاضیات پایه و کاربردهای آن.",
                 Cost = 500000,
                 CreatedUserID = Guid.Parse("bd53a164-26df-45ab-bf5c-08dd0d797a44"),
                 CreatedDate = DateTime.Now,
                 DeletedUserID = null,
                 DeletedDate = null,
                 ISActive = true,
                 IsDeleted = false
             },
             new Courses
             {
                 Id = Guid.Parse("42d99c9a-7d35-4a45-a256-08dd37ab6f02"),
                 Code = 202,
                 Title = "فیزیک عمومی 1",
                 CourseLevelId = 1,
                 StarsNumber = 5,
                 TeacherId = Guid.Parse("2603e63f-9b46-4807-72be-08dd0d8f6f8f"),
                 CategoryId = Guid.Parse("a654d03d-4e58-47fb-b70c-5e9433677052"), // فیزیک
                 CourseDescription = "آشنایی با مفاهیم پایه‌ای فیزیک و حل مسائل کاربردی.",
                 Cost = 800000,
                 CreatedUserID = Guid.Parse("9ceea18b-7117-4059-805c-08dd0d8a09bd"),
                 CreatedDate = DateTime.Now,
                 DeletedUserID = null,
                 DeletedDate = null,
                 ISActive = true,
                 IsDeleted = false
             },
             new Courses
             {
                 Id = Guid.Parse("7f6f6aab-c44f-4d30-a257-08dd37ab6f03"),
                 Code = 203,
                 Title = "آمار و احتمالات مهندسی",
                 CourseLevelId = 2,
                 StarsNumber = 5,
                 TeacherId = Guid.Parse("55a3337f-cfa5-4440-242a-08dd2592d1dd"),
                 CategoryId = Guid.Parse("3cfad89a-7c7b-497e-acd6-9bfc97d48a9b"), // مهندسی
                 CourseDescription = "یادگیری مفاهیم آمار و احتمالات برای حل مسائل مهندسی.",
                 Cost = 1000000,
                 CreatedUserID = Guid.Parse("05c5b88d-af8c-407e-d068-08dd15005342"),
                 CreatedDate = DateTime.Now,
                 DeletedUserID = null,
                 DeletedDate = null,
                 ISActive = true,
                 IsDeleted = false
             },
             new Courses
             {
                 Id = Guid.Parse("b8c1131e-c817-44ea-a258-08dd37ab6f04"),
                 Code = 204,
                 Title = "اصول بازاریابی دیجیتال",
                 CourseLevelId = 1,
                 StarsNumber = 5,
                 TeacherId = Guid.Parse("1f262031-5db7-47ae-893d-08dd0d86a8be"),
                 CategoryId = Guid.Parse("7dbb7444-f7a7-46d7-aa82-d35f70b2165d"), // کسب‌وکار
                 CourseDescription = "آشنایی با اصول بازاریابی در دنیای دیجیتال و راه‌های جذب مشتری.",
                 Cost = 1500000,
                 CreatedUserID = Guid.Parse("bd53a164-26df-45ab-bf5c-08dd0d797a44"),
                 CreatedDate = DateTime.Now,
                 DeletedUserID = null,
                 DeletedDate = null,
                 ISActive = true,
                 IsDeleted = false
             },
             new Courses
             {
                 Id = Guid.Parse("d52d29fb-80da-40b0-a259-08dd37ab6f05"),
                 Code = 205,
                 Title = "طراحی وب با HTML و CSS",
                 CourseLevelId = 1,
                 StarsNumber = 4,
                 TeacherId = Guid.Parse("486c341e-03d9-4616-242e-08dd2592d1dd"),
                 CategoryId = Guid.Parse("463044b4-343f-4101-b2a3-73012d059ac9"), // طراحی وب
                 CourseDescription = "دوره‌ای جامع برای یادگیری طراحی صفحات وب با HTML و CSS.",
                 Cost = 1200000,
                 CreatedUserID = Guid.Parse("05c5b88d-af8c-407e-d068-08dd15005342"),
                 CreatedDate = DateTime.Now,
                 DeletedUserID = null,
                 DeletedDate = null,
                 ISActive = true,
                 IsDeleted = false
             },
             new Courses
             {
                 Id = Guid.Parse("12f272c9-f198-45c4-a260-08dd37ab6f06"),
                 Code = 206,
                 Title = "برنامه‌نویسی پیشرفته با پایتون",
                 CourseLevelId = 2,
                 StarsNumber = 5,
                 TeacherId = Guid.Parse("1f262031-5db7-47ae-893d-08dd0d86a8be"),
                 CategoryId = Guid.Parse("c758ad65-5f5d-43cf-b676-8dac2d2cf948"), // برنامه‌نویسی
                 CourseDescription = "آموزش پیشرفته پایتون برای تحلیل داده، هوش مصنوعی و طراحی سیستم.",
                 Cost = 2000000,
                 CreatedUserID = Guid.Parse("bd53a164-26df-45ab-bf5c-08dd0d797a44"),
                 CreatedDate = DateTime.Now,
                 DeletedUserID = null,
                 DeletedDate = null,
                 ISActive = true,
                 IsDeleted = false
             },
             new Courses
             {
                 Id = Guid.Parse("89e4b1db-9b95-4fa8-a261-08dd37ab6f07"),
                 Code = 207,
                 Title = "طراحی و مدل‌سازی سه‌بعدی با Blender",
                 CourseLevelId = 2,
                 StarsNumber = 4,
                 TeacherId = Guid.Parse("486c341e-03d9-4616-242e-08dd2592d1dd"),
                 CategoryId = Guid.Parse("463044b4-343f-4101-b2a3-73012d059ac9"), // طراحی گرافیکی
                 CourseDescription = "آشنایی با ابزارها و تکنیک‌های طراحی سه‌بعدی در نرم‌افزار Blender.",
                 Cost = 1800000,
                 CreatedUserID = Guid.Parse("05c5b88d-af8c-407e-d068-08dd15005342"),
                 CreatedDate = DateTime.Now,
                 DeletedUserID = null,
                 DeletedDate = null,
                 ISActive = true,
                 IsDeleted = false
             },
             new Courses
             {
                 Id = Guid.Parse("c7f3d234-9fc3-453a-b500-08dd37ab7f01"),
                 Code = 208,
                 Title = "آموزش مقدماتی زبان جاوا",
                 CourseLevelId = 1,
                 StarsNumber = 4,
                 TeacherId = Guid.Parse("2603e63f-9b46-4807-72be-08dd0d8f6f8f"),
                 CategoryId = Guid.Parse("c758ad65-5f5d-43cf-b676-8dac2d2cf948"), // برنامه‌نویسی
                 CourseDescription = "آموزش مفاهیم اولیه برنامه‌نویسی با زبان جاوا برای مبتدیان.",
                 Cost = 900000,
                 CreatedUserID = Guid.Parse("9ceea18b-7117-4059-805c-08dd0d8a09bd"),
                 CreatedDate = DateTime.Now,
                 DeletedUserID = null,
                 DeletedDate = null,
                 ISActive = true,
                 IsDeleted = false
             },
             new Courses
             {
                 Id = Guid.Parse("f9ad1d79-7325-497e-b501-08dd37ab7f02"),
                 Code = 209,
                 Title = "اصول شبکه‌های کامپیوتری",
                 CourseLevelId = 1,
                 StarsNumber = 5,
                 TeacherId = Guid.Parse("486c341e-03d9-4616-242e-08dd2592d1dd"),
                 CategoryId = Guid.Parse("463044b4-343f-4101-b2a3-73012d059ac9"), // شبکه
                 CourseDescription = "آشنایی با اصول پایه شبکه‌های کامپیوتری و پروتکل‌های ارتباطی.",
                 Cost = 1100000,
                 CreatedUserID = Guid.Parse("05c5b88d-af8c-407e-d068-08dd15005342"),
                 CreatedDate = DateTime.Now,
                 DeletedUserID = null,
                 DeletedDate = null,
                 ISActive = true,
                 IsDeleted = false
             },
             new Courses
             {
                 Id = Guid.Parse("a12c08e7-8827-4912-b502-08dd37ab7f03"),
                 Code = 210,
                 Title = "تحلیل داده با SQL",
                 CourseLevelId = 2,
                 StarsNumber = 5,
                 TeacherId = Guid.Parse("1f262031-5db7-47ae-893d-08dd0d86a8be"),
                 CategoryId = Guid.Parse("3cfad89a-7c7b-497e-acd6-9bfc97d48a9b"), // تحلیل داده
                 CourseDescription = "آموزش تحلیل داده‌های سازمانی با استفاده از زبان SQL.",
                 Cost = 1500000,
                 CreatedUserID = Guid.Parse("bd53a164-26df-45ab-bf5c-08dd0d797a44"),
                 CreatedDate = DateTime.Now,
                 DeletedUserID = null,
                 DeletedDate = null,
                 ISActive = true,
                 IsDeleted = false
             },
             new Courses
             {
                 Id = Guid.Parse("d75d8d12-fdf9-45c8-b503-08dd37ab7f04"),
                 Code = 211,
                 Title = "یادگیری ماشین برای مبتدیان",
                 CourseLevelId = 1,
                 StarsNumber = 5,
                 TeacherId = Guid.Parse("2603e63f-9b46-4807-72be-08dd0d8f6f8f"),
                 CategoryId = Guid.Parse("7dbb7444-f7a7-46d7-aa82-d35f70b2165d"), // هوش مصنوعی
                 CourseDescription = "آموزش مفاهیم پایه‌ای یادگیری ماشین و الگوریتم‌های آن.",
                 Cost = 2500000,
                 CreatedUserID = Guid.Parse("9ceea18b-7117-4059-805c-08dd0d8a09bd"),
                 CreatedDate = DateTime.Now,
                 DeletedUserID = null,
                 DeletedDate = null,
                 ISActive = true,
                 IsDeleted = false
             },
             new Courses
             {
                 Id = Guid.Parse("bf3ea476-bc8f-4572-b504-08dd37ab7f05"),
                 Code = 212,
                 Title = "مبانی برق و الکترونیک",
                 CourseLevelId = 1,
                 StarsNumber = 4,
                 TeacherId = Guid.Parse("55a3337f-cfa5-4440-242a-08dd2592d1dd"),
                 CategoryId = Guid.Parse("a654d03d-4e58-47fb-b70c-5e9433677052"), // برق و الکترونیک
                 CourseDescription = "یادگیری اصول پایه‌ای مدارهای الکترونیکی و کاربردهای آن‌ها.",
                 Cost = 800000,
                 CreatedUserID = Guid.Parse("05c5b88d-af8c-407e-d068-08dd15005342"),
                 CreatedDate = DateTime.Now,
                 DeletedUserID = null,
                 DeletedDate = null,
                 ISActive = true,
                 IsDeleted = false
             },
             new Courses
             {
                 Id = Guid.Parse("f3e321eb-94d8-4b8d-b505-08dd37ab7f06"),
                 Code = 213,
                 Title = "توسعه اپلیکیشن‌های موبایل با Flutter",
                 CourseLevelId = 2,
                 StarsNumber = 5,
                 TeacherId = Guid.Parse("486c341e-03d9-4616-242e-08dd2592d1dd"),
                 CategoryId = Guid.Parse("c758ad65-5f5d-43cf-b676-8dac2d2cf948"), // برنامه‌نویسی موبایل
                 CourseDescription = "آموزش ساخت اپلیکیشن‌های موبایل برای اندروید و iOS با Flutter.",
                 Cost = 2200000,
                 CreatedUserID = Guid.Parse("05c5b88d-af8c-407e-d068-08dd15005342"),
                 CreatedDate = DateTime.Now,
                 DeletedUserID = null,
                 DeletedDate = null,
                 ISActive = true,
                 IsDeleted = false
             },
             new Courses
             {
                 Id = Guid.Parse("6d9c7e02-56c7-4a77-b506-08dd37ab7f07"),
                 Code = 214,
                 Title = "مدیریت پروژه‌های نرم‌افزاری",
                 CourseLevelId = 2,
                 StarsNumber = 5,
                 TeacherId = Guid.Parse("1f262031-5db7-47ae-893d-08dd0d86a8be"),
                 CategoryId = Guid.Parse("7dbb7444-f7a7-46d7-aa82-d35f70b2165d"), // مدیریت پروژه
                 CourseDescription = "آشنایی با تکنیک‌ها و ابزارهای مدیریت پروژه‌های نرم‌افزاری.",
                 Cost = 1700000,
                 CreatedUserID = Guid.Parse("bd53a164-26df-45ab-bf5c-08dd0d797a44"),
                 CreatedDate = DateTime.Now,
                 DeletedUserID = null,
                 DeletedDate = null,
                 ISActive = true,
                 IsDeleted = false
             },
             new Courses
             {
                 Id = Guid.Parse("ef123b19-3b99-4c24-b507-08dd37ab7f08"),
                 Code = 215,
                 Title = "طراحی رابط کاربری (UI)",
                 CourseLevelId = 1,
                 StarsNumber = 4,
                 TeacherId = Guid.Parse("2603e63f-9b46-4807-72be-08dd0d8f6f8f"),
                 CategoryId = Guid.Parse("463044b4-343f-4101-b2a3-73012d059ac9"), // طراحی UI
                 CourseDescription = "آموزش طراحی رابط کاربری زیبا و کاربردی با ابزارهای مدرن.",
                 Cost = 1200000,
                 CreatedUserID = Guid.Parse("9ceea18b-7117-4059-805c-08dd0d8a09bd"),
                 CreatedDate = DateTime.Now,
                 DeletedUserID = null,
                 DeletedDate = null,
                 ISActive = true,
                 IsDeleted = false
             },
             new Courses
             {
                 Id = Guid.Parse("39a2b245-8188-4b47-b508-08dd37ab7f09"),
                 Code = 216,
                 Title = "توسعه وب با ASP.NET Core",
                 CourseLevelId = 2,
                 StarsNumber = 5,
                 TeacherId = Guid.Parse("486c341e-03d9-4616-242e-08dd2592d1dd"),
                 CategoryId = Guid.Parse("c758ad65-5f5d-43cf-b676-8dac2d2cf948"), // توسعه وب
                 CourseDescription = "آموزش ساخت برنامه‌های تحت وب با استفاده از ASP.NET Core.",
                 Cost = 2500000,
                 CreatedUserID = Guid.Parse("05c5b88d-af8c-407e-d068-08dd15005342"),
                 CreatedDate = DateTime.Now,
                 DeletedUserID = null,
                 DeletedDate = null,
                 ISActive = true,
                 IsDeleted = false
             },
             new Courses
             {
                 Id = Guid.Parse("876a3131-1dc9-4a21-b509-08dd37ab7f10"),
                 Code = 217,
                 Title = "آموزش مقدماتی هوش مصنوعی",
                 CourseLevelId = 1,
                 StarsNumber = 4,
                 TeacherId = Guid.Parse("1f262031-5db7-47ae-893d-08dd0d86a8be"),
                 CategoryId = Guid.Parse("7dbb7444-f7a7-46d7-aa82-d35f70b2165d"), // هوش مصنوعی
                 CourseDescription = "یادگیری اصول و تکنیک‌های پایه‌ای هوش مصنوعی.",
                 Cost = 1800000,
                 CreatedUserID = Guid.Parse("bd53a164-26df-45ab-bf5c-08dd0d797a44"),
                 CreatedDate = DateTime.Now,
                 DeletedUserID = null,
                 DeletedDate = null,
                 ISActive = true,
                 IsDeleted = false
             },
             new Courses
             {
                 Id = Guid.Parse("ab3e4a26-9e2f-46fa-b510-08dd37ab7f11"),
                 Code = 218,
                 Title = "برنامه‌نویسی شیءگرا با C#",
                 CourseLevelId = 2,
                 StarsNumber = 5,
                 TeacherId = Guid.Parse("486c341e-03d9-4616-242e-08dd2592d1dd"),
                 CategoryId = Guid.Parse("c758ad65-5f5d-43cf-b676-8dac2d2cf948"), // برنامه‌نویسی
                 CourseDescription = "آموزش مفاهیم شیءگرایی و پیاده‌سازی آن با زبان C#.",
                 Cost = 2000000,
                 CreatedUserID = Guid.Parse("05c5b88d-af8c-407e-d068-08dd15005342"),
                 CreatedDate = DateTime.Now,
                 DeletedUserID = null,
                 DeletedDate = null,
                 ISActive = true,
                 IsDeleted = false
             }
             };

        }

        #endregion

        #region Seasons

        public static IEnumerable<Seasons> GetSeasons()
        {
            return new List<Seasons>
            {
                // Seasons for دوره برنامه نویسی مقدماتی C#
                new Seasons
                {
                    Id = Guid.NewGuid(),
                    Code = 1,
                    CourseId = Guid.Parse("1c905fe9-234a-47e6-9227-08dd122e9e0b"), // شناسه دوره برنامه نویسی مقدماتی C#
                    Title = "فصل اول: آشنایی با زبان C#",
                    SeasonsDescription = "در این فصل به بررسی مقدمات زبان برنامه نویسی C# می‌پردازیم.",
                    CreatedUserID = Guid.Parse("bd53a164-26df-45ab-bf5c-08dd0d797a44"),
                    CreatedDate = DateTime.Now,
                    DeletedUserID = null,
                    DeletedDate = null,
                    ISActive = true,
                    IsDeleted = false
                },
                new Seasons
                {
                    Id = Guid.NewGuid(),
                    Code = 2,
                    CourseId = Guid.Parse("1c905fe9-234a-47e6-9227-08dd122e9e0b"),
                    Title = "فصل دوم: ساختار برنامه‌ها در C#",
                    SeasonsDescription = "این فصل به تحلیل ساختار پروژه‌ها و مدیریت آنها در C# اختصاص دارد.",
                    CreatedUserID = Guid.Parse("bd53a164-26df-45ab-bf5c-08dd0d797a44"),
                    CreatedDate = DateTime.Now,
                    DeletedUserID = null,
                    DeletedDate = null,
                    ISActive = true,
                    IsDeleted = false
                },

                // Seasons for دوره هوش مصنوعی مقدماتی
                new Seasons
                {
                    Id = Guid.NewGuid(),
                    Code = 3,
                    CourseId = Guid.Parse("d3620d5d-b861-45f4-92a3-08dd127b927d"), // شناسه دوره هوش مصنوعی مقدماتی
                    Title = "فصل اول: اصول هوش مصنوعی",
                    SeasonsDescription = "این فصل به معرفی اصول اولیه و تاریخچه هوش مصنوعی می‌پردازد.",
                    CreatedUserID = Guid.Parse("9ceea18b-7117-4059-805c-08dd0d8a09bd"),
                    CreatedDate = DateTime.Now,
                    DeletedUserID = null,
                    DeletedDate = null,
                    ISActive = true,
                    IsDeleted = false
                },
                new Seasons
                {
                    Id = Guid.NewGuid(),
                    Code = 4,
                    CourseId = Guid.Parse("d3620d5d-b861-45f4-92a3-08dd127b927d"),
                    Title = "فصل دوم: الگوریتم‌های ابتدایی هوش مصنوعی",
                    SeasonsDescription = "در این فصل الگوریتم‌های پایه‌ای هوش مصنوعی مورد بررسی قرار می‌گیرند.",
                    CreatedUserID = Guid.Parse("9ceea18b-7117-4059-805c-08dd0d8a09bd"),
                    CreatedDate = DateTime.Now,
                    DeletedUserID = null,
                    DeletedDate = null,
                    ISActive = true,
                    IsDeleted = false
                },

                // Seasons for دوره طراحی وب با HTML
                new Seasons
                {
                    Id = Guid.NewGuid(),
                    Code = 5,
                    CourseId = Guid.Parse("b370c8da-f20e-40d1-bb80-08dd12b49c06"), // شناسه دوره طراحی وب با HTML
                    Title = "فصل اول: اصول طراحی وب با HTML",
                    SeasonsDescription = "در این فصل به مبانی طراحی صفحات وب با استفاده از HTML پرداخته می‌شود.",
                    CreatedUserID = Guid.Parse("d5c19e8c-d8da-421c-a82c-08dd12f8ba89"),
                    CreatedDate = DateTime.Now,
                    DeletedUserID = null,
                    DeletedDate = null,
                    ISActive = true,
                    IsDeleted = false
                },
                new Seasons
                {
                    Id = Guid.NewGuid(),
                    Code = 6,
                    CourseId = Guid.Parse("b370c8da-f20e-40d1-bb80-08dd12b49c06"),
                    Title = "فصل دوم: استفاده از تگ‌ها و ساختار پیشرفته HTML",
                    SeasonsDescription = "در این فصل به بررسی تگ‌های پیشرفته HTML و نحوه ساختاردهی به صفحات وب پرداخته می‌شود.",
                    CreatedUserID = Guid.Parse("d5c19e8c-d8da-421c-a82c-08dd12f8ba89"),
                    CreatedDate = DateTime.Now,
                    DeletedUserID = null,
                    DeletedDate = null,
                    ISActive = true,
                    IsDeleted = false
                },

                // Seasons for دوره طراحی سایت با CSS
                new Seasons
                {
                    Id = Guid.NewGuid(),
                    Code = 7,
                    CourseId = Guid.Parse("9fda7e1e-93be-48f4-bfdd-08dd12b69a1e"), // شناسه دوره طراحی سایت با CSS
                    Title = "فصل اول: معرفی CSS و نحوه استفاده در صفحات وب",
                    SeasonsDescription = "در این فصل به معرفی CSS و نحوه استایل‌دهی به صفحات HTML پرداخته می‌شود.",
                    CreatedUserID = Guid.Parse("05c5b88d-af8c-407e-d068-08dd15005342"),
                    CreatedDate = DateTime.Now,
                    DeletedUserID = null,
                    DeletedDate = null,
                    ISActive = true,
                    IsDeleted = false
                },
                new Seasons
                {
                    Id = Guid.NewGuid(),
                    Code = 8,
                    CourseId = Guid.Parse("9fda7e1e-93be-48f4-bfdd-08dd12b69a1e"),
                    Title = "فصل دوم: استایل‌دهی پیشرفته با CSS",
                    SeasonsDescription = "این فصل به تکنیک‌های پیشرفته در استایل‌دهی با استفاده از CSS می‌پردازد.",
                    CreatedUserID = Guid.Parse("05c5b88d-af8c-407e-d068-08dd15005342"),
                    CreatedDate = DateTime.Now,
                    DeletedUserID = null,
                    DeletedDate = null,
                    ISActive = true,
                    IsDeleted = false
                },

                // Seasons for دوره یادگیری ماشین
                new Seasons
                {
                    Id = Guid.NewGuid(),
                    Code = 9,
                    CourseId = Guid.Parse("f2c787ac-d92b-47e5-8fef-08dd0d9b7d5b"), // شناسه دوره یادگیری ماشین
                    Title = "فصل اول: مفاهیم پایه یادگیری ماشین",
                    SeasonsDescription = "در این فصل با مفاهیم پایه یادگیری ماشین و الگوریتم‌های آن آشنا می‌شویم.",
                    CreatedUserID = Guid.Parse("81e27342-10ef-4faf-74ca-08dd1ad120c3"),
                    CreatedDate = DateTime.Now,
                    DeletedUserID = null,
                    DeletedDate = null,
                    ISActive = true,
                    IsDeleted = false
                },
                new Seasons
                {
                    Id = Guid.NewGuid(),
                    Code = 10,
                    CourseId = Guid.Parse("f2c787ac-d92b-47e5-8fef-08dd0d9b7d5b"),
                    Title = "فصل دوم: استفاده از الگوریتم‌های یادگیری ماشین",
                    SeasonsDescription = "این فصل به پیاده‌سازی الگوریتم‌های مختلف یادگیری ماشین پرداخته می‌شود.",
                    CreatedUserID = Guid.Parse("81e27342-10ef-4faf-74ca-08dd1ad120c3"),
                    CreatedDate = DateTime.Now,
                    DeletedUserID = null,
                    DeletedDate = null,
                    ISActive = true,
                    IsDeleted = false
                },

                // Seasons for دوره بازاریابی دیجیتال
                new Seasons
                {
                    Id = Guid.NewGuid(),
                    Code = 11,
                    CourseId = Guid.Parse("4d8594d4-3495-49d3-84a1-08dd12b69e0f"), // شناسه دوره بازاریابی دیجیتال
                    Title = "فصل اول: مبانی بازاریابی دیجیتال",
                    SeasonsDescription = "در این فصل با اصول اولیه بازاریابی دیجیتال آشنا خواهید شد.",
                    CreatedUserID = Guid.Parse("282a7f03-1dca-4d15-b706-08dd20626fc4"),
                    CreatedDate = DateTime.Now,
                    DeletedUserID = null,
                    DeletedDate = null,
                    ISActive = true,
                    IsDeleted = false
                },
                new Seasons
                {
                    Id = Guid.NewGuid(),
                    Code = 12,
                    CourseId = Guid.Parse("4d8594d4-3495-49d3-84a1-08dd12b69e0f"),
                    Title = "فصل دوم: استراتژی‌های بازاریابی دیجیتال",
                    SeasonsDescription = "این فصل به بررسی استراتژی‌های مختلف در بازاریابی دیجیتال پرداخته می‌شود.",
                    CreatedUserID = Guid.Parse("282a7f03-1dca-4d15-b706-08dd20626fc4"),
                    CreatedDate = DateTime.Now,
                    DeletedUserID = null,
                    DeletedDate = null,
                    ISActive = true,
                    IsDeleted = false
                },
                new Seasons
                {
                    Id = Guid.NewGuid(),
                    Code = 1,
                    CourseId = Guid.Parse("1c905fe9-234a-47e6-9227-08dd122e9e0b"),
                    Title = "فصل اول: آشنایی با زبان C#",
                    SeasonsDescription = "در این فصل به بررسی مقدمات زبان برنامه نویسی C# می‌پردازیم.",
                    CreatedUserID = Guid.Parse("bd53a164-26df-45ab-bf5c-08dd0d797a44"),
                    CreatedDate = DateTime.Now,
                    ISActive = true,
                    IsDeleted = false
                },
                new Seasons
                {
                    Id = Guid.NewGuid(),
                    Code = 2,
                    CourseId = Guid.Parse("1c905fe9-234a-47e6-9227-08dd122e9e0b"),
                    Title = "فصل دوم: ساختار برنامه‌ها در C#",
                    SeasonsDescription = "این فصل به تحلیل ساختار پروژه‌ها و مدیریت آنها در C# اختصاص دارد.",
                    CreatedUserID = Guid.Parse("bd53a164-26df-45ab-bf5c-08dd0d797a44"),
                    CreatedDate = DateTime.Now,
                    ISActive = true,
                    IsDeleted = false
                },

                // دوره هوش مصنوعی مقدماتی
                new Seasons
                {
                    Id = Guid.NewGuid(),
                    Code = 3,
                    CourseId = Guid.Parse("d3620d5d-b861-45f4-92a3-08dd127b927d"),
                    Title = "فصل اول: اصول هوش مصنوعی",
                    SeasonsDescription = "این فصل به معرفی اصول اولیه و تاریخچه هوش مصنوعی می‌پردازد.",
                    CreatedUserID = Guid.Parse("9ceea18b-7117-4059-805c-08dd0d8a09bd"),
                    CreatedDate = DateTime.Now,
                    ISActive = true,
                    IsDeleted = false
                },
                new Seasons
                {
                    Id = Guid.NewGuid(),
                    Code = 4,
                    CourseId = Guid.Parse("d3620d5d-b861-45f4-92a3-08dd127b927d"),
                    Title = "فصل دوم: الگوریتم‌های ابتدایی هوش مصنوعی",
                    SeasonsDescription = "در این فصل الگوریتم‌های پایه‌ای هوش مصنوعی مورد بررسی قرار می‌گیرند.",
                    CreatedUserID = Guid.Parse("9ceea18b-7117-4059-805c-08dd0d8a09bd"),
                    CreatedDate = DateTime.Now,
                    ISActive = true,
                    IsDeleted = false
                },

                // دوره طراحی وب با HTML
                new Seasons
                {
                    Id = Guid.NewGuid(),
                    Code = 5,
                    CourseId = Guid.Parse("b370c8da-f20e-40d1-bb80-08dd12b49c06"),
                    Title = "فصل اول: اصول طراحی وب با HTML",
                    SeasonsDescription = "در این فصل به مبانی طراحی صفحات وب با استفاده از HTML پرداخته می‌شود.",
                    CreatedUserID = Guid.Parse("d5c19e8c-d8da-421c-a82c-08dd12f8ba89"),
                    CreatedDate = DateTime.Now,
                    ISActive = true,
                    IsDeleted = false
                },
                new Seasons
                {
                    Id = Guid.NewGuid(),
                    Code = 6,
                    CourseId = Guid.Parse("b370c8da-f20e-40d1-bb80-08dd12b49c06"),
                    Title = "فصل دوم: استفاده از تگ‌ها و ساختار پیشرفته HTML",
                    SeasonsDescription = "در این فصل به بررسی تگ‌های پیشرفته HTML و نحوه ساختاردهی به صفحات وب پرداخته می‌شود.",
                    CreatedUserID = Guid.Parse("d5c19e8c-d8da-421c-a82c-08dd12f8ba89"),
                    CreatedDate = DateTime.Now,
                    ISActive = true,
                    IsDeleted = false
                },

                // دوره طراحی سایت با CSS
                new Seasons
                {
                    Id = Guid.NewGuid(),
                    Code = 7,
                    CourseId = Guid.Parse("9fda7e1e-93be-48f4-bfdd-08dd12b69a1e"),
                    Title = "فصل اول: معرفی CSS و نحوه استفاده در صفحات وب",
                    SeasonsDescription = "در این فصل به معرفی CSS و نحوه استایل‌دهی به صفحات HTML پرداخته می‌شود.",
                    CreatedUserID = Guid.Parse("05c5b88d-af8c-407e-d068-08dd15005342"),
                    CreatedDate = DateTime.Now,
                    ISActive = true,
                    IsDeleted = false
                },
                new Seasons
                {
                    Id = Guid.NewGuid(),
                    Code = 8,
                    CourseId = Guid.Parse("9fda7e1e-93be-48f4-bfdd-08dd12b69a1e"),
                    Title = "فصل دوم: استایل‌دهی پیشرفته با CSS",
                    SeasonsDescription = "این فصل به تکنیک‌های پیشرفته در استایل‌دهی با استفاده از CSS می‌پردازد.",
                    CreatedUserID = Guid.Parse("05c5b88d-af8c-407e-d068-08dd15005342"),
                    CreatedDate = DateTime.Now,
                    ISActive = true,
                    IsDeleted = false
                },

                // دوره یادگیری ماشین
                new Seasons
                {
                    Id = Guid.NewGuid(),
                    Code = 9,
                    CourseId = Guid.Parse("f2c787ac-d92b-47e5-8fef-08dd0d9b7d5b"),
                    Title = "فصل اول: مفاهیم پایه یادگیری ماشین",
                    SeasonsDescription = "در این فصل با مفاهیم پایه یادگیری ماشین و الگوریتم‌های آن آشنا می‌شویم.",
                    CreatedUserID = Guid.Parse("81e27342-10ef-4faf-74ca-08dd1ad120c3"),
                    CreatedDate = DateTime.Now,
                    ISActive = true,
                    IsDeleted = false
                },
                new Seasons
                {
                    Id = Guid.NewGuid(),
                    Code = 10,
                    CourseId = Guid.Parse("f2c787ac-d92b-47e5-8fef-08dd0d9b7d5b"),
                    Title = "فصل دوم: استفاده از الگوریتم‌های یادگیری ماشین",
                    SeasonsDescription = "این فصل به پیاده‌سازی الگوریتم‌های مختلف یادگیری ماشین پرداخته می‌شود.",
                    CreatedUserID = Guid.Parse("81e27342-10ef-4faf-74ca-08dd1ad120c3"),
                    CreatedDate = DateTime.Now,
                    ISActive = true,
                    IsDeleted = false
                },

                // دوره بازاریابی دیجیتال
                new Seasons
                {
                    Id = Guid.NewGuid(),
                    Code = 11,
                    CourseId = Guid.Parse("4d8594d4-3495-49d3-84a1-08dd12b69e0f"),
                    Title = "فصل اول: مبانی بازاریابی دیجیتال",
                    SeasonsDescription = "در این فصل با اصول اولیه بازاریابی دیجیتال آشنا خواهید شد.",
                    CreatedUserID = Guid.Parse("282a7f03-1dca-4d15-b706-08dd20626fc4"),
                    CreatedDate = DateTime.Now,
                    ISActive = true,
                    IsDeleted = false
                },
                new Seasons
                {
                    Id = Guid.NewGuid(),
                    Code = 12,
                    CourseId = Guid.Parse("4d8594d4-3495-49d3-84a1-08dd12b69e0f"),
                    Title = "فصل دوم: استراتژی‌های بازاریابی دیجیتال",
                    SeasonsDescription = "این فصل به بررسی استراتژی‌های مختلف در بازاریابی دیجیتال پرداخته می‌شود.",
                    CreatedUserID = Guid.Parse("282a7f03-1dca-4d15-b706-08dd20626fc4"),
                    CreatedDate = DateTime.Now,
                    ISActive = true,
                    IsDeleted = false
                },

                // دوره توسعه وب با JavaScript
                new Seasons
                {
                    Id = Guid.NewGuid(),
                    Code = 13,
                    CourseId = Guid.Parse("f4be9073-42fb-4b55-b84e-08dd134e9bb7"),
                    Title = "فصل اول: آشنایی با JavaScript",
                    SeasonsDescription = "در این فصل به بررسی زبان JavaScript و قابلیت‌های آن پرداخته می‌شود.",
                    CreatedUserID = Guid.Parse("f4e5b0a0-b2d1-4e91-9934-08dd134e8e0f"),
                    CreatedDate = DateTime.Now,
                    ISActive = true,
                    IsDeleted = false
                },
                new Seasons
                {
                    Id = Guid.NewGuid(),
                    Code = 14,
                    CourseId = Guid.Parse("f4be9073-42fb-4b55-b84e-08dd134e9bb7"),
                    Title = "فصل دوم: برنامه‌نویسی شی‌گرا با JavaScript",
                    SeasonsDescription = "این فصل به مباحث پیشرفته‌تر JavaScript و شی‌گرایی در این زبان پرداخته می‌شود.",
                    CreatedUserID = Guid.Parse("f4e5b0a0-b2d1-4e91-9934-08dd134e8e0f"),
                    CreatedDate = DateTime.Now,
                    ISActive = true,
                    IsDeleted = false
                },

                // دوره برنامه‌نویسی Python
                new Seasons
                {
                    Id = Guid.NewGuid(),
                    Code = 15,
                    CourseId = Guid.Parse("0a50d35e-b736-4389-bb60-08dd13f5ec2f"),
                    Title = "فصل اول: آشنایی با Python",
                    SeasonsDescription = "در این فصل با مبانی زبان Python و ابزارهای آن آشنا خواهید شد.",
                    CreatedUserID = Guid.Parse("21326ebd-3503-44bc-b084-08dd0d5f8765"),
                    CreatedDate = DateTime.Now,
                    ISActive = true,
                    IsDeleted = false
                },
                new Seasons
                {
                    Id = Guid.NewGuid(),
                    Code = 16,
                    CourseId = Guid.Parse("0a50d35e-b736-4389-bb60-08dd13f5ec2f"),
                    Title = "فصل دوم: استفاده از کتابخانه‌های Python",
                    SeasonsDescription = "در این فصل با کتابخانه‌های مختلف Python برای انجام پروژه‌های مختلف آشنا می‌شوید.",
                    CreatedUserID = Guid.Parse("21326ebd-3503-44bc-b084-08dd0d5f8765"),
                    CreatedDate = DateTime.Now,
                    ISActive = true,
                    IsDeleted = false
                },

                // دوره برنامه‌نویسی با Java
                new Seasons
                {
                    Id = Guid.NewGuid(),
                    Code = 17,
                    CourseId = Guid.Parse("6fe73612-9170-47cf-908e-08dd1b3d5be6"),
                    Title = "فصل اول: معرفی زبان Java",
                    SeasonsDescription = "این فصل به آشنایی با زبان برنامه نویسی Java و محیط‌های آن پرداخته می‌شود.",
                    CreatedUserID = Guid.Parse("356da970-d5e7-47bb-b015-08dd1cfa5397"),
                    CreatedDate = DateTime.Now,
                    ISActive = true,
                    IsDeleted = false
                },
                new Seasons
                {
                    Id = Guid.NewGuid(),
                    Code = 18,
                    CourseId = Guid.Parse("6fe73612-9170-47cf-908e-08dd1b3d5be6"),
                    Title = "فصل دوم: برنامه‌نویسی شی‌گرا با Java",
                    SeasonsDescription = "در این فصل به اصول برنامه نویسی شی‌گرا در Java پرداخته می‌شود.",
                    CreatedUserID = Guid.Parse("356da970-d5e7-47bb-b015-08dd1cfa5397"),
                    CreatedDate = DateTime.Now,
                    ISActive = true,
                    IsDeleted = false
                },

                // دوره مدیریت پروژه
                new Seasons
                {
                    Id = Guid.NewGuid(),
                    Code = 19,
                    CourseId = Guid.Parse("2f4d9c5d-96ad-42ac-b32f-08dd13e8d79e"),
                    Title = "فصل اول: اصول مدیریت پروژه",
                    SeasonsDescription = "این فصل به معرفی اصول مدیریت پروژه و چرخه عمر آن پرداخته می‌شود.",
                    CreatedUserID = Guid.Parse("17be1a62-7b57-4c39-a92a-08dd1c226f90"),
                    CreatedDate = DateTime.Now,
                    ISActive = true,
                    IsDeleted = false
                },
                new Seasons
                {
                    Id = Guid.NewGuid(),
                    Code = 20,
                    CourseId = Guid.Parse("2f4d9c5d-96ad-42ac-b32f-08dd13e8d79e"),
                    Title = "فصل دوم: مدیریت زمان در پروژه‌ها",
                    SeasonsDescription = "در این فصل به مدیریت زمان و منابع پروژه‌ها پرداخته می‌شود.",
                    CreatedUserID = Guid.Parse("17be1a62-7b57-4c39-a92a-08dd1c226f90"),
                    CreatedDate = DateTime.Now,
                    ISActive = true,
                    IsDeleted = false
                },
                 new Seasons
                 {
                     Id = Guid.NewGuid(),
                     Code = 21,
                     CourseId = Guid.Parse("678f8db5-b7d9-447f-8f88-08dd134e9b5a"),
                     Title = "فصل اول: اصول مدیریت زمان",
                     SeasonsDescription = "در این فصل به اصول و تکنیک‌های مدیریت زمان پرداخته می‌شود.",
                     CreatedUserID = Guid.Parse("17be1a62-7b57-4c39-a92a-08dd1c226f90"),
                     CreatedDate = DateTime.Now,
                     ISActive = true,
                     IsDeleted = false
                 },
                 new Seasons
                 {
                     Id = Guid.NewGuid(),
                     Code = 22,
                     CourseId = Guid.Parse("678f8db5-b7d9-447f-8f88-08dd134e9b5a"),
                     Title = "فصل دوم: تکنیک‌های برنامه‌ریزی و زمان‌بندی",
                     SeasonsDescription = "در این فصل به تکنیک‌های مختلف برنامه‌ریزی و زمان‌بندی پرداخته می‌شود.",
                     CreatedUserID = Guid.Parse("17be1a62-7b57-4c39-a92a-08dd1c226f90"),
                     CreatedDate = DateTime.Now,
                     ISActive = true,
                     IsDeleted = false
                 },

                 // دوره تحلیل داده‌ها با R
                 new Seasons
                 {
                     Id = Guid.NewGuid(),
                     Code = 23,
                     CourseId = Guid.Parse("73db149e-65d7-44db-80ac-08dd134e98d4"),
                     Title = "فصل اول: مقدمه‌ای بر تحلیل داده‌ها با R",
                     SeasonsDescription = "در این فصل با مفاهیم پایه تحلیل داده‌ها با استفاده از زبان R آشنا می‌شوید.",
                     CreatedUserID = Guid.Parse("d5c19e8c-d8da-421c-a82c-08dd12f8ba89"),
                     CreatedDate = DateTime.Now,
                     ISActive = true,
                     IsDeleted = false
                 },
                 new Seasons
                 {
                     Id = Guid.NewGuid(),
                     Code = 24,
                     CourseId = Guid.Parse("73db149e-65d7-44db-80ac-08dd134e98d4"),
                     Title = "فصل دوم: پردازش داده‌ها و مدل‌سازی",
                     SeasonsDescription = "در این فصل به پردازش داده‌ها و الگوریتم‌های مدل‌سازی در R پرداخته می‌شود.",
                     CreatedUserID = Guid.Parse("d5c19e8c-d8da-421c-a82c-08dd12f8ba89"),
                     CreatedDate = DateTime.Now,
                     ISActive = true,
                     IsDeleted = false
                 },

                 // دوره توسعه اپلیکیشن با React
                 new Seasons
                 {
                     Id = Guid.NewGuid(),
                     Code = 25,
                     CourseId = Guid.Parse("df8c75f5-b659-4845-bf5d-08dd1353b370"),
                     Title = "فصل اول: آشنایی با React و مفاهیم پایه",
                     SeasonsDescription = "در این فصل با اصول پایه‌ای React و نحوه ساخت کامپوننت‌ها آشنا می‌شوید.",
                     CreatedUserID = Guid.Parse("b60bb559-b839-4329-bb83-08dd12d674ba"),
                     CreatedDate = DateTime.Now,
                     ISActive = true,
                     IsDeleted = false
                 },
                 new Seasons
                 {
                     Id = Guid.NewGuid(),
                     Code = 26,
                     CourseId = Guid.Parse("df8c75f5-b659-4845-bf5d-08dd1353b370"),
                     Title = "فصل دوم: مدیریت وضعیت و داده‌ها در React",
                     SeasonsDescription = "در این فصل به روش‌های مدیریت وضعیت در React و استفاده از Hooks پرداخته می‌شود.",
                     CreatedUserID = Guid.Parse("b60bb559-b839-4329-bb83-08dd12d674ba"),
                     CreatedDate = DateTime.Now,
                     ISActive = true,
                     IsDeleted = false
                 },

                 // دوره توسعه اپلیکیشن با Flutter
                 new Seasons
                 {
                     Id = Guid.NewGuid(),
                     Code = 27,
                     CourseId = Guid.Parse("db6c3347-b11d-44c9-a0d3-08dd1353b882"),
                     Title = "فصل اول: شروع با Flutter و Dart",
                     SeasonsDescription = "در این فصل به معرفی زبان Dart و چارچوب Flutter پرداخته می‌شود.",
                     CreatedUserID = Guid.Parse("f12c9152-3d51-49de-b273-08dd1b6ab4e9"),
                     CreatedDate = DateTime.Now,
                     ISActive = true,
                     IsDeleted = false
                 },
                 new Seasons
                 {
                     Id = Guid.NewGuid(),
                     Code = 28,
                     CourseId = Guid.Parse("db6c3347-b11d-44c9-a0d3-08dd1353b882"),
                     Title = "فصل دوم: ساخت اپلیکیشن‌های چندمنظوره با Flutter",
                     SeasonsDescription = "این فصل به ایجاد اپلیکیشن‌های چندمنظوره با Flutter اختصاص دارد.",
                     CreatedUserID = Guid.Parse("f12c9152-3d51-49de-b273-08dd1b6ab4e9"),
                     CreatedDate = DateTime.Now,
                     ISActive = true,
                     IsDeleted = false
                 },

                 // دوره طراحی رابط کاربری (UI/UX)
                 new Seasons
                 {
                     Id = Guid.NewGuid(),
                     Code = 29,
                     CourseId = Guid.Parse("5f62e0f1-6a0d-4d92-b73d-08dd1b3dce3b"),
                     Title = "فصل اول: اصول طراحی UI/UX",
                     SeasonsDescription = "در این فصل با اصول اولیه طراحی رابط کاربری (UI) و تجربه کاربری (UX) آشنا می‌شوید.",
                     CreatedUserID = Guid.Parse("01b7a545-1a56-4a1e-b3b3-08dd0da7202d"),
                     CreatedDate = DateTime.Now,
                     ISActive = true,
                     IsDeleted = false
                 },
                 new Seasons
                 {
                     Id = Guid.NewGuid(),
                     Code = 30,
                     CourseId = Guid.Parse("5f62e0f1-6a0d-4d92-b73d-08dd1b3dce3b"),
                     Title = "فصل دوم: طراحی پیشرفته UI/UX",
                     SeasonsDescription = "این فصل به تکنیک‌های پیشرفته طراحی UI/UX و استفاده از ابزارهای مختلف طراحی پرداخته می‌شود.",
                     CreatedUserID = Guid.Parse("01b7a545-1a56-4a1e-b3b3-08dd0da7202d"),
                     CreatedDate = DateTime.Now,
                     ISActive = true,
                     IsDeleted = false
                 },

                 // دوره مباحث پیشرفته امنیت شبکه
                 new Seasons
                 {
                     Id = Guid.NewGuid(),
                     Code = 31,
                     CourseId = Guid.Parse("32e7bc14-c8a5-4204-8d94-08dd0cc49a94"),
                     Title = "فصل اول: مقدمه‌ای بر امنیت شبکه",
                     SeasonsDescription = "این فصل به مفاهیم پایه‌ای امنیت شبکه و تهدیدات رایج می‌پردازد.",
                     CreatedUserID = Guid.Parse("926928e9-f83c-41f4-a621-08dd0d64b81a"),
                     CreatedDate = DateTime.Now,
                     ISActive = true,
                     IsDeleted = false
                 },
                 new Seasons
                 {
                     Id = Guid.NewGuid(),
                     Code = 32,
                     CourseId = Guid.Parse("32e7bc14-c8a5-4204-8d94-08dd0cc49a94"),
                     Title = "فصل دوم: تکنیک‌های پیشرفته امنیت شبکه",
                     SeasonsDescription = "این فصل به روش‌های پیشرفته برای حفاظت از شبکه‌ها و داده‌ها پرداخته می‌شود.",
                     CreatedUserID = Guid.Parse("926928e9-f83c-41f4-a621-08dd0d64b81a"),
                     CreatedDate = DateTime.Now,
                     ISActive = true,
                     IsDeleted = false
                 },

                 // دوره تست نرم‌افزار
                 new Seasons
                 {
                     Id = Guid.NewGuid(),
                     Code = 33,
                     CourseId = Guid.Parse("ae50f64f-d0d1-453a-9a82-08dd135b16a6"),
                     Title = "فصل اول: مبانی تست نرم‌افزار",
                     SeasonsDescription = "در این فصل با اصول تست نرم‌افزار و انواع تست‌های موجود آشنا می‌شوید.",
                     CreatedUserID = Guid.Parse("e8a0d5b2-c064-430b-b3ca-08dd134e6e22"),
                     CreatedDate = DateTime.Now,
                     ISActive = true,
                     IsDeleted = false
                 },
                 new Seasons
                 {
                     Id = Guid.NewGuid(),
                     Code = 34,
                     CourseId = Guid.Parse("ae50f64f-d0d1-453a-9a82-08dd135b16a6"),
                     Title = "فصل دوم: تست خودکار نرم‌افزار",
                     SeasonsDescription = "این فصل به معرفی ابزارهای تست خودکار و نحوه پیاده‌سازی آن‌ها در نرم‌افزارها پرداخته می‌شود.",
                     CreatedUserID = Guid.Parse("e8a0d5b2-c064-430b-b3ca-08dd134e6e22"),
                     CreatedDate = DateTime.Now,
                     ISActive = true,
                     IsDeleted = false
                 }
             };
        }
        #endregion


    }
}
