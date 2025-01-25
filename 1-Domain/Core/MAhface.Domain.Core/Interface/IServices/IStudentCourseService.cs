using MAhface.Domain.Core1.Dto;
using MAhface.Domain.Core1.Entities.BasicInfo.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAhface.Domain.Core1.Interface.IServices
{
    public interface IStudentCourseService
    {
        Task<List<CourseVm>> GetUserCourses(Guid userId); // Retrieves all courses for a specific user
        Task<List<Guid>> GetUsersCourses(Guid courseId); // Retrieves all users for a specific course
        Task<bool>HasExist(Guid userId , Guid courseId);
        Task<AddStatusVm> AddStudentToCourse(StudentCourses studentCourses); // Adds a student to a course
        Task<AddStatusVm> AddStudentMultipleCourse(StudentMultipleCoursesVm model);
        Task<UpdateStatus> UpdateStudentCourse(StudentCourses studentCourses); // Updates student-course relation
        Task<UpdateStatus> DeleteStudentFromCourse(Guid courseId, Guid userId); // Deletes a student from a course

        Task<AddStatusVm> SeedData();
    }
}
