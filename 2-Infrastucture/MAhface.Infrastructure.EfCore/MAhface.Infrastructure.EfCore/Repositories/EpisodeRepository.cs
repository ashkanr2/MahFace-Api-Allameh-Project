 
using MAhface.Domain.Core1.Dto;
using MAhface.Domain.Core1.Entities.Study.Episode;
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
    public class EpisodeRepository : IEpisodeRepository
    {
        private readonly AllamehPrroject _context;

        public EpisodeRepository(AllamehPrroject context)
        {
            _context = context;
        }

        // Create a section
        public async Task<Episode> CreateAsync(Episode section)
        {
            try
            {


                _context.Episodes.Add(section);
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
        public async Task<Episode> GetByIdAsync(Guid sectionId)
        {
            return await _context.Episodes.FirstOrDefaultAsync(s => s.Id == sectionId );
        }

        // Get the count of videos (sections) for a specific course and season
        public async Task<int> GetVideoCountForCourse(Guid courseId, Guid seasonId)
        {
            return await _context.Episodes.CountAsync(s => s.CourseId == courseId && s.SeasionnId == seasonId );
        }

        // Update a section
        public async Task<Episode> UpdateAsync(Episode section)
        {
            _context.Episodes.Update(section);
            await _context.SaveChangesAsync();
            return section;
        }

        public async Task<IQueryable<Episode>> GetAll()
        {
            try
            {
                return _context.Episodes.AsQueryable();
            }
            catch (Exception ex)
            {
                // Log exception if needed
                throw new Exception($"An error occurred while fetching all sections: {ex.Message}", ex);
            }
        }
    }
}


