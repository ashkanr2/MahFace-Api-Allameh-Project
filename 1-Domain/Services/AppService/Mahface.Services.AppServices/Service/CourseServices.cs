using AutoMapper;
using MAhface.Domain.Core.Dto;
using MAhface.Domain.Core.Entities.Study.Course;
using MAhface.Domain.Core1.Interface.IServices;
using MAhface.Domain.Core1.Interface.IRipositories;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MAhface.Domain.Core.Interface.IRipositories;
using MAhface.Domain.Core1.Dto;
using MAhface.Domain.Core.Interface.IServices;

namespace  Mahface.Services.AppServices.Service
{
    public class CoursesService : ICourseService
    {
        private readonly ICourseRipository _repository;
        private readonly IMapper _mapper;

        public CoursesService(ICourseRipository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        // Get all courses
        public async Task<List<CourseDto>> GetAllCourses()
        {
            var courses = await _repository.GetAllCourses();
            return _mapper.Map<List<CourseDto>>(courses);
        }

        // Get a single course by ID
        public async Task<CourseDto> GetCourseById(Guid id)
        {
            var course = await _repository.GetCourseById(id);
            return _mapper.Map<CourseDto>(course);
        }

        // Add a new course
        public async Task<AddStatusVm> AddCourse(CourseDto courseDto)
        {
            try
            {
                var course = _mapper.Map<Courses>(courseDto);
                await _repository.AddCourse(course);
                return new AddStatusVm
                {
                    IsValid = true,
                    StatusMessage = "Course added successfully."
                };
            }
            catch (Exception ex)
            {
                return new AddStatusVm
                {
                    IsValid = false,
                    StatusMessage = $"Error while adding course: {ex.Message}"
                };
            }
        }

        // Update an existing course
        public async Task<AddStatusVm> UpdateCourse(CourseDto courseDto)
        {
            try
            {
                var course = _mapper.Map<Courses>(courseDto);
                await _repository.UpdateCourse(course);
                return new AddStatusVm
                {
                    IsValid = true,
                    StatusMessage = "Course updated successfully."
                };
            }
            catch (Exception ex)
            {
                return new AddStatusVm
                {
                    IsValid = false,
                    StatusMessage = $"Error while updating course: {ex.Message}"
                };
            }
        }

        // Delete a course
        public async Task<AddStatusVm> DeleteCourse(Guid id)
        {
            try
            {
                await _repository.DeleteCourse(id);
                return new AddStatusVm
                {
                    IsValid = true,
                    StatusMessage = "Course deleted successfully."
                };
            }
            catch (Exception ex)
            {
                return new AddStatusVm
                {
                    IsValid = false,
                    StatusMessage = $"Error while deleting course: {ex.Message}"
                };
            }
        }
    }
}
