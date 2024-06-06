
using MAhface.Domain.Core.Dto;
using MAhface.Domain.Core.Entities.Study.Course;
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
        Task AddCourse(CourseDto courseDto);
        Task UpdateCourse(CourseDto courseDto);
        Task DeleteCourse(Guid id);
    }
}
