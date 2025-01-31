using MAhface.Domain.Core.Dto;
using MAhface.Domain.Core.Entities.Study.Season;
using MAhface.Domain.Core1.Dto;
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

        public int GetCourseSeasonsCount(Guid courseId);

        public List<SeasonsDto> GetAllCourseSeasons(Guid CourseId);

        public SeasonsDto GetBySectionId(Guid SectionId);
        
        public SeasonsDto GetById(Guid Id);

        public string Update(SeasonsDto season);

        public AddStatusVm Create(SeasonsDto season);

        public TimeOnly CalculateSumSections(Guid SeasonId);

        Task<AddStatusVm> SeedData();

        Task<UpdateStatus> DeleteSeason(Guid id);


    }
}
