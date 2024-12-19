using MAhface.Domain.Core.Entities.Study.Section;
using MAhface.Domain.Core1.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAhface.Domain.Core1.Interface.IRipositories
{
    public interface ISectionRepository
    {
        // Method for creating a new section
        Task<Sections> CreateAsync(Sections section);

        // Method for getting a section by its ID
        Task<IQueryable<Sections>> GetAll();

        // Method for getting the count of videos (sections) for a specific course and season
        Task<int> GetVideoCountForCourse(Guid courseId, Guid seasonId);

        // Method for updating an existing section
        Task<Sections> UpdateAsync(Sections section);

        Task<Sections> GetByIdAsync(Guid sectionId);
    }

}
