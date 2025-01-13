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

namespace Mahface.Services.AppServices.Service
{
    public class CoursesService : ICourseService
    {
        private readonly ICourseRipository _repository;
        private readonly ISeasonService _seasonService;
        private readonly ISectionService _sectionService;
        private readonly IUserService _userService;
        private readonly ICategoryService  _categoryService;
        private readonly IMapper _mapper;
        private readonly IViewService _viewService;
        public CoursesService(ICourseRipository repository, IMapper mapper,ISeasonService seasonService , ISectionService sectionService ,
            IUserService userService , ICategoryService categoryService,IViewService viewService)
        {
            _repository = repository;
            _mapper = mapper;
            _seasonService = seasonService;
            _sectionService = sectionService;
            _userService = userService; 
            _categoryService = categoryService;
            _viewService = viewService;
        }

        // Get all courses
        public async Task<List<CourseDto>> GetAllCourses()
        {
            var courses = await _repository.GetAllCourses();
            var result = _mapper.Map<List<CourseDto>>(courses);
            foreach (var course in result)
            {
                var sumSeasons =  _seasonService.GetAllCourseSeasons(course.Id).Count;
                var sumSection = await _sectionService.GetAllSectionsForCourse(course.Id);  
                var userTeacher = await _userService.GetUserByTeacherId(course.TeacherId);
                var sumView = await _viewService.CountOfCourseView(course.Id);
                var category = await _categoryService.GetCategoryByIdAsync(course.CategoryId);
                course.TotalSeasons = sumSeasons;
                course.TotalSections = sumSection.Count();
                course.TotalDuration = 100;
                course.TeacherName = userTeacher.Firstname + " " + userTeacher.LastName;
                course.CategoryName=category.Title;
                course.TotalView= sumView == 0 ?  new Random().Next(100,10000) : sumView;
                
            }

            return result;
        }

        public async Task<CourseDetail> GetCourseById(Guid id)
        {
            // Fetch the course data from the repository
            var course = await _repository.GetCourseById(id);
            var userTeacher = await _userService.GetUserByTeacherId(course.TeacherId.Value);
            var category = await _categoryService.GetCategoryByIdAsync(course.CategoryId);
            if (course == null)
            {
                return null; // Or handle not found error appropriately
            }

            // Get the total number of seasons and sections for the course
            var sumSeasons =  _seasonService.GetAllCourseSeasons(course.Id);
            var sumSection = await _sectionService.GetAllSectionsForCourse(course.Id);

            // Map the course entity to the CourseDto
            var result = _mapper.Map<CourseDto>(course);

            // Set total values
            result.TotalSeasons = sumSeasons.Count();
            result.TotalSections = sumSection.Count();
            result.TotalDuration = 100;////sumSection.Sum(s => s.Duration); // Assuming each section has a Duration field
            result.TotalView =new Random().Next(100, 10000);
            result.CategoryName=category.Title;
            var courseDetail = _mapper.Map<CourseDetail>(result);
            courseDetail.TeacherName = userTeacher.Firstname + " " + userTeacher.LastName;
            // Set the seasons and their respective sections
            courseDetail.Seasons = sumSeasons.Select(season => new SeasonSVM
            {
                Id = season.Id.Value,
                Title = season.Title,
                SeasonsDescription = season.SeasonsDescription,
                Sections = sumSection.Where(s => s.Id == season.Id)
                                     .Select(section => new SectionsVm { Id = section.Id ,  URL = section.Id.ToString() })
                                     .ToList()
            }).ToList();

            return courseDetail;
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
