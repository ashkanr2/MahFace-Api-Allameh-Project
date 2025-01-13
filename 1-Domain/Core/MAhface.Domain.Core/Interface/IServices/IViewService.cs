using MAhface.Domain.Core1.Dto;
using MAhface.Domain.Core1.Interface.IRipositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MAhface.Domain.Core1.Interface.IServices
{
    public interface IViewService
    {
        Task<ViewDTO> GetViewDetailsById(Guid id);
        Task<(bool hasViewed, TimeOnly? lastVideoTime)> HasUserViewedCourse(Guid userId, Guid sectionId);
        Task<AddStatusVm> AddViewAsync( Guid sectionId, Guid userId, TimeOnly lastVideoTime);
        Task<int> GetTotalViewsForCourse(Guid courseId);
        Task<int> GetTotalViewsForCourseByUser(Guid userId, Guid courseId);
        Task<int> CountOfCourseView(Guid courseId);
    }


}
