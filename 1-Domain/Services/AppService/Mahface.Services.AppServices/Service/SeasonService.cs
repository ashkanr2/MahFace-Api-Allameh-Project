using AutoMapper;
using MAhface.Domain.Core.Dto;
using MAhface.Domain.Core.Entities.Study.Course;
using MAhface.Domain.Core.Entities.Study.Season;
using MAhface.Domain.Core1.Interface.IRipositories;
using MAhface.Domain.Core1.Interface.IServices;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mahface.Services.AppServices.Service
{
    public class SeasonService : ISeasonService
    {
        private readonly ISeasonRipository _seasonRepository;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IMapper _mapper;

        public SeasonService(ISeasonRipository seasonRepository, IMapper mapper, IHttpContextAccessor httpContextAccessor)
        {
            _seasonRepository = seasonRepository;
            _httpContextAccessor = httpContextAccessor;
            _mapper = mapper;
        }

        public string Create(SeasonsDto seasonDto)
        {
            var ip = _httpContextAccessor.HttpContext.Connection.RemoteIpAddress.ToString();
            var season = _mapper.Map<Seasons>(seasonDto);
            season.Description="Created By Ip = "+ ip;
            return _seasonRepository.Create(season);
        }

        public List<SeasonsDto> GetAll()
        {
            var seasons = _seasonRepository.GetAll();
            return _mapper.Map<List<SeasonsDto>>(seasons);
        }

        public List<SeasonsDto> GetAllCourseSeasons(Guid courseId)
        {
            var seasons = _seasonRepository.GetAll().Where(s => s.CourseId == courseId).ToList();
            return _mapper.Map<List<SeasonsDto>>(seasons);
        }

        public SeasonsDto GetById(Guid id)
        {
            var season = _seasonRepository.GetById(id);
            return _mapper.Map<SeasonsDto>(season);
        }

        public SeasonsDto GetBySectionId(Guid sectionId)
        {
            var date = new DateTime();
            date=DateTime.Now;
            ///var seasons = _seasonRepository.GetAll().Where(s => s..Any(sec => sec.Id == sectionId)).ToList();
            var seasons = _seasonRepository.GetAll().FirstOrDefault();
            return _mapper.Map<SeasonsDto>(seasons);
        }

        public string Update(SeasonsDto seasonDto)
        {
            var ip = _httpContextAccessor.HttpContext.Connection.RemoteIpAddress.ToString();
            var season = _mapper.Map<Seasons>(seasonDto);
            season.Description="**Updated By Ip = "+ ip +"date : "+DateTime.Now.ToString();
            return _seasonRepository.Update(season);
        }
    }

}
