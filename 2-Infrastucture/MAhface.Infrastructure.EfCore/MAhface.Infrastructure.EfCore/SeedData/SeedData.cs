using MAhface.Domain.Core.Entities.BasicInfo.Accounting;
using MAhface.Domain.Core.Entities.BasicInfo.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAhface.Infrastructure.EfCore.SeedData
{


    public static class SeedData
    {
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



    }


}
