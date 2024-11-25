using MAhface.Domain.Core.Entities.BasicInfo.Business;
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
    public class ViewRepository : IViewRepository
    {
        private readonly AllamehPrroject _context;

        public ViewRepository(AllamehPrroject context)
        {
            _context = context;
        }

        public async Task<View> GetById(Guid id)
        {
            try
            {
                return await _context.Set<View>().FindAsync(id);
            }
            catch (Exception ex)
            {
                // Log exception (use logging library, e.g., Serilog)
                throw new Exception("An error occurred while retrieving the View by ID.", ex);
            }
        }

        public async Task<View> GetByUserAndSectionId(Guid userId, Guid sectionId)
        {
            try
            {
                return await _context.Set<View>()
                    .FirstOrDefaultAsync(v => v.UserId == userId && v.SectionId == sectionId);
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while retrieving the View by User and Course ID.", ex);
            }
        }

        public async Task<IEnumerable<View>> GetByCourseId(Guid courseId)
        {
            try
            {
                return await _context.Set<View>()
                    .Where(v => v.CourseId == courseId)
                    .ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while retrieving Views by Course ID.", ex);
            }
        }

        public async Task<int> CountOfCourseView(Guid courseId)
        {
            try
            {
                return await _context.Set<View>()
                    .CountAsync(v => v.CourseId == courseId);
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while counting Views for the Course.", ex);
            }
        }

        public async Task<int> CountOfCourseViewForUser(Guid userId)
        {
            try
            {
                return await _context.Set<View>()
                    .CountAsync(v => v.UserId == userId);
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while counting Views for the User.", ex);
            }
        }
        public async Task AddView(View view)
        {
            try
            {
                // Add the new View entity
                await _context.Set<View>().AddAsync(view);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while adding the View.", ex);
            }
        }

        public async Task UpdateView(View view)
        {
            try
            {
                _context.Set<View>().Update(view);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while updating the View.", ex);
            }
        }

    }

}
