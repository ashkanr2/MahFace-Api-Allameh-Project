using MAhface.Domain.Core.Dto;
using MAhface.Domain.Core.Entities.BasicInfo.Business;
using MAhface.Domain.Core.Entities.Study.Course;
using MAhface.Domain.Core1.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAhface.Domain.Core.Interface.IRipositories
{
    public interface ICourseRipository
    {
        Task<List<Courses>> GetAllCourses();
        IQueryable<CourseVm> NewGetAllCourses();
        Task<List<Courses>> GetAllCourseWithFilters(string searchInput);
        Task<Courses> GetCourseById(Guid id);
        Task <AddStatusVm>AddCourse(Courses course);
        Task UpdateCourse(Courses course);
        Task DeleteCourse(Guid id);
        Task<AddStatusVm> SeedData(List<Courses> courses);
    }

}
