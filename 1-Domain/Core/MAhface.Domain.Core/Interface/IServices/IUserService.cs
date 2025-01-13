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
         Task<UserDto> GetUserById(Guid id);
         Task<IEnumerable<UserDto>> GetAllUsers();
         Task<string> AddUser(UserDto userDto);
         Task<UpdateStatus> EditProfile(EditUserVm editUserVm);
         Task<UpdateStatus> UpdateUserByAdmin(EditUserVm editUserVm);
         Task<string> DeleteUser(Guid id);
         Task<AddStatusVm> Register(AddUser addUser);
         Task<LoginResponseVm> Login(string email, string password);
         Task<UserDto> GetUserByTeacherId(Guid teacherId);
         Task<UpdateStatus>EmailConfirm(Guid userId ,string emailToken );
    }
}
