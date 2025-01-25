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
        /// <summary>
        /// دریافت جزئیات یک دوره بر اساس شناسه
        /// این متد اطلاعات کامل یک دوره را با استفاده از شناسه آن برمی گرداند.
        /// </summary>

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

        /// <summary>
        /// دریافت اطلاعات یک دوره برای ویرایش
        /// این متد اطلاعات یک دوره را برای آماده‌سازی ویرایش برمی گرداند.
        /// </summary>

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

        /// <summary>
        /// دریافت لیست تمامی دوره‌ها
        /// این متد لیستی از تمام دوره‌های موجود در سیستم را برمی‌گرداند.
        /// </summary>

        [HttpGet("GetAllCourses")]
        public async Task<ActionResult<IEnumerable<CourseVm>>> GetAllCourses()
        {
            var courses = await _coursesService.GetCoursesListAsync();

            return Ok(courses);
        }



        /// <summary>
        /// دریافت لیست دوره‌های مرتبط با یک دسته‌بندی خاص
        /// این متد لیستی از دوره‌هایی را که در یک دسته‌بندی خاص قرار دارند، برمی گرداند.
        /// </summary>

        [HttpGet("GetAllCoursesWithCategoryId/{categoryId}")]
        public async Task<ActionResult<IEnumerable<CourseVm>>> GetAllCoursesWithCategoryId(Guid categoryId)
        {
            var courses = await _coursesService.GetAllCoursesWithFilterCategoryId(categoryId);

            return Ok(courses);
        }
        /// <summary>
        /// دریافت عناوین دوره‌های مرتبط با یک دسته‌بندی خاص
        /// این متد فقط عناوین دوره‌های موجود در یک دسته‌بندی مشخص را برمی‌گرداند.
        /// </summary>

        [HttpGet("GetAllCoursesTitleWithCategoryId/{categoryId}")]
        public async Task<ActionResult<IEnumerable<NavVM>>> GetAllCoursesTitleWithCategoryId(Guid categoryId)
        {
            var courses = await _coursesService.GetAllCoursesTitleWithCategoryId(categoryId);
            return Ok(courses);
        }


        /// <summary>
        /// جستجو در لیست دوره‌ها
        /// این متد لیست دوره‌هایی را که با ورودی جستجو مطابقت دارند، برمی گرداند.
        /// </summary>
        [HttpGet("GetAllCoursesWithSearch/")]
        public async Task<ActionResult<IEnumerable<CourseVm>>> GetAllCoursesWithSearch(string SearchInput)
        {
            var courses = await _coursesService.GetAllCoursesWithFilter(SearchInput);

            return Ok(courses);
        }
        /// <summary>
        /// دریافت لیست دوره‌های دانشجو
        /// این متد لیستی از دوره‌هایی را که یک دانشجو  آن ها را خریداری کرده است، برمی‌گرداند.
        /// </summary>

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

        /// <summary>
        /// دریافت لیست دوره‌های مدرس
        /// این متد لیستی از دوره‌هایی را که یک مدرس  ثبت کرده است را ، برمی گرداند.
        /// </summary>
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



        /// <summary>
        /// افزودن دوره جدید
        /// این متد یک دوره جدید را با استفاده از اطلاعات ورودی ایجاد و در سیستم ذخیره می‌کند.
        /// </summary>
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

        /// <summary>
        /// به‌روزرسانی اطلاعات یک دوره
        /// این متد اطلاعات یک دوره موجود را بر اساس شناسه آن و داده‌های ورودی به‌روزرسانی می‌کند.
        /// </summary>
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

        /// <summary>
        /// حذف یک دوره
        /// این متد یک دوره خاص را با استفاده از شناسه آن از سیستم حذف می‌کند.
        /// </summary>

        [HttpDelete("DeleteCourse/{id}")]
        public async Task<UpdateStatus> DeleteCourse(Guid id)
        {
            var result = await _coursesService.DeleteCourse(id);
            return result;
        }



    }
}
