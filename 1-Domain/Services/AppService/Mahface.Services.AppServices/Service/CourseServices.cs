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
namespace Mahface.Services.AppServices.Service
{
    public class CourseServices : ICourseService
    {
        private readonly ICourseripository _courseRepository;
        private readonly IMapper _mapper;

        public CourseServices(ICourseripository courseRepository, IMapper mapper)
        {
            _courseRepository = courseRepository;
            _mapper = mapper;
        }

        public string Create(CourseDto courseDto)
        {
            try
            {
                var course = _mapper.Map<Courses>(courseDto);
                return _courseRepository.Create(course);
            }
            catch (Exception ex)
            {
                // Log the exception
                return $"Error: {ex.Message}";
            }
        }

        public List<CourseDto> GetAll()
        {
            try
            {
                var courses = _courseRepository.GetAll();
                return _mapper.Map<List<CourseDto>>(courses);
            }
            catch (Exception ex)
            {
                // Log the exception
                return new List<CourseDto> { new CourseDto { Title = $"Error: {ex.Message}" } };
            }
        }

        public List<CourseDto> GetByCategoryId(Guid categoryId)
        {
            try
            {
                var courses = _courseRepository.GetAll().Where(c => c.CategoryId == categoryId).ToList();
                return _mapper.Map<List<CourseDto>>(courses);
            }
            catch (Exception ex)
            {
                // Log the exception
                return new List<CourseDto> { new CourseDto { Title = $"Error: {ex.Message}" } };
            }
        }

        public CourseDto GetById(Guid id)
        {
            try
            {
                var course = _courseRepository.GetById(id);
                return _mapper.Map<CourseDto>(course);
            }
            catch (Exception ex)
            {
                // Log the exception
                return new CourseDto { Title = $"Error: {ex.Message}" };
            }
        }

        public List<CourseDto> GetByTeacherId(Guid teacherId)
        {
            try
            {
                var courses = _courseRepository.GetAll().Where(c => c.TeacherId == teacherId).ToList();
                return _mapper.Map<List<CourseDto>>(courses);
            }
            catch (Exception ex)
            {
                // Log the exception
                return new List<CourseDto> { new CourseDto { Title = $"Error: {ex.Message}" } };
            }
        }

        public List<CourseDto> GetStudentId(Guid studentId)
        {
            try
            {
                var courses = _courseRepository.GetAll().Where(c => c.Students.Any(s => s.Id == studentId)).ToList();
                return _mapper.Map<List<CourseDto>>(courses);
            }
            catch (Exception ex)
            {
                // Log the exception
                return new List<CourseDto> { new CourseDto { Title = $"Error: {ex.Message}" } };
            }
        }

        public string IsDeleted(Guid id)
        {
            try
            {
                var course = _courseRepository.GetById(id);
                if (course != null)
                {
                    course.IsDeleted = true; // Assuming there's an IsDeleted property
                    return _courseRepository.Update(course);
                }
                return "Course not found";
            }
            catch (Exception ex)
            {
                // Log the exception
                return $"Error: {ex.Message}";
            }
        }

        public string Update(CourseDto courseDto)
        {
            try
            {
                var course = _mapper.Map<Courses>(courseDto);
                return _courseRepository.Update(course);
            }
            catch (Exception ex)
            {
                // Log the exception
                return $"Error: {ex.Message}";
            }
        }
    }
}
