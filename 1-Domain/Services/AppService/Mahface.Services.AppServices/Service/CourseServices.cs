using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MAhface.Domain.Core.Dto;
using MAhface.Domain.Core.Entities.Study.Course;
using MAhface.Domain.Core.Interface.IRipositories;
using MAhface.Domain.Core.Interface.IServices;
using MAhface.Domain.Core1.Dto;
using MAhface.Domain.Core1.Entities.BasicInfo.Business;
using MAhface.Domain.Core1.Interface.IServices;
namespace Mahface.Services.AppServices.Service
{
    public class CoursesService : ICoursesService
    {
        private readonly ICourseripository _coursesRepository;
        private readonly IMapper _mapper;
        private readonly IImageService _imageService;
        public CoursesService(ICourseripository coursesRepository, IMapper mapper, IImageService imageService)
        {
            _coursesRepository = coursesRepository;
            _mapper = mapper;
            _imageService=imageService;
        }

        public async Task<CourseDto> GetCourseById(Guid id)
        {
            var course = await _coursesRepository.GetCourseById(id);
            var CourseDto =  _mapper.Map<CourseDto>(course);
          
            return CourseDto;
        }

        public async Task<IEnumerable<CourseDto>> GetAllCourses()
        {
            var courses = await _coursesRepository.GetAllCourses();
            return _mapper.Map<IEnumerable<CourseDto>>(courses);
        }

        public async Task AddCourse(CourseDto courseDto)
        {
            var course = _mapper.Map<Courses>(courseDto);
            await _coursesRepository.AddCourse(course);
        }

        public async Task UpdateCourse(CourseDto courseDto)
        {
            var course = _mapper.Map<Courses>(courseDto);
            await _coursesRepository.UpdateCourse(course);
        }

        public async Task DeleteCourse(Guid id)
        {
            await _coursesRepository.DeleteCourse(id);
        }
    }
}
