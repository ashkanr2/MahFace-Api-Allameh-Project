using MAhface.Domain.Core1.Entities.BasicInfo.Accounting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAhface.Domain.Core1.Interface.IRipositories
{
    public interface ITeacherRequestRepository
    {
        Task AddTeacherRequest(TeacherRequests teacherRequest);
        Task<List<TeacherRequests>> GetAllRequests();
        Task<TeacherRequests> GetRequestById(Guid requestId);
        Task<TeacherRequests> GetRequestByUserId(Guid userId);
        Task UpdateRequest(TeacherRequests teacherRequest);
    }
}
