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
        private readonly ITeacherService _tcherService;
  
        public CoursesService(ITeacherService teacherService, ICourseripository coursesRepository, IMapper mapper, IImageService imageService)
        {
            _coursesRepository = coursesRepository;
            _mapper = mapper;
            _imageService=imageService;
            _tcherService = teacherService;
        }

        public async Task<CourseDto> GetCourseById(Guid id)
        {
            var course = await _coursesRepository.GetCourseById(id);
            var CourseDto = _mapper.Map<CourseDto>(course);

            return CourseDto;
        }

        public async Task<IEnumerable<CourseDto>> GetAllCourses()
        {
            var courses = await _coursesRepository.GetAllCourses();
            return _mapper.Map<IEnumerable<CourseDto>>(courses);
        }

        public async Task<AddStatusVm> AddCourse(CourseDto courseDto)
        {
            AddStatusVm addStatusVm = new AddStatusVm();
            Courses courses = new Courses();
            courses.Title= courseDto.Title;
            courses.Cost= courseDto.Cost;
            courses.CategoryId  = courseDto.CategoryId;
            courses.CourseLevelId = courseDto.CourseLevelId;
            courses.CourseDescription  = courseDto.CourseDescription;
            courses.Cost = courseDto.Cost;
            courses.ImageId = courseDto.ImageId;
            courses.TeacherId=courseDto.TeacherId;
            courses.StarsNumber= courseDto.StarsNumber;
            var teacher = await _tcherService.GetTeacherById(courseDto.TeacherId);
            if (teacher == null)
            {

                addStatusVm.IsValid = false;
                addStatusVm.StatusMessage="ایدی استاد به درستی وارد نشده است";
                return addStatusVm;
            }
            if (courseDto.ImageId.HasValue)
            {
            var existImage= _imageService.GetImageById(courseDto.ImageId.Value);
                if (existImage == null) {
                    addStatusVm.IsValid = false;
                    addStatusVm.StatusMessage="ایدی عکس به درستی وارد نشده است";
                    return addStatusVm;
                }
            }
            var result = await _coursesRepository.AddCourse(courses);
            return result;
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
