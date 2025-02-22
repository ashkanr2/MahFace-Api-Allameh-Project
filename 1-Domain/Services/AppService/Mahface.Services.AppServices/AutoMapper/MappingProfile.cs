﻿using AutoMapper;
using MAhface.Domain.Core.Dto;
using MAhface.Domain.Core.Entities.BasicInfo.Accounting;
using MAhface.Domain.Core.Entities.BasicInfo.Business;
using MAhface.Domain.Core.Entities.Study.Course;
using MAhface.Domain.Core.Entities.Study.Season;
 
using MAhface.Domain.Core1.Dto;
using MAhface.Domain.Core1.Entities.BasicInfo.Accounting;
using MAhface.Domain.Core1.Entities.BasicInfo.Business;
using MAhface.Domain.Core1.Entities.Study.Episode;
using MAhface.Domain.Core1.Enums;
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
            CreateMap<Image, ImageDto>().ReverseMap();
            CreateMap<User, UserDto>();
            CreateMap<UserDto, User>();
            CreateMap<View, ViewDTO>();
            CreateMap<ViewDTO, View>();
            CreateMap<EpisodeDto, Episode>().ReverseMap();
            //CreateMap<Sections, SectionDto>().ReverseMap();

            CreateMap<Courses, CourseDto>()
           .ForMember(dest => dest.ImageDto, opt => opt.MapFrom(src => src.Image != null
           ? new ImageDto
           {
               Base64File = src.Image.Base64File,
               Url = src.Image.Url
           }
           : null))
           .ForMember(dest => dest.Description , opt => opt.MapFrom(src=> src.Description))
           .ReverseMap();

            CreateMap<CourseDto, CourseVm>()
                //.ForMember(dest => dest.ImageBase64, opt => opt.MapFrom(src => src.ImageDto != null ? src.ImageDto.Base64File : null))
                //.ForMember(dest => dest.ImageUrl, opt => opt.MapFrom(src => src.ImageDto != null ? src.ImageDto.Url : null))
                .ForMember(dest => dest.CategoryName , opt=>opt.MapFrom(src=>src.CategoryName!=null ? src.CategoryName : null))
                 .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                .ReverseMap();



            CreateMap<CourseDto, CourseDetail>()
                .ForMember(dest => dest.TeacherName, opt => opt.MapFrom(src => src.TeacherName))
                .ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.CategoryName))
                .ForMember(dest => dest.ImageBase64, opt => opt.MapFrom(src => src.ImageDto != null ?  src.ImageDto.Base64File : null))
                .ForMember(dest => dest.ImageUrl, opt => opt.MapFrom(src => src.ImageDto != null ? src.ImageDto.Url : null))
                .ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.CategoryName!=null ? src.CategoryName : null))
                .ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.CategoryName!=null ? src.CategoryName : null))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                .ForMember(dest => dest.Seasons, opt => opt.Ignore());

            CreateMap<SeasonsDto, SeasonSVM>()
                 .ForMember(dest => dest.Title, opt => opt.MapFrom(src => src.Title))
                 .ForMember(dest => dest.SeasonsDescription, opt => opt.MapFrom(src => src.SeasonsDescription))
                 .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                 .ForMember(dest => dest.Sections, opt => opt.Ignore());
            // Map SectionDto to SectionsVm
            //CreateMap<SectionDto, SectionsVm>()
            //    .ForMember(dest => dest.URL, opt => opt.MapFrom(src => src.Url));


            CreateMap<Courses, CourseVm>()
                 .ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.category!=null ? src.category.Title : null))
                  .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                .ReverseMap();
            
            CreateMap<EditUserVm, User>().ReverseMap();
            CreateMap<UserDto, EditUserVm>()
                .ForMember(dest => dest.Firstname, opt => opt.MapFrom(src => src.Firstname))
                .ForMember(dest => dest.LastName, opt => opt.MapFrom(src => src.LastName))
                .ForMember(dest => dest.BirthDate, opt => opt.MapFrom(src => src.BirthDate))
                .ForMember(dest => dest.NationalCode, opt => opt.MapFrom(src => src.NationalCode))
                .ForMember(dest => dest.PhoneNumber, opt => opt.MapFrom(src => src.PhoneNumber))
                .ForMember(dest => dest.Base64Profile, opt => opt.MapFrom(src => src.Base64Profile));


           // CreateMap<Sections, SectionDto>()
           //.ForMember(dest => dest.SeasonName, opt => opt.MapFrom(src => src.Season.Title)); // Assuming the Season entity has a 'Name' property

           // // Map CreateSectionRequest to Sections entity
           // CreateMap<CreateSectionRequest, Sections>();


     
            CreateMap<TeacherRequests, TeacherRequestVm>()
                .ForMember(dest => dest.Status, opt => opt.MapFrom(src => ((TeacherRequestStatusEnum)src.StatusCode).GetDisplayName()));
       

    }
    }
}
