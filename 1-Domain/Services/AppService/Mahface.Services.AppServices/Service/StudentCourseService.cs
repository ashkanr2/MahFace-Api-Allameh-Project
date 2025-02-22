﻿using MAhface.Domain.Core.Interface.IRipositories;
using MAhface.Domain.Core1.Dto;
using MAhface.Domain.Core1.Entities.BasicInfo.Business;
using MAhface.Domain.Core1.Interface.IRipositories;
using MAhface.Domain.Core1.Interface.IServices;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mahface.Services.AppServices.Service
{

    public class StudentCourseService : IStudentCourseService
    {
        private readonly IStudentCourseRipository _studentCourseRipository;
        private readonly ICourseRipository _courseRipository;
        private readonly IUserService _userService;

        public StudentCourseService(IStudentCourseRipository studentCourseRipository, ICourseRipository courseRipository, IUserService userService)
        {
            _studentCourseRipository = studentCourseRipository;
            _courseRipository= courseRipository;
            _userService = userService;
        }
        public async Task<List<CourseVm>> GetUserCourses(Guid userId)
        {

            var courseIds = await _studentCourseRipository.GetUserCoursesId(userId);


            var coursesQuery = _courseRipository.NewGetAllCourses();

            var userCourses = coursesQuery
                .Where(c => courseIds.Contains(c.Id))
                .ToList();

            return userCourses;
        }

        public Task<List<Guid>> GetUsersCourses(Guid courseId)
        {
            return _studentCourseRipository.GetCourseUsersId(courseId);
        }


        public async Task<AddStatusVm> AddStudentToCourse(StudentCourses studentCourses)
        {
            return await _studentCourseRipository.Add(studentCourses);
        }

        public async Task<AddStatusVm> AddStudentMultipleCourse(StudentMultipleCoursesVm model)
        {
            try
            {
                // گرفتن لیست همه آی‌دی‌های دوره‌ها از مخزن
                var coursesIds = _courseRipository.NewGetAllCourses().Select(c => c.Id).ToList();

                // گرفتن لیست آی‌دی‌های دوره‌هایی که کاربر قبلاً ثبت‌نام کرده است
                var studentCoursesIds = await _studentCourseRipository.GetUserCoursesId(model.UserId);

                // چک کردن صحت آی‌دی‌های درخواست‌شده
                var invalidCourseIds = model.RequestIds.Except(coursesIds).ToList();
                if (invalidCourseIds.Any())
                {
                    return new AddStatusVm
                    {
                        IsValid = false,
                        StatusMessage = $"برخی از آی‌دی‌های دوره نامعتبر هستند: {string.Join(", ", invalidCourseIds)}"
                    };
                }

                // حذف دوره‌هایی که کاربر قبلاً در آنها ثبت‌نام کرده است
                var newCourseIds = model.RequestIds.Except(studentCoursesIds).ToList();

                if (!newCourseIds.Any())
                {
                    return new AddStatusVm
                    {
                        IsValid = false,
                        StatusMessage = "همه دوره‌های درخواست‌شده قبلاً برای این کاربر ثبت شده‌اند."
                    };
                }

                // ایجاد لیستی از ثبت‌نام‌های جدید
                var newStudentCourses = newCourseIds.Select(courseId => new StudentCourses
                {
                    UserId = model.UserId,
                    CourseId = courseId
                }).ToList();

                // ثبت داده‌های جدید در پایگاه داده
                foreach (var studentCourse in newStudentCourses)
                {
                    await _studentCourseRipository.Add(studentCourse);
                }

                // بازگشت پیام موفقیت
                return new AddStatusVm
                {
                    IsValid = true,
                    StatusMessage = "دوره‌ها با موفقیت برای کاربر ثبت شدند."
                };
            }
            catch (Exception ex)
            {
                // مدیریت خطا و بازگشت پیام خطا
                return new AddStatusVm
                {
                    IsValid = false,
                    StatusMessage = $"خطایی در هنگام ثبت دوره‌ها رخ داد: {ex.Message}"
                };
            }
        }



        // Updates student-course relation
        public async Task<UpdateStatus> UpdateStudentCourse(StudentCourses studentCourses)
        {
            return await _studentCourseRipository.Update(studentCourses);
        }

        // Deletes a student from a course
        public async Task<UpdateStatus> DeleteStudentFromCourse(Guid courseId, Guid userId)
        {
            return await _studentCourseRipository.Delete(courseId, userId);
        }

        public async Task<AddStatusVm> SeedData()
        {
            try
            {
                // Step 1: Get all users that are students (and not teachers)
                var users = await _userService.GetAllUsers();
                var studentUsers = users.Where(x => x.IsStudent && !x.IsTeacher).ToList();

                // Step 2: Retrieve all course IDs from the course repository
                var courses = await _courseRipository.NewGetAllCourses()
                    .Select(x => x.Id)
                    .ToListAsync();

                // Step 3: For each student, assign 4 random courses
                var random = new Random();
                var studentCoursesList = new List<StudentCourses>();

                foreach (var user in studentUsers)
                {
                    // Get 4 unique random courses for the student
                    var randomCourses = courses.OrderBy(c => random.Next()).Take(4).ToList();

                    foreach (var courseId in randomCourses)
                    {
                        studentCoursesList.Add(new StudentCourses
                        {
                            UserId = user.Id,
                            CourseId = courseId,
                            CreatedUserID=user.Id,
                            CreatedDate= DateTime.Now,
                            IsDeleted=false,
                            ISActive=true,


                        });
                    }
                }

                // Step 4: Save student-course assignments to the database
                foreach (var studentCourse in studentCoursesList)
                {
                    var result = await _studentCourseRipository.Add(studentCourse);
                    if (!result.IsValid)
                    {
                        return new AddStatusVm
                        {
                            IsValid = false,
                            StatusMessage = $"خطا در افزودن دوره به کاربر {studentCourse.UserId}.",
                            AddedId = null
                        };
                    }
                }

                return new AddStatusVm
                {
                    IsValid = true,
                    StatusMessage = "دوره‌ها به صورت تصادفی به تمامی دانش‌آموزان اضافه شدند.",
                    AddedId = null
                };
            }
            catch (Exception ex)
            {
                return new AddStatusVm
                {
                    IsValid = false,
                    StatusMessage = $"خطا: {ex.Message}",
                    AddedId = null
                };
            }
        }

        public async Task<bool> HasExist(Guid userId, Guid courseId)
        {

            var userCourses = await _studentCourseRipository.GetUserCoursesId(userId);


            if (userCourses == null || !userCourses.Any())
                return false;


            return userCourses.Any(c => c == courseId);
        }

    }
}


