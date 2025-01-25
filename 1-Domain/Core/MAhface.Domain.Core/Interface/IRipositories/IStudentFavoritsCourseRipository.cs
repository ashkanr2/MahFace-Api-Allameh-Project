using MAhface.Domain.Core1.Dto;
using MAhface.Domain.Core1.Entities.BasicInfo.Accounting;
using MAhface.Domain.Core1.Entities.BasicInfo.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAhface.Domain.Core1.Interface.IRipositories
{
    public interface IStudentFavoritsCourseRipository
    {
        Task<List<Guid>> GetUserCoursesId(Guid UserId);
        Task<List<Guid>> GetCourseUsersId(Guid CourseId);
        Task<AddStatusVm> Add(StudentFavoriteCourses studentFavoritsCourses);
        Task<UpdateStatus> Update(StudentFavoriteCourses studentFavoritsCourses);
        Task<UpdateStatus> Delete(Guid CourseId, Guid UserId);

    }
}
