using MAhface.Domain.Core.Entities.BasicInfo.Accounting;
using MAhface.Domain.Core1.Dto;
using MAhface.Domain.Core1.Interface.IRipositories;
using MAhface.Domain.Core1.Interface.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mahface.Services.AppServices.Service
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<User> GetUserByIdAsync(Guid id)
        {
            try
            {
                return await _userRepository.GetUserByIdAsync(id);
            }
            catch (Exception ex)
            {
                throw new AppException("Service error fetching user by id.", ex);
            }
        }

        public async Task<IEnumerable<User>> GetAllUsersAsync()
        {
            try
            {
                return await _userRepository.GetAllUsersAsync();
            }
            catch (Exception ex)
            {
                throw new AppException("Service error fetching all users.", ex);
            }
        }

        public async Task AddUserAsync(User user)
        {
            try
            {
                await _userRepository.AddUserAsync(user);
            }
            catch (Exception ex)
            {
                throw new AppException("Service error adding user.", ex);
            }
        }

        public async Task UpdateUserAsync(User user)
        {
            try
            {
                await _userRepository.UpdateUserAsync(user);
            }
            catch (Exception ex)
            {
                throw new AppException("Service error updating user.", ex);
            }
        }

        public async Task DeleteUserAsync(Guid id)
        {
            try
            {
                await _userRepository.DeleteUserAsync(id);
            }
            catch (Exception ex)
            {
                throw new AppException("Service error deleting user.", ex);
            }
        }
    }
}
