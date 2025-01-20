 
using MAhface.Domain.Core1.Dto;
using MAhface.Domain.Core1.Entities.Study.Episode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAhface.Domain.Core1.Interface.IRipositories
{
    public interface IEpisodeRepository
    {
        // Method for creating a new section
        Task<Episode> CreateAsync(Episode section);

        // Method for getting a section by its ID
        Task<IQueryable<Episode>> GetAll();
        int GetEpisodeCountOfCourse(Guid courseId);

       // Method for getting the count of videos (sections) for a specific course and season
       Task<int> GetVideoCountForCourse(Guid courseId, Guid seasonId);

        // Method for updating an existing section
        Task<Episode> UpdateAsync(Episode section);

        Task<Episode> GetByIdAsync(Guid sectionId);
    }

}
