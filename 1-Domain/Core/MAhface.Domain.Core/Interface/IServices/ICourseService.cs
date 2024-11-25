
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
    public interface ICoursesService
    {
        Task<CourseDto> GetCourseById(Guid id);
        Task<IEnumerable<CourseDto>> GetAllCourses();
        Task<AddStatusVm> AddCourse(CourseDto courseDto);
        Task UpdateCourse(CourseDto courseDto);
        Task DeleteCourse(Guid id);
    }
}
