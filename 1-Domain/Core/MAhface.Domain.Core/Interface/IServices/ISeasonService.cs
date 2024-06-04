using MAhface.Domain.Core.Dto;
using MAhface.Domain.Core.Entities.Study.Season;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAhface.Domain.Core1.Interface.IServices
{
    public interface ISeasonService
    {
        public List<SeasonsDto> GetAll();

        public List<SeasonsDto> GetAllCourseSeasons(Guid CourseId);

        public List<SeasonsDto> GetBySectionId(Guid SectionId);
        
        public SeasonsDto GetById(Guid Id);

        public string Update(SeasonsDto season);

        public string Create(SeasonsDto season);



       
    }
}
