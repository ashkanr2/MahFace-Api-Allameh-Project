using MAhface.Domain.Core1.Dto;
using MAhface.Domain.Core1.Entities.BasicInfo.Accounting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAhface.Domain.Core1.Interface.IServices
{
    public interface ITeacherRequestService
    {
        Task<AddStatusVm> CreateTeacherRequest(Guid userId, string userDescription);
        Task<List<TeacherRequestVm>> GetAllRequests();
        Task<UpdateStatus> ApproveRequest(Guid requestId, Guid adminId);
        Task<UpdateStatus> RejectRequest(Guid requestId, string adminDescription, Guid adminId);
        Task<UpdateStatus> ApproveMultipleRequests(List<Guid> requestIds, Guid adminId);
        Task<UpdateStatus> RejectMultipleRequests(List<Guid> requestIds, string adminDescription, Guid adminId);
        Task<RequestStatus>GetUserTeacherRequestStatus(Guid userId);    
    }
}
