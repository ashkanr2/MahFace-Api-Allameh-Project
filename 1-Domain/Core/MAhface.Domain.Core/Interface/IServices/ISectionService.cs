using MAhface.Domain.Core.Entities.Study.Section;
using MAhface.Domain.Core1.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Collections.Specialized.BitVector32;

namespace MAhface.Domain.Core1.Interface.IServices
{
    public interface ISectionService
    {
        Task<SectionDto> AddSectionAsync(SectionDto sectionDto);
        Task<SectionDto> UpdateSectionAsync(SectionDto sectionDto);
        Task<bool> DeleteSectionAsync(Guid id);
        Task<SectionDto> GetSectionByIdAsync(Guid id);
        Task<IEnumerable<SectionDto>> GetAllSectionsAsync();
        Task<IEnumerable<SectionDto>> GetAllSectionsForCourse(Guid id);
      

    }


}
