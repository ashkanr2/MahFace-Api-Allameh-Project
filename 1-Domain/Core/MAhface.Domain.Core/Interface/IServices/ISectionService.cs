﻿using MAhface.Domain.Core.Entities.Study.Section;
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
        // Method for creating a new section
        Task<AddStatusVm> CreateSection(CreateSectionRequest request);
        Task<IEnumerable<SectionDto>> GetAllSectionsForCourse(Guid id);

        // Method for updating an existing section
        Task<UpdateStatus> UpdateSection(Guid sectionId, UpdateSectionRequest request);

        // Method for getting the details of a section
        Task<SectionDto> GetSectionDetails(Guid sectionId);
    }



}
