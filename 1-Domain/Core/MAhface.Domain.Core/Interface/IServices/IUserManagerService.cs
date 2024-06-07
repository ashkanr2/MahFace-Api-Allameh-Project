using MAhface.Domain.Core.Entities.BasicInfo.Accounting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAhface.Domain.Core1.Interface.IServices
{
    public interface IUserManagerService
    {
        public Task<User> GetUserByIdAsync(Guid id);
        public Task<IEnumerable<User>> GetAllUsersAsync();
        public Task AddUserAsync(User user);
        public Task UpdateUserAsync(User user);
        public Task DeleteUserAsync(Guid id);
    }
}
