using MAhface.Domain.Core.Entities.Study.Course;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAhface.Domain.Core.Interface.IRipositories
{
    public interface ICourseripository
    {
        Task<Courses> GetCourseById(Guid id);
        Task<IEnumerable<Courses>> GetAllCourses();
        Task AddCourse(Courses course);
        Task UpdateCourse(Courses course);
        Task DeleteCourse(Guid id);

    }
}
