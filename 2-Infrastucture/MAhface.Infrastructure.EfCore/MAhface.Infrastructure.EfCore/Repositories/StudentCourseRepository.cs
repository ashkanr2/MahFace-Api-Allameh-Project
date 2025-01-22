using MAhface.Domain.Core1.Dto;
using MAhface.Domain.Core1.Entities.BasicInfo.Business;
using MAhface.Domain.Core1.Interface.IRipositories;
using MAhface.Infrastructure.EfCore.DBContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAhface.Infrastructure.EfCore.Repositories
{
    public class StudentCourseRepository : IStudentCourseRipository
    {
        private readonly DbContext _context;

        public StudentCourseRepository(DbContext context)
        {
            _context = context;
        }

        public async Task<AddStatusVm> Add(StudentCourses studentCourses)
        {
            try
            {
                studentCourses.Id = Guid.NewGuid(); // مقداردهی شناسه جدید

                _context.Set<StudentCourses>().Add(studentCourses);
                await _context.SaveChangesAsync();

                return new AddStatusVm
                {
                    IsValid = true,
                    StatusMessage = "Successfully added.",
                    AddedId = studentCourses.Id
                };
            }
            catch (Exception ex)
            {
                return new AddStatusVm
                {
                    IsValid = false,
                    StatusMessage = $"Error: {ex.Message}",
                    AddedId = null
                };
            }
        }

        public async Task<UpdateStatus> Update(StudentCourses studentCourses)
        {
            try
            {
                var existingRecord = await _context.Set<StudentCourses>()
                    .FirstOrDefaultAsync(sc => sc.Id == studentCourses.Id);

                if (existingRecord == null)
                {
                    return new UpdateStatus
                    {
                        IsValid = false,
                        StatusMessage = "Record not found."
                    };
                }

                // اعمال تغییرات
                existingRecord.UserId = studentCourses.UserId;
                existingRecord.CourseId = studentCourses.CourseId;

                _context.Set<StudentCourses>().Update(existingRecord);
                await _context.SaveChangesAsync();

                return new UpdateStatus
                {
                    IsValid = true,
                    StatusMessage = "Successfully updated."
                };
            }
            catch (Exception ex)
            {
                return new UpdateStatus
                {
                    IsValid = false,
                    StatusMessage = $"Error: {ex.Message}"
                };
            }
        }

        public async Task<List<Guid>> GetUserCoursesId(Guid userId)
        {
            return await _context.Set<StudentCourses>()
                .Where(sc => sc.UserId == userId)
                .Select(sc => sc.CourseId)
                .ToListAsync();
        }

        public async Task<List<Guid>> GetCourseUsersId(Guid courseId)
        {
            return await _context.Set<StudentCourses>()
                .Where(sc => sc.CourseId == courseId)
                .Select(sc => sc.UserId)
                .ToListAsync();
        }

        public async Task<UpdateStatus> Delete(Guid courseId, Guid userId)
        {
            try
            {
                var studentCourse = await _context.Set<StudentCourses>()
                    .FirstOrDefaultAsync(sc => sc.CourseId == courseId && sc.UserId == userId);

                if (studentCourse == null)
                {
                    return new UpdateStatus
                    {
                        IsValid = false,
                        StatusMessage = "Record not found."
                    };
                }

                _context.Set<StudentCourses>().Remove(studentCourse);
                await _context.SaveChangesAsync();

                return new UpdateStatus
                {
                    IsValid = true,
                    StatusMessage = "Successfully deleted."
                };
            }
            catch (Exception ex)
            {
                return new UpdateStatus
                {
                    IsValid = false,
                    StatusMessage = $"Error: {ex.Message}"
                };
            }
        }
    }

}
