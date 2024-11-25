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
       public Task<ViewDTO> GetViewDetailsById(Guid id);
       public Task<(bool hasViewed, TimeOnly? lastVideoTime)> HasUserViewedCourse(Guid userId, Guid sectionId);
        public Task<AddStatusVm> AddViewAsync( Guid sectionId, Guid userId, TimeOnly lastVideoTime);

        public Task<int> GetTotalViewsForCourse(Guid courseId);
       public Task<int> GetTotalViewsForCourseByUser(Guid userId, Guid courseId);
    }


}
