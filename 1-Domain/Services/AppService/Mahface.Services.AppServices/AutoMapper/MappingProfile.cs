using AutoMapper;
using MAhface.Domain.Core.Dto;
using MAhface.Domain.Core.Entities.Study.Course;
using MAhface.Domain.Core.Entities.Study.Season;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mahface.Services.AppServices.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Seasons, SeasonsDto>();
            CreateMap<SeasonsDto, Seasons>();

            CreateMap<Courses, CourseDto>();
            CreateMap<CourseDto, Courses>();
        }
    }
}
