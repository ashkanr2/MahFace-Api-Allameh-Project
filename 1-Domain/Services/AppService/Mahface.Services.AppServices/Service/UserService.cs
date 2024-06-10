using AutoMapper;
using MAhface.Domain.Core.Entities.BasicInfo.Accounting;
using MAhface.Domain.Core1.Dto;
using MAhface.Domain.Core1.Interface.IServices;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
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
            user.PasswordHash=null;
            user.SecurityStamp=null;
            user.BirthDate=DateTime.Now;
            user.Id=new Guid();
            var password = "Admin123";
            try
            {
                var result = await _userManager.CreateAsync(user, password);

                if (result.Succeeded)
                {
                    return "User added successfully";
                }
                else
                {
                    var errors = string.Join(", ", result.Errors.Select(e => e.Description));
                    throw new Exception($"User creation failed: {errors}");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error occurred while adding User", ex);
            }
        }

        public async Task<string>DeleteUser(Guid id)
        {
            var user =  _userManager.Users.FirstOrDefault(x=>x.Id == id);
            try
            {
                user.IsDeleted=true;
               await _userManager.UpdateAsync(user);
                return "User Deleted successfully";
            }
            catch (Exception ex)
            {
                throw new Exception("Error occurred while adding User", ex);
            }
        }

        public async Task<IEnumerable<UserDto>> GetAllUsers()
        {
            var User = await _userManager.Users.ToListAsync();
            var UserDto =  _mapper.Map<List<UserDto>>(User);
            return UserDto;
        }

        public async Task<UserDto> GetUserById(Guid id)
        {
           var User =  _userManager.Users.FirstOrDefaultAsync(x=>x.Id == id); 
            var UserDto = _mapper.Map<UserDto>(User);
            return UserDto;
        }

        public async Task<string> UpdateUser(UserDto userDto)
        {
            var User = _mapper.Map<User>(userDto);
            try
            {
                await _userManager.UpdateAsync(User);
                return "User Update successfully";
            }
            catch(Exception ex) 
            {
                throw new Exception("Error occurred while Updating User", ex);
            }

        }
    }
}
