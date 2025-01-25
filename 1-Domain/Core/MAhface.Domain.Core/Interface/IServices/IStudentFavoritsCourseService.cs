using MAhface.Domain.Core1.Dto;
using MAhface.Domain.Core1.Entities.BasicInfo.Accounting;
using MAhface.Domain.Core1.Entities.BasicInfo.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAhface.Domain.Core1.Interface.IServices
{
    public interface IStudentFavoritsCourseService
    {
        Task<List<CourseVm>> GetUserFavoritsCourses(Guid userId); 
        Task<List<Guid>> GetUsersCourses(Guid courseId); 
        Task<bool> HasExist(Guid userId, Guid courseId);
        Task<AddStatusVm> AddStudentToCourse(StudentFavoriteCourses studentCourses); 
        Task<AddStatusVm> AddStudentMultipleCourse(StudentMultipleCoursesVm model);
        Task<UpdateStatus> UpdateStudentCourse(StudentFavoriteCourses studentCourses); 
        Task<UpdateStatus> DeleteStudentFromCourse(Guid courseId, Guid userId); 

        Task<AddStatusVm> SeedData();
    }
}
