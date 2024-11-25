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
        
        Task<Sections> GetById(Guid id);
        Task<IEnumerable<Sections>> GetAll();
        Task<AddStatusVm> AddSection(Sections section);
        Task<AddStatusVm> UpdateSection(Sections section);
        Task<AddStatusVm> DeleteSection(Guid id);
    }
}
