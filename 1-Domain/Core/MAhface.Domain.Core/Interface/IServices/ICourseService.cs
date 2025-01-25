
using MAhface.Domain.Core.Dto;
using MAhface.Domain.Core.Entities.Study.Course;
using MAhface.Domain.Core1.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAhface.Domain.Core.Interface.IServices
{
    public interface ICourseService
    {
        Task<CourseDetail> GetCourseById(Guid id);
        Task<List<CourseDto>> GetAllCourses();
        Task<List<CourseVm>> GetCoursesListAsync();
        Task<List<CourseVm>> GetAllCoursesWithFilterCategoryId(Guid categoryId);
        Task<List<CourseVm>> GetAllTeacherCourses(Guid userId);
        Task<List<NavVM>> GetAllCoursesTitleWithCategoryId(Guid categoryId);
        Task<List<CourseVm>> GetAllCoursesWithFilter(string Input);
        Task<AddStatusVm> AddCourse(AddCourseVm addCourse);
        Task<UpdateStatus> UpdateCourse(Guid id, AddCourseVm course);
        Task<UpdateStatus> DeleteCourse(Guid id);
        Task<AddStatusVm> SeedCourses();
    }

}

