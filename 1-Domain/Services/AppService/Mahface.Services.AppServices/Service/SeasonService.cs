using MAhface.Domain.Core.Dto;
using MAhface.Domain.Core1.Interface.IRipositories;
using MAhface.Domain.Core1.Interface.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mahface.Services.AppServices.Service
{
    public class SeasonService : ISeasonService
    {
        private readonly ISeasonRipository _seasonRipository;
        public SeasonService(ISeasonRipository seasonRipository)
        {
            _seasonRipository= seasonRipository;
        }
        public string Create(SeasonsDto season)
        {
            throw new NotImplementedException();
        }

        public List<SeasonsDto> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<SeasonsDto> GetAllCourseSeasons(Guid CourseId)
        {
            throw new NotImplementedException();
        }

        public SeasonsDto GetById(Guid Id)
        {
            throw new NotImplementedException();
        }

        public List<SeasonsDto> GetBySectionId(Guid SectionId)
        {
            throw new NotImplementedException();
        }

        public string Update(SeasonsDto season)
        {
            throw new NotImplementedException();
        }
    }
}
