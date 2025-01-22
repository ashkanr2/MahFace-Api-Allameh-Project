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
using Microsoft.EntityFrameworkCore;
using MAhface.Domain.Core.Entities.BasicInfo.Business;
using System.Data;

namespace Mahface.Services.AppServices.Service
{
    public class CoursesService : ICourseService
    {
        private readonly ICourseRipository _repository;
        private readonly ISeasonService _seasonService;
        private readonly IEpisodeService _sectionService;
        private readonly IUserService _userService;
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;
        private readonly IViewService _viewService;
        private readonly IImageService _imageService;
        public CoursesService(ICourseRipository repository, IMapper mapper, ISeasonService seasonService, IEpisodeService sectionService,
            IUserService userService, ICategoryService categoryService, IViewService viewService, IImageService imageService)
        {
            _repository = repository;
            _mapper = mapper;
            _seasonService = seasonService;
            _sectionService = sectionService;
            _userService = userService;
            _categoryService = categoryService;
            _viewService = viewService;
            _imageService = imageService;
        }

        // Get all courses
        public async Task<List<CourseDto>> GetAllCourses()
        {
            var courses = await _repository.GetAllCourses();
            var result = _mapper.Map<List<CourseDto>>(courses);
            foreach (var course in result)
            {
                var sumSeasons = _seasonService.GetAllCourseSeasons(course.Id).Count;
                var sumSection = await _sectionService.GetAllSectionsForCourse(course.Id);
                var userTeacher = await _userService.GetUserByTeacherId(course.TeacherId);
                var sumView = await _viewService.GetTotalViewsForCourse(course.Id);
                var category = await _categoryService.GetCategoryByIdAsync(course.CategoryId);
                course.TotalSeasons = sumSeasons;
                course.TotalSections = sumSection.Count();
                course.TotalDuration = 100;
                course.TeacherName = userTeacher.Firstname + " " + userTeacher.LastName;
                course.CategoryName=category.Title;
                course.TotalView= sumView == 0 ? 0 : sumView;

            }

            return result;
        }



        public async Task<List<CourseVm>> GetCoursesListAsync()
        {
            try
            {

                var courses = await _repository.NewGetAllCourses().ToListAsync();
                foreach (var course in courses)
                {
                    var sumSeasons = _seasonService.GetCourseSeasonsCount(course.Id);
                    var sumSection = _sectionService.GetEpisodeCountOfCourse(course.Id);
                    var sumView = await _viewService.GetTotalViewsForCourse(course.Id);
                    course.TotalSeasons = sumSeasons;
                    course.TotalSections = sumSection;
                    course.TotalDuration = 100;
                    course.TotalView= sumView == 0 ? 0 : sumView;

                }
                return courses; // به‌طور مستقیم نتیجه را برمی‌گردانیم
            }
            catch (Exception ex)
            {
                // لاگ و هندل کردن خطا
                throw new Exception("Error executing query for courses list.", ex);
            }
        }



        public async Task<List<CourseVm>> GetAllCoursesWithFilterCategoryId(Guid categoryId)
        {
            try
            {

                var courses = await _repository.NewGetAllCourses().Where(c => c.CategoryId == categoryId).ToListAsync();
                foreach (var course in courses)
                {
                    var sumSeasons = _seasonService.GetCourseSeasonsCount(course.Id);
                    var sumSection = _sectionService.GetEpisodeCountOfCourse(course.Id);
                    var sumView = await _viewService.GetTotalViewsForCourse(course.Id);
                    course.TotalSeasons = sumSeasons;
                    course.TotalSections = sumSection;
                    course.TotalDuration = 100;
                    course.TotalView= sumView == 0 ? 0 : sumView;

                }
                return courses; // به‌طور مستقیم نتیجه را برمی‌گردانیم
            }
            catch (Exception ex)
            {
                // لاگ و هندل کردن خطا
                throw new Exception("Error executing query for courses list.", ex);
            }

        }


        public async Task<List<NavVM>> GetAllCoursesTitleWithCategoryId(Guid categoryId)
        {
            try
            {

                var courses = await _repository.NewGetAllCourses().Where(c => c.CategoryId == categoryId).Select(x => new NavVM(){ Id= x.Id,Title= x.Title }).ToListAsync();
                 return courses;
            }
            catch (Exception ex)
            {
                // لاگ و هندل کردن خطا
                throw new Exception("Error executing query for courses list.", ex);
            }

        }

        public async Task<List<CourseVm>> GetAllCoursesWithFilter(string Input)
        {
            try
            {
                 
                                       
                var courses = await _repository.NewGetAllCourses().Where(c => EF.Functions.Like(c.Title, $"%{Input}%")).ToListAsync();
                foreach (var course in courses)
                {
                    var sumSeasons = _seasonService.GetCourseSeasonsCount(course.Id);
                    var sumSection = _sectionService.GetEpisodeCountOfCourse(course.Id);
                    var sumView = await _viewService.GetTotalViewsForCourse(course.Id);
                    course.TotalSeasons = sumSeasons;
                    course.TotalSections = sumSection;
                    course.TotalDuration = 100;
                    course.TotalView= sumView == 0 ? 0 : sumView;

                }
                return courses; // به‌طور مستقیم نتیجه را برمی‌گردانیم
            }
            catch (Exception ex)
            {
                // لاگ و هندل کردن خطا
                throw new Exception("Error executing query for courses list.", ex);
            }
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
            var sumSeasons = _seasonService.GetAllCourseSeasons(course.Id);
            var sumSection = await _sectionService.GetAllSectionsForCourse(course.Id);
            var sumView = await _viewService.GetTotalViewsForCourse(course.Id);
            // Map the course entity to the CourseDto
            var result = _mapper.Map<CourseDto>(course);

            // Set total values
            result.TotalSeasons = sumSeasons.Count();
            result.TotalSections =sumSection.Count();
            result.TotalDuration = 100;////sumSection.Sum(s => s.Duration); // Assuming each section has a Duration field
            result.TotalView =sumView;
            result.CategoryName=category.Title;
            var courseDetail = _mapper.Map<CourseDetail>(result);
            courseDetail.TeacherName = userTeacher.Firstname + " " + userTeacher.LastName;
            // Set the seasons and their respective sections
            courseDetail.Seasons = sumSeasons.Select(season => new SeasonSVM
            {
                Id = season.Id.Value,
                Title = season.Title,
                SeasonsDescription = season.SeasonsDescription,
                CreatedAt=season.CreatedDate
            }).ToList();

            return courseDetail;
        }


        // Add a new course
        public async Task<AddStatusVm> AddCourse(AddCourseVm addCourse)
        {
            Courses courses = new();
            AddStatusVm addImageResult = new AddStatusVm() { IsValid= false };
            if (addCourse.ImageBase64 != null)
            {
                ImageDto image = new ImageDto();
                image.Url =addCourse.Title;
                image.Base64File= addCourse.ImageBase64;
                addImageResult = await _imageService.AddImage(image);
            }
            courses.Id = new Guid();
            courses.Title = addCourse.Title;
            courses.CourseLevelId = addCourse.CourseLevelId;
            courses.TeacherId = addCourse.TeacherId;
            courses.CategoryId = addCourse.CategoryId;
            courses.CourseDescription = addCourse.CourseDescription;
            courses.Cost = addCourse.Cost; courses.ISActive = true;
            courses.ImageId = addImageResult.IsValid ? addImageResult.AddedId : null;
            courses.IsDeleted=false;
            courses.ISActive=true;
            courses.CreatedUserID=addCourse.CreatedUserID;
            courses.CreatedDate=DateTime.Now;


            var addResult = await _repository.AddCourse(courses);
            return addResult;

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
