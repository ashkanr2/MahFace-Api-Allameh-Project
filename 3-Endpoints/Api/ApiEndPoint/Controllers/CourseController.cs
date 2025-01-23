using AutoMapper;
using MAhface.Domain.Core.Dto;
using MAhface.Domain.Core.Entities.Study.Course;
using MAhface.Domain.Core.Interface.IServices;
using MAhface.Domain.Core1.Dto;
using MAhface.Domain.Core1.Interface.IServices;
using Microsoft.AspNetCore.Mvc;

namespace ApiEndPoint.Controllers
{


    public class CourseController : ControllerBase
    {
        private readonly ICourseService _coursesService;
        private readonly IStudentCourseService _studentCourseService;

        private readonly IMapper _mapper;

        public CourseController(ICourseService coursesService, IMapper mapper, IStudentCourseService studentCourseService)
        {
            _coursesService = coursesService;
            _mapper = mapper;
            _studentCourseService=studentCourseService;
        }

        [HttpGet("GetById/{id}")]
        public async Task<ActionResult<CourseDetail>> GetById(Guid id)
        {
            var courseDetail = await _coursesService.GetCourseById(id);
            if (courseDetail == null)
            {
                return NotFound();
            }

            return Ok(courseDetail);
        }


        [HttpGet("GetByIdForUpdate/{id}")]
        public async Task<ActionResult<CourseDetail>> GetByIdForUpdate(Guid id)
        {
            var courseDetail = await _coursesService.GetCourseById(id);
            if (courseDetail == null)
            {
                return NotFound();
            }

            return Ok(courseDetail);
        }


        [HttpGet("GetAllCourses")]
        public async Task<ActionResult<IEnumerable<CourseVm>>> GetAllCourses()
        {
            var courses = await _coursesService.GetCoursesListAsync();

            return Ok(courses);
        }




        [HttpGet("GetAllCoursesWithCategoryId/{categoryId}")]
        public async Task<ActionResult<IEnumerable<CourseVm>>> GetAllCoursesWithCategoryId(Guid categoryId)
        {
            var courses = await _coursesService.GetAllCoursesWithFilterCategoryId(categoryId);

            return Ok(courses);
        }

        [HttpGet("GetAllCoursesTitleWithCategoryId/{categoryId}")]
        public async Task<ActionResult<IEnumerable<NavVM>>> GetAllCoursesTitleWithCategoryId(Guid categoryId)
        {
            var courses = await _coursesService.GetAllCoursesTitleWithCategoryId(categoryId);
            return Ok(courses);
        }




        [HttpGet("GetAllCoursesWithSearch/")]
        public async Task<ActionResult<IEnumerable<CourseVm>>> GetAllCoursesWithSearch(string SearchInput)
        {
            var courses = await _coursesService.GetAllCoursesWithFilter(SearchInput);

            return Ok(courses);
        }

        [HttpGet("GetAllStudentCourses/{userId}")]
        public async Task<IActionResult> GetAllStudentCourses(Guid userId)
        {
            try
            {
                var courses = await _studentCourseService.GetUserCourses(userId);
                return Ok(courses);
            }
            catch (Exception ex)
            {
                // ثبت خطا (اختیاری)
                return BadRequest($"خطا در دریافت دوره‌های کاربر: {ex.Message}");
            }
        }


        //[HttpGet("GetAllStudentFavoritsCourses/{userId}")]
        //public async Task<IActionResult> GetAllStudentFavoritsCourses(Guid userId)
        //{
        //    try
        //    {

        //      return Ok(courses);
        //    }
        //    catch (Exception ex)
        //    {
        //        // ثبت خطا (اختیاری)
        //        return BadRequest($"خطا در دریافت دوره‌های کاربر: {ex.Message}");
        //    }
        //}


        [HttpGet("GetAllTeacherCourses/{userId}")]
        public async Task<IActionResult> GetAllTeacherCourses(Guid userId)
        {
            try
            {
                var courses = await _coursesService.GetAllTeacherCourses(userId);
                return Ok(courses);
            }
            catch (Exception ex)
            {
                // ثبت خطا (اختیاری)
                return BadRequest($"خطا در دریافت دوره‌های کاربر: {ex.Message}");
            }
        }




        [HttpPost("AddCourse")]
        public async Task<AddStatusVm> AddCourse([FromBody] AddCourseVm courseVm)
        {
            
            try
            {
                var result = await _coursesService.AddCourse(courseVm);
                return result;

            }
            catch (Exception ex) {

                AddStatusVm addStatusVm = new AddStatusVm();
                addStatusVm.IsValid=false;
                addStatusVm.StatusMessage="با خطا مواجه شد مجدد تلاش کنید";
                return addStatusVm; 
            }
        }


        [HttpPut("UpdateCourse/{id}")]
        public async Task<UpdateStatus> UpdateCourse(Guid id , [FromBody] AddCourseVm courseVm)
        {
            try
            {
                var result = await _coursesService.UpdateCourse(id ,courseVm);
                return result;

            }
            catch (Exception ex)
            {
                UpdateStatus result = new UpdateStatus();
                result.IsValid=false;
                result.StatusMessage="با خطا مواجه شد مجدد تلاش کنید";
                return result;
            }
        }

        [HttpDelete("DeleteCourse/{id}")]
        public async Task<UpdateStatus> DeleteCourse(Guid id)
        {
            var result = await _coursesService.DeleteCourse(id);
            return result;
        }



    }
}
