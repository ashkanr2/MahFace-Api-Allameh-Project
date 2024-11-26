﻿using AutoMapper;
using MAhface.Domain.Core.Dto;
using MAhface.Domain.Core.Entities.BasicInfo.Accounting;
using MAhface.Domain.Core.Entities.BasicInfo.Business;
using MAhface.Domain.Core.Entities.Study.Course;
using MAhface.Domain.Core.Entities.Study.Season;
using MAhface.Domain.Core.Entities.Study.Section;
using MAhface.Domain.Core1.Dto;
using MAhface.Domain.Core1.Entities.BasicInfo.Business;
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

           
            CreateMap<CourseDto, Courses>()
            .ForMember(dest => dest.Image, opt => opt.MapFrom(src => src.ImageDto));
            CreateMap<Image, ImageDto>();

            CreateMap<Courses, CourseDto>()
             .ForMember(dest => dest.ImageDto, opt => opt.MapFrom(src => src.Image));
            CreateMap<Image, ImageDto>();

            CreateMap<User, UserDto>();
            CreateMap<UserDto, User>();


            CreateMap<View, ViewDTO>();
            CreateMap<ViewDTO ,View >();

            CreateMap<Sections, SectionDto>().ReverseMap();


        }
    }
}
