using MAhface.Domain.Core.Entities.BasicInfo.Accounting;
using MAhface.Domain.Core.Entities.BasicInfo.Business;
using MAhface.Domain.Core.Entities.Study.Course;
using MAhface.Domain.Core.Entities.Study.Season;
using MAhface.Domain.Core.Interface.IRipositories;
using MAhface.Infrastructure.EfCore.Repositories;
using Microsoft.EntityFrameworkCore;
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
                    Firstname = "استاد",
                    LastName = "اشکان",
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
                    ConcurrencyStamp="76b1da8d-1986-4020-840f-bbba1a97a295",
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
                    ConcurrencyStamp="76b1da8d-1986-4020-840f-bbba1a97a295",
                    Image = null,
                    ProfileImageId = null
                },
                new User
                {
                    Id = Guid.Parse("d5c19e8c-d8da-421c-a82c-08dd12f8ba89"),
                    Firstname = "وحید",
                    LastName = "جعفری",
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
                    ConcurrencyStamp="76b1da8d-1986-4020-840f-bbba1a97a295",
                    Image = null,
                    ProfileImageId = null
                },
                new User
                {
                    Id = Guid.Parse("05c5b88d-af8c-407e-d068-08dd15005342"),
                    Firstname = "عباس",
                    LastName = "محمودی",
                    BirthDate = new DateTime(2024, 12, 5, 7, 42, 7, 242),
                    NationalCode = "123324526",
                    IsSystemAccount = false,
                    IsSystemAdmin = false,
                    IsStudent = false,
                    IsTeacher = true,
                    IsDeleted = false,
                    IsActived = false,
                    Email = "stringMahmood@Gmail.com",
                    PhoneNumber = "09121234569",
                     ConcurrencyStamp="76b1da8d-1986-4020-840f-bbba1a97a295",
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
                     ConcurrencyStamp="76b1da8d-1986-4020-840f-bbba1a97a295",
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
                     ConcurrencyStamp="76b1da8d-1986-4020-840f-bbba1a97a295",
                    Image = null,
                    ProfileImageId = null
                },
                new User
                {
                    Id = Guid.Parse("282a7f03-1dca-4d15-b706-08dd20626fc4"),
                    Firstname = "مجتبی ",
                    LastName = "محمدی",
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
                     ConcurrencyStamp="76b1da8d-1986-4020-840f-bbba1a97a295",
                    Image = null,
                    ProfileImageId = null
                },
                new User
                {
                    Id = Guid.Parse("9f5dac63-d870-4424-7166-08dd2064841e"),
                    Firstname = "احسان",
                    LastName = "علیخانی",
                    BirthDate = new DateTime(2024, 12, 19, 19, 36, 36, 471),
                    NationalCode = "366551",
                    IsSystemAccount = false,
                    IsSystemAdmin = false,
                    IsStudent = true,
                    IsTeacher = false,
                    IsDeleted = false,
                    IsActived = false,
                    Email = "strg@gmail.com",
                    PhoneNumber = "21521",
                     ConcurrencyStamp="76b1da8d-1986-4020-840f-bbba1a97a295",
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
                     ConcurrencyStamp="76b1da8d-1986-4020-840f-bbba1a97a295",
                    Image = null,
                    ProfileImageId = null
                },
                new User
                {
                    Id = Guid.Parse("c13acae2-6d50-47cf-f711-08dd347f841d"),
                    Firstname = "رضا",
                    LastName = "مرتضوی",
                    BirthDate = new DateTime(2025, 1, 14, 9, 39, 55, 273),
                    NationalCode = "12313",
                    IsSystemAccount = false,
                    IsSystemAdmin = false,
                    IsStudent = true,
                    IsTeacher = false,
                    IsDeleted = false,
                    IsActived = false,
                    Email = "s@gmail.com",
                    PhoneNumber = "09152585",
                     ConcurrencyStamp="76b1da8d-1986-4020-840f-bbba1a97a295",
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
                     ConcurrencyStamp="76b1da8d-1986-4020-840f-bbba1a97a295",
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
                 Title = "طراحی و مدل‌سازی  با Blender",
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
                 Title = "توسعه وب ASP.NET Core",
                 CourseLevelId = 2,
                 StarsNumber = 5,
                 TeacherId = Guid.Parse("486c341e-03d9-4616-242e-08dd2592d1dd"),
                 CategoryId = Guid.Parse("c758ad65-5f5d-43cf-b676-8dac2d2cf948"), // توسعه وب
                 CourseDescription = "آموزش ساخت برنامه‌های تحت وب بااستفاده از ASP.NETCore.",
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

      
    }
}
