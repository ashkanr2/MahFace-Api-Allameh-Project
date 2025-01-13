using MAhface.Domain.Core.Entities.Study.Section;
using MAhface.Domain.Core1.Dto;
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
    public class SectionRepository : ISectionRepository
    {
        private readonly AllamehPrroject _context;

        public SectionRepository(AllamehPrroject context)
        {
            _context = context;
        }

        // Create a section
        public async Task<Sections> CreateAsync(Sections section)
        {
            try{


                _context.Sections.Add(section);
                await _context.SaveChangesAsync();
                return section;
            }
            catch (Exception ex)
            {
                // Log exception if needed
                throw new Exception($"An error occurred while fetching all sections: {ex.Message}", ex);
            }
        }

        // Get section by ID
        public async Task<Sections> GetByIdAsync(Guid sectionId)
        {
            return await _context.Sections.FirstOrDefaultAsync(s => s.Id == sectionId && !s.IsDeleted);
        }

        // Get the count of videos (sections) for a specific course and season
        public async Task<int> GetVideoCountForCourse(Guid courseId, Guid seasonId)
        {
            return await _context.Sections.CountAsync(s => s.CourseId == courseId && s.SeasionnId == seasonId && !s.IsDeleted);
        }

        // Update a section
        public async Task<Sections> UpdateAsync(Sections section)
        {
            _context.Sections.Update(section);
            await _context.SaveChangesAsync();
            return section;
        }

        public async Task<IQueryable<Sections>> GetAll()
        {
            try
            {
                return _context.Sections.AsQueryable();
            }
            catch (Exception ex)
            {
                // Log exception if needed
                throw new Exception($"An error occurred while fetching all sections: {ex.Message}", ex);
            }
        }
    }
}


