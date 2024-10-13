using MAhface.Domain.Core.Entities.BasicInfo.Accounting;
using MAhface.Domain.Core1.Interface.IRipositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MAhface.Domain.Core1.Dto;
using Microsoft.AspNetCore.Identity;
using MAhface.Infrastructure.EfCore.DBContext;

namespace MAhface.Infrastructure.EfCore.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly AllamehPrroject _context;
        private readonly UserManager<User> _userManager;
        public UserRepository(AllamehPrroject context, UserManager<User> userManager)
        {
            _context = context;
            _userManager=userManager;
        }

        public async Task<User> GetUserByIdAsync(Guid id)
        {
            try
            {
                return await _context.Set<User>().FindAsync(id);
            }
            catch (Exception ex)
            {
                // Handle exception (log it, rethrow it, etc.)
                throw new AppException("Error fetching user by id.", ex);
            }
        }

        public async Task<IEnumerable<User>> GetAllUsersAsync()
        {
            try
            {
                return await _context.Set<User>().ToListAsync();
            }
            catch (Exception ex)
            {
                // Handle exception
                throw new AppException("Error fetching all users.", ex);
            }
        }

        public async Task AddUserAsync(User user)
        {
            try
            {
                await _context.Set<User>().AddAsync(user);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                // Handle exception
                throw new AppException("Error adding user.", ex);
            }
        }

        public async Task UpdateUserAsync(User user)
        {
            try
            {
                _context.Set<User>().Update(user);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                // Handle exception
                throw new AppException("Error updating user.", ex);
            }
        }

        public async Task DeleteUserAsync(Guid id)
        {
            try
            {
                var user = await GetUserByIdAsync(id);
                if (user == null)
                {
                    throw new AppException("User not found.");
                }
                _context.Set<User>().Remove(user);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                // Handle exception
                throw new AppException("Error deleting user.", ex);
            }
        }

        public async Task<bool> Register(User user , string password)
        {
            try
            {
                var result = await _userManager.CreateAsync(user ,password );
                await _context.SaveChangesAsync();
                return true;
            }

            catch (Exception)
            {

                throw;
                return false;
            }
            return false;
        }

        public Task<IQueryable<User>> GetallUsers()
        {
            return Task.FromResult(_context.Set<User>().AsQueryable());
        }



    }
}
