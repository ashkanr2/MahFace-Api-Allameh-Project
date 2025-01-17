 
using MAhface.Domain.Core1.Dto;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Collections.Specialized.BitVector32;

namespace MAhface.Domain.Core1.Interface.IServices
{
    public interface IEpisodeService
    {
        // Method for creating a new section
        Task<AddStatusVm> CreateSection(CreateSectionRequest request);
        Task<IEnumerable<EpisodeDto>> GetAllSectionsForCourse(Guid id);

        // Method for updating an existing section
        Task<UpdateStatus> UpdateSection(Guid sectionId, UpdateSectionRequest request);

        // Method for getting the details of a section
        Task<EpisodeDto> GetSectionDetails(Guid sectionId);
        Task<AddStatusVm> UploadVideo(Guid sectionId, IFormFile videoFile);

        Task<bool> ValidateVideoUrlAsync(string url);

    }

    
}
