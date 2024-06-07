using AutoMapper;
using MAhface.Domain.Core.Entities.BasicInfo.Accounting;
using MAhface.Domain.Core1.Dto;
using MAhface.Domain.Core1.Interface.IServices;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Mahface.Services.AppServices.Service
{
    public class UserService:IUserService
    {
        private readonly UserManager<User> _userManager;
        private readonly IMapper _mapper;
        public UserService(UserManager<User>userManager , IMapper mapper)
        {
           _userManager = userManager;
            _mapper = mapper;
        }

        public async Task<string> AddUser(UserDto userDto)
        {
            var user = _mapper.Map<User>(userDto);
            try
            {
            await _userManager.CreateAsync(user);
                return "User Add successfully";
            }
            catch (Exception ex)
            {
                throw new Exception("Error occurred while adding User", ex);
                return "Error occurred while adding User";
            }
        }

        public async Task<string>DeleteUser(Guid id)
        {
            //var user = await _userManager.Users.FirstOrDefault(x=>x.Id == id);
            try
            {
                return "ss";
            }
            catch (Exception ex)
            {
                throw new Exception("Error occurred while adding User", ex);
            }
        }

        public Task<IEnumerable<UserDto>> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public Task<UserDto> GetUserById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<string> UpdateUser(UserDto userDto)
        {
            throw new NotImplementedException();
        }
    }
}
