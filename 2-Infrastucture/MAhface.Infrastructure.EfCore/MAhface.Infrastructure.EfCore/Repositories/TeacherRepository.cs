using MAhface.Domain.Core.Entities.BasicInfo.Accounting;
using MAhface.Domain.Core.Entities.Study;
using MAhface.Domain.Core.Interface.IRipositories;
using MAhface.Domain.Core1.Dto;
using MAhface.Domain.Core1.Interface.IRipositories;
using MAhface.Infrastructure.EfCore.DBContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MAhface.Infrastructure.EfCore.Repositories
{

    public class TeacherRepository : ITeacherRepository
    {
        private readonly AllamehPrroject _context;

        public TeacherRepository(AllamehPrroject context)
        {
            _context = context;
        }

        // Method to create a teacher using UserId
        public async Task<AddStatusVm> CreateTeacher(Guid userId)
        {
            AddStatusVm vm = new AddStatusVm();
            try
            {
                var user = await _context.Users.FirstOrDefaultAsync(u => u.Id == userId);
                if (user == null)
                {
                    vm.IsValid = false;
                    vm.StatusMessage="کاربر یافت نشد ";
                   
                }

                var teacher = new Teacher
                {
                    UserId = userId,
                    User = user,
                    ISActive = true, // Default active
                    IsDeleted = false, // Default not deleted
                    CreatedUserID = userId, // Assuming the teacher created himself/herself
                    CreatedDate = DateTime.Now
                };
                user.IsTeacher=true;
                user.IsStudent=false;
                _context.Teachers.Add(teacher);
                await _context.SaveChangesAsync();
                vm.IsValid=true;
                vm.StatusMessage="با موفقیت اضافه شد";

                return vm;
            }
            catch (Exception ex)
            {
                // Log or handle the exception
                throw new Exception("Error occurred while creating teacher", ex);
            }
        }

        // Method to get all active teachers (ISActive = true)
        public async Task<IEnumerable<Teacher>> GetAllActiveTeachers()
        {
            try
            {
                return await _context.Teachers
                    .Include(t => t.User)
                    .Where(t => t.ISActive && !t.IsDeleted)
                    .ToListAsync();
            }
            catch (Exception ex)
            {
                // Log or handle the exception
                throw new Exception("Error occurred while retrieving active teachers", ex);
            }
        }

        // Method to get all inactive teachers (IsDeleted = true or ISActive = false)
        public async Task<IEnumerable<Teacher>> GetAllInactiveTeachers()
        {
            try
            {
                return await _context.Teachers
                    .Include(t => t.User)
                    .Where(t => t.IsDeleted || !t.ISActive)
                    .ToListAsync();
            }
            catch (Exception ex)
            {
                // Log or handle the exception
                throw new Exception("Error occurred while retrieving inactive teachers", ex);
            }
        }

        // Method to "delete" a teacher (mark as IsDeleted = true)
        public async Task DeleteTeacher(Guid teacherId)
        {
            try
            {
                var teacher = await _context.Teachers.FirstOrDefaultAsync(t => t.Id == teacherId);
                if (teacher != null)
                {
                    teacher.IsDeleted = true;
                    teacher.DeletedDate = DateTime.Now;
                    await _context.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                // Log or handle the exception
                throw new Exception("Error occurred while deleting teacher", ex);
            }
        }


        public async Task UpdateTeacher(Teacher teacher)
        {
            try
            {
                var existingTeacher = await _context.Teachers.FindAsync(teacher.Id);
                if (existingTeacher != null)
                {
                    _context.Entry(existingTeacher).CurrentValues.SetValues(teacher);
                    await _context.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                // Log or handle exception
                throw new Exception("Error occurred while updating the teacher", ex);
            }
        }

        public async Task<Teacher> GetTeacherById(Guid teacherId)
        {
            try
            {

                var result = await _context.Teachers.FirstOrDefaultAsync(x => x.Id==teacherId);
                return result;

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
