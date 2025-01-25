using MAhface.Domain.Core.Interface.IRipositories;
using MAhface.Domain.Core1.Dto;
using MAhface.Domain.Core1.Entities.BasicInfo.Accounting;
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
    public class StudentFavoritsCourseService : IStudentFavoritsCourseService
    {
        private readonly IStudentFavoritsCourseRipository _studentFavoritsCourseRipository;
        private readonly ICourseRipository _courseRipository;
        private readonly IUserService _userService;

        public StudentFavoritsCourseService(IStudentFavoritsCourseRipository studentFavoritsCourseRipository, ICourseRipository courseRipository, IUserService userService)
        {
            _studentFavoritsCourseRipository = studentFavoritsCourseRipository;
            _courseRipository = courseRipository;
            _userService = userService;
        }

        public async Task<List<CourseVm>> GetUserFavoritsCourses(Guid userId)
        {
            var courseIds = await _studentFavoritsCourseRipository.GetUserCoursesId(userId);

            var coursesQuery = _courseRipository.NewGetAllCourses();

            var userCourses = coursesQuery
                .Where(c => courseIds.Contains(c.Id))
                .ToList();

            return userCourses;
        }

        public async Task<List<Guid>> GetUsersCourses(Guid courseId)
        {
            return await _studentFavoritsCourseRipository.GetCourseUsersId(courseId);
        }

        public async Task<AddStatusVm> AddStudentToCourse(StudentFavoriteCourses studentCourses)
        {
            return await _studentFavoritsCourseRipository.Add(studentCourses);
        }

        public async Task<AddStatusVm> AddStudentMultipleCourse(StudentMultipleCoursesVm model)
        {
            try
            {
                // Fetch all course IDs from the repository
                var coursesIds = _courseRipository.NewGetAllCourses().Select(c => c.Id).ToList();

                // Fetch already enrolled courses for the user
                var studentCoursesIds = await _studentFavoritsCourseRipository.GetUserCoursesId(model.UserId);

                // Check for invalid course IDs
                var invalidCourseIds = model.RequestIds.Except(coursesIds).ToList();
                if (invalidCourseIds.Any())
                {
                    return new AddStatusVm
                    {
                        IsValid = false,
                        StatusMessage = $"Some course IDs are invalid: {string.Join(", ", invalidCourseIds)}"
                    };
                }

                // Remove courses that the user is already enrolled in
                var newCourseIds = model.RequestIds.Except(studentCoursesIds).ToList();

                if (!newCourseIds.Any())
                {
                    return new AddStatusVm
                    {
                        IsValid = false,
                        StatusMessage = "All requested courses are already enrolled by this user."
                    };
                }

                // Create new student-course relationships
                var newStudentCourses = newCourseIds.Select(courseId => new StudentFavoriteCourses
                {
                    UserId = model.UserId,
                    CourseId = courseId
                }).ToList();

                // Add new student-course entries to the database
                foreach (var studentCourse in newStudentCourses)
                {
                    await _studentFavoritsCourseRipository.Add(studentCourse);
                }

                return new AddStatusVm
                {
                    IsValid = true,
                    StatusMessage = "Courses have been successfully added to the user."
                };
            }
            catch (Exception ex)
            {
                return new AddStatusVm
                {
                    IsValid = false,
                    StatusMessage = $"An error occurred while adding courses: {ex.Message}"
                };
            }
        }

        public async Task<UpdateStatus> UpdateStudentCourse(StudentFavoriteCourses studentCourses)
        {
            return await _studentFavoritsCourseRipository.Update(studentCourses);
        }

        public async Task<UpdateStatus> DeleteStudentFromCourse(Guid courseId, Guid userId)
        {
            return await _studentFavoritsCourseRipository.Delete(courseId, userId);
        }

        public async Task<AddStatusVm> SeedData()
        {
            try
            {
                // Step 1: Get all users that are students (not teachers)
                var users = await _userService.GetAllUsers();
                var studentUsers = users.Where(x => x.IsStudent && !x.IsTeacher).ToList();

                // Step 2: Retrieve all course IDs from the course repository
                var courses = await _courseRipository.NewGetAllCourses()
                    .Select(x => x.Id)
                    .ToListAsync();

                // Step 3: For each student, assign 4 random courses
                var random = new Random();
                var studentCoursesList = new List<StudentFavoriteCourses>();

                foreach (var user in studentUsers)
                {
                    // Get 4 unique random courses for the student
                    var randomCourses = courses.OrderBy(c => random.Next()).Take(4).ToList();

                    foreach (var courseId in randomCourses)
                    {
                        studentCoursesList.Add(new StudentFavoriteCourses
                        {
                            UserId = user.Id,
                            CourseId = courseId,
                            CreatedUserID = user.Id,
                            CreatedDate = DateTime.Now,
                            IsDeleted = false,
                            ISActive = true
                        });
                    }
                }

                // Step 4: Save the new student-course associations to the database
                foreach (var studentCourse in studentCoursesList)
                {
                    var result = await _studentFavoritsCourseRipository.Add(studentCourse);
                    if (!result.IsValid)
                    {
                        return new AddStatusVm
                        {
                            IsValid = false,
                            StatusMessage = $"Error adding course to user {studentCourse.UserId}.",
                            AddedId = null
                        };
                    }
                }

                return new AddStatusVm
                {
                    IsValid = true,
                    StatusMessage = "Courses have been randomly assigned to all students.",
                    AddedId = null
                };
            }
            catch (Exception ex)
            {
                return new AddStatusVm
                {
                    IsValid = false,
                    StatusMessage = $"Error: {ex.Message}",
                    AddedId = null
                };
            }
        }

        public async Task<bool> HasExist(Guid userId, Guid courseId)
        {
            var userCourses = await _studentFavoritsCourseRipository.GetUserCoursesId(userId);
            return userCourses != null && userCourses.Any(c => c == courseId);
        }
    }

}
