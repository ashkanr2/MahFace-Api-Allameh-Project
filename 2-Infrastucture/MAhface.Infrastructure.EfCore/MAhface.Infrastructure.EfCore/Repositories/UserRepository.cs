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
       

        public async Task<Guid> GetAdminUserId()
        {
            try
            {
                var admin = await _context.Users.FirstOrDefaultAsync(x => x.IsSystemAdmin);
                return admin.Id;
            }
            catch (Exception ex)
            {
                // Handle exception (log it, rethrow it, etc.)
                throw new AppException("Error fetching user by id.", ex);
            }
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


        public async Task<User> GetUserByTeacherIdAsync(Guid teacherId)
        {
            try
            {
                var teacher =  _context.Teachers.FirstOrDefault(x=>x.Id == teacherId);
                return await _context.Set<User>().FindAsync(teacher.UserId);

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

        public async Task<UpdateStatus> UpdateUserAsync(User user)
        {
            try
            {
                var lastIsteacherStatus =await GetUserByIdAsync(user.Id);
                user.IsTeacher = lastIsteacherStatus.IsTeacher;
                
                _context.Set<User>().Update(user);
                await _context.SaveChangesAsync();
                UpdateStatus updateStatus = new UpdateStatus();
                updateStatus.IsValid=true;
                updateStatus.StatusMessage= "با موفقیت تغییر کرد";
                return updateStatus;
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

        public async Task<AddStatusVm> Register(User user , string password)
        {
            AddStatusVm vm = new AddStatusVm();
            try
            {
                
                var result = await _userManager.CreateAsync(user ,password );
                vm.IsValid = result.Succeeded;
                vm.AddedId=user.Id;
                vm.StatusMessage = result.Errors.FirstOrDefault()?.Description ?? "با موقیت اضافه شد ";
                await _context.SaveChangesAsync();
                return vm;
            }

            catch (Exception)
            {

                throw;
                 
            }
           
        } 

        public Task<IQueryable<User>> GetallUsers()
        {
            return Task.FromResult(_context.Set<User>().AsQueryable());
        }

        public async Task<UpdateStatus> EmailConfirm(Guid userId )
        {
            UpdateStatus vm = new UpdateStatus();
            try
            {
                var user = await GetUserByIdAsync(userId);
                user.EmailConfirmed = true;
                var updateResult = await UpdateUserAsync(user); 
                vm.IsValid = updateResult.IsValid;
                vm.StatusMessage = updateResult.IsValid ? "با موفقیت تأیید شد" :  updateResult.StatusMessage;
                return vm;
            }

            catch (Exception)
            {

                throw;

            }
        }

       
        public async Task<UpdateStatus> EmailConfirmWithToken(Guid userId, string emailToken)
        {
            UpdateStatus vm = new UpdateStatus();
            try
            {
                var user = await GetUserByIdAsync(userId);
                var confirmResult = _userManager.ConfirmEmailAsync(user, emailToken);
                vm.IsValid = confirmResult.IsCompleted;
                vm.StatusMessage = confirmResult.Result.Succeeded ? "با موفقیت تأیید شد" : string.Join(" ، ", confirmResult.Result.Errors.Select(e => e.Description));
                await _context.SaveChangesAsync();
                return vm;
            }

            catch (Exception)
            {

                throw;

            }
        }
    }
}
