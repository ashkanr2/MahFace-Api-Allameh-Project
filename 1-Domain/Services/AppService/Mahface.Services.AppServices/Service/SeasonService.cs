using AutoMapper;
using MAhface.Domain.Core.Dto;
using MAhface.Domain.Core.Entities.Study.Course;
using MAhface.Domain.Core.Entities.Study.Season;
using MAhface.Domain.Core.Interface.IRipositories;
using MAhface.Domain.Core.Interface.IServices;
using MAhface.Domain.Core1.Dto;
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
        private readonly ICourseRipository _courseRipository;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IEpisodeRepository _episodeRepository;
        private readonly IMapper _mapper;

        // در اینجا، ICourseService به صورت Lazy تزریق می‌شود
        public SeasonService(ISeasonRipository seasonRepository, IMapper mapper, IHttpContextAccessor httpContextAccessor, 
            ICourseRipository courseRipository , IEpisodeRepository episodeRepository)
        {
            _seasonRepository = seasonRepository;
            _httpContextAccessor = httpContextAccessor;
            _mapper = mapper;
            _courseRipository=courseRipository;
            _episodeRepository = episodeRepository;
        }

        public TimeOnly CalculateSumSections(Guid SeasonId)
        {
            throw new NotImplementedException();
        }

        public string Create(SeasonsDto seasonDto)
        {
            var ip = _httpContextAccessor.HttpContext.Connection.RemoteIpAddress.ToString();
            var season = _mapper.Map<Seasons>(seasonDto);
            season.Description="Created By Ip = "+ ip;
            return _seasonRepository.Create(season);
        }

        public async Task<UpdateStatus> DeleteSeason(Guid id)
        {
            try
            {
                var model = _seasonRepository.GetById(id);
                if (model == null)
                {
                    return new UpdateStatus
                    {
                        IsValid = false,
                        StatusMessage="این فصل یافت نشد "
                    };
                }
                _seasonRepository.DeleteById(id);
                
                return new UpdateStatus
                {
                    IsValid = true,
                    StatusMessage="با موفقیت حذف شد"
                };

            }
            catch (Exception ex)
            {
                return new UpdateStatus
                {
                    IsValid = false,
                    StatusMessage="خطا در  حذف فصل لطفا مجدد تلاش کنید  "
                };
            }
        }

        public List<SeasonsDto> GetAll()
        {
            var seasons = _seasonRepository.GetAll();
            var seasonsDto = _mapper.Map<List<SeasonsDto>>(seasons);

            return seasonsDto;
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

        public int GetCourseSeasonsCount(Guid courseId)
        {
            return _seasonRepository.GetCount(courseId);
        }

        public async Task<AddStatusVm> SeedData()
        {
            var courses = await _courseRipository.GetAllCourses();
            var seasons = new List<Seasons>();
            var adminUserId = Guid.Parse("85f9967b-1011-40c0-a32e-87370b013966");
            foreach (var course in courses)
            {
                seasons.Add(new Seasons()
                {
                    Id = Guid.NewGuid(),
                    CourseId = course.Id,
                    Title = "فصل اول",  // "First Season"
                    SeasonsDescription = " توضیحات  فصل یک : " + course.Title,  // "Description of first season"
                    CreatedUserID = adminUserId,
                    CreatedDate = course.CreatedDate,
                    IsDeleted = false,
                    ISActive = true,
                });

                seasons.Add(new Seasons()
                {
                    Id = Guid.NewGuid(),
                    CourseId = course.Id,
                    Title = "فصل دوم",  // "Second Season"
                    SeasonsDescription = " توضیحات  فصل دوم : " + course.Title,  // "Description of second season"
                    CreatedUserID = adminUserId,
                    CreatedDate = course.CreatedDate,
                    IsDeleted = false,
                    ISActive = true,
                });

                seasons.Add(new Seasons()
                {
                    Id = Guid.NewGuid(),
                    CourseId = course.Id,
                    Title = "فصل سوم",  // "Third Season"
                    SeasonsDescription = " توضیحات  فصل سوم : " + course.Title,  // "Description of third season"
                    CreatedUserID =adminUserId,
                    CreatedDate = course.CreatedDate,
                    IsDeleted = false,
                    ISActive = true,
                });

                seasons.Add(new Seasons()
                {
                    Id = Guid.NewGuid(),
                    CourseId = course.Id,
                    Title = "فصل چهارم",  // "Fourth Season"
                    SeasonsDescription = " توضیحات  فصل چهارم : " + course.Title,  // "Description of fourth season"
                    CreatedUserID = adminUserId,
                    CreatedDate = course.CreatedDate,
                    IsDeleted = false,
                    ISActive = true,
                });
            }
            var result = _seasonRepository.SeedData(seasons);
            return result;
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
