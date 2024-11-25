using MAhface.Domain.Core.Entities.Study.Course;
using MAhface.Domain.Core1.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAhface.Domain.Core.Interface.IRipositories
{
    public interface ICourseripository
    {
       public Task<Courses> GetCourseById(Guid id);
       public Task<IEnumerable<Courses>> GetAllCourses();
       public Task<AddStatusVm> AddCourse(Courses course);
       public Task UpdateCourse(Courses course);
       public Task DeleteCourse(Guid id);

    }
}
