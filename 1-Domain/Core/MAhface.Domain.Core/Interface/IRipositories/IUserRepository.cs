using MAhface.Domain.Core.Entities.BasicInfo.Accounting;
using MAhface.Domain.Core1.Dto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UpdateStatus = MAhface.Domain.Core1.Dto.UpdateStatus;

namespace MAhface.Domain.Core1.Interface.IRipositories
{
    public interface IUserRepository
    {
        Task<User> GetUserByIdAsync(Guid id);
        Task<User> GetUserByTeacherIdAsync(Guid teacherId);
        Task<Guid> GetAdminUserId();
        Task<IEnumerable<User>> GetAllUsersAsync();
        Task AddUserAsync(User user);
        Task<UpdateStatus> UpdateUserAsync(User user);
        Task DeleteUserAsync(Guid id);
        Task<AddStatusVm> Register(User user, string password);
        Task<IQueryable<User>> GetallUsers();
         

    }
}
