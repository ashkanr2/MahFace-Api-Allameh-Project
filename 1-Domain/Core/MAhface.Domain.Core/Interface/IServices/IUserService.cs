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
        public Task<UpdateStatus> EditProfile(EditUserVm editUserVm);
        public Task<UpdateStatus> UpdateUserByAdmin(EditUserVm editUserVm);
        public Task<string> DeleteUser(Guid id);
        public Task<AddStatusVm> Register(AddUser addUser);
        Task<LoginResponseVm> Login(string email, string password);

        public Task<UserDto> GetUserByTeacherId(Guid teacherId);
    }
}
