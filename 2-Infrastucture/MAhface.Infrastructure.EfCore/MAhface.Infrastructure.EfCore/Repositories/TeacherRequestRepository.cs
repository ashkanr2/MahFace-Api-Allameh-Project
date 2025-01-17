using MAhface.Domain.Core1.Dto;
using MAhface.Domain.Core1.Entities.BasicInfo.Accounting;
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
    public class TeacherRequestRepository : ITeacherRequestRepository
    {
        private readonly AllamehPrroject _context;

        public TeacherRequestRepository(AllamehPrroject context)
        {
            _context = context;
        }

        public async Task AddTeacherRequest(TeacherRequests teacherRequest)
        {
            await _context.TeacherRequests.AddAsync(teacherRequest);
            await _context.SaveChangesAsync();
        }

        public async Task<List<TeacherRequests>> GetAllRequests()
        {
            return await _context.TeacherRequests.Where(x=>!x.IsDeleted).ToListAsync();
        }

        public async Task<TeacherRequests> GetRequestById(Guid requestId)
        {
            return await _context.TeacherRequests
                                 .AsNoTracking()
                                 .Where(x => !x.IsDeleted)
                                 .FirstOrDefaultAsync(x => x.Id == requestId);
        }

        public async Task<TeacherRequests> GetRequestByUserId(Guid userId)
        {
            return await _context.TeacherRequests
                                 .AsNoTracking()
                                 .Where(x => !x.IsDeleted)
                                 .FirstOrDefaultAsync(x => x.UserId == userId);
        }


        public async Task UpdateRequest(TeacherRequests teacherRequest)
        {
            try
            {
                var existingRequest = await _context.TeacherRequests
                    .FirstOrDefaultAsync(x => x.Id == teacherRequest.Id);

                if (existingRequest != null)
                {
                    existingRequest.StatusCode = teacherRequest.StatusCode;
                    existingRequest.AdminDescription = teacherRequest.AdminDescription;
                    existingRequest.AdminResponseDate = teacherRequest.AdminResponseDate;
                    existingRequest.IsDeleted = teacherRequest.IsDeleted;

                    // Mark the entity as modified but do not modify Code field
                    _context.Entry(existingRequest).State = EntityState.Modified;
                    await _context.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                throw new AppException("Error updating request.", ex);
            }
        }

    }
}
