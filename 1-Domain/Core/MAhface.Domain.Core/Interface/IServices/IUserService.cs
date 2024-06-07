using MAhface.Domain.Core.Entities.BasicInfo.Accounting;
using MAhface.Domain.Core1.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAhface.Domain.Core1.Interface.IServices
{
    public interface IUserService
    {
        public Task<UserDto> GetUserById(Guid id);
        public Task<IEnumerable<UserDto>> GetAllUsers();
        public Task<string> AddUser(UserDto userDto);
        public Task<string> UpdateUser(UserDto userDto);
        public Task<string> DeleteUser(Guid id);
    }
}
