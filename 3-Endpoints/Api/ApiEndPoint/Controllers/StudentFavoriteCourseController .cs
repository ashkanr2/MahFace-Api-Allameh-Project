using MAhface.Domain.Core1.Dto;
using MAhface.Domain.Core1.Entities.BasicInfo.Accounting;
using MAhface.Domain.Core1.Entities.BasicInfo.Business;
using MAhface.Domain.Core1.Interface.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiEndPoint.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentFavoriteCourseController : ControllerBase
    {
        private readonly IStudentFavoritsCourseService _studentFavoritsCourseService;

        public StudentFavoriteCourseController(IStudentFavoritsCourseService studentFavoritsCourseService)
        {
            _studentFavoritsCourseService = studentFavoritsCourseService;
        }

        /// <summary>
        /// دریافت تمامی کاربرانی که دوره خاصی را به عنوان دوره مورد علاقه خود اضافه کرده‌اند
        /// این متد لیستی از کاربران را که دوره خاصی را به عنوان دوره مورد علاقه خود اضافه کرده‌اند، برمی‌گرداند.
        /// </summary>
        [HttpGet("Course/{courseId}/Users")]
        public async Task<IActionResult> GetUsersInFavoriteCourse(Guid courseId)
        {
            try
            {
                var users = await _studentFavoritsCourseService.GetUsersCourses(courseId);
                return Ok(users);
            }
            catch (Exception ex)
            {
                // ثبت خطا (اختیاری)
                return BadRequest($"خطا در دریافت کاربران در دوره مورد علاقه: {ex.Message}");
            }
        }

        /// <summary>
        /// بررسی اضافه شدن یک دوره به عنوان دوره مورد علاقه توسط یک کاربر خاص
        /// این متد بررسی می‌کند که آیا کاربر خاصی دوره مشخصی را به عنوان دوره مورد علاقه خود اضافه کرده است یا خیر.
        /// </summary>
        [HttpGet("HasExistForUser")]
        public async Task<IActionResult> HasExistForUser(Guid courseId, Guid userId)
        {
            try
            {
                // بررسی وجود دوره در فهرست دوره‌های مورد علاقه کاربر
                var result = await _studentFavoritsCourseService.HasExist(userId, courseId);
                return Ok(result); // اگر true یا false باشد، به‌صورت مناسب برگردانده می‌شود
            }
            catch (Exception ex)
            {
                // مدیریت خطا و بازگشت BadRequest با پیام مناسب
                return BadRequest($"خطا در بررسی اضافه شدن دوره به دوره‌های مورد علاقه: {ex.Message}");
            }
        }

        /// <summary>
        /// افزودن یک دانش‌آموز به دوره مورد علاقه
        /// این متد یک دانش‌آموز را به عنوان دوره مورد علاقه‌اش به یک دوره خاص اضافه می‌کند.
        /// </summary>
        [HttpPost("Add")]
        public async Task<IActionResult> AddStudentToFavoriteCourse(StudentFavoriteCoursesVm studentFavoriteCoursesVm)
        {
            try
            {
                // نگاشت StudentFavoriteCoursesVm به مدل موجود قبل از ارسال به سرویس
                var studentFavoriteCourses = new StudentFavoriteCourses
                {
                    UserId = studentFavoriteCoursesVm.UserId,
                    CourseId = studentFavoriteCoursesVm.CourseId
                };

                var result = await _studentFavoritsCourseService.AddStudentToCourse(studentFavoriteCourses);
                return Ok(result);
            }
            catch (Exception ex)
            {
                // ثبت خطا (اختیاری)
                return BadRequest($"خطا در افزودن دانش‌آموز به دوره مورد علاقه: {ex.Message}");
            }
        }

        /// <summary>
        /// افزودن یک دانش‌آموز به چند دوره مختلف به عنوان دوره‌های مورد علاقه
        /// این متد دانش‌آموز را به لیستی از دوره‌ها به عنوان دوره‌های مورد علاقه اضافه می‌کند.
        /// </summary>
        [HttpPost("AddMultiple")]
        public async Task<ActionResult<AddStatusVm>> AddMultipleStudentFavoriteCourse(StudentMultipleCoursesVm studentCoursesVm)
        {
            try
            {
                var result = await _studentFavoritsCourseService.AddStudentMultipleCourse(studentCoursesVm);
                return result;
            }
            catch (Exception ex)
            {
                // ثبت خطا (اختیاری)
                return BadRequest($"خطا در افزودن دانش‌آموز به دوره‌های مورد علاقه: {ex.Message}");
            }
        }

        /// <summary>
        /// حذف یک دانش‌آموز از دوره مورد علاقه
        /// این متد دانش‌آموز را از دوره‌ای که آن را به عنوان دوره مورد علاقه خود انتخاب کرده است، حذف می‌کند.
        /// </summary>
        [HttpDelete("Delete/{courseId}/{userId}")]
        public async Task<IActionResult> DeleteStudentFromFavoriteCourse(Guid courseId, Guid userId)
        {
            try
            {
                var result = await _studentFavoritsCourseService.DeleteStudentFromCourse(courseId, userId);
                return Ok(result);
            }
            catch (Exception ex)
            {
                // ثبت خطا (اختیاری)
                return BadRequest($"خطا در حذف دانش‌آموز از دوره‌های مورد علاقه: {ex.Message}");
            }
        }

        /// <summary>
        /// بارگذاری داده‌های اولیه برای دوره‌های مورد علاقه
        /// این متد برای افزودن داده‌های اولیه یا تصادفی به دوره‌های مورد علاقه دانش‌آموزان استفاده می‌شود.
        /// </summary>
        [HttpPost("SeedData")]
        public async Task<IActionResult> SeedData()
        {
            try
            {
                var result = await _studentFavoritsCourseService.SeedData();
                return Ok(result);
            }
            catch (Exception ex)
            {
                // ثبت خطا (اختیاری)
                return BadRequest($"خطا در بارگذاری داده‌های اولیه: {ex.Message}");
            }
        }
    }

}
