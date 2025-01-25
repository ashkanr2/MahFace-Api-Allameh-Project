using MAhface.Domain.Core1.Entities.BasicInfo.Business;
using MAhface.Domain.Core1.Interface.IServices;
using MAhface.Domain.Core1.Dto; // Assuming your VM is in the "Dto" folder
using Microsoft.AspNetCore.Mvc;

namespace ApiEndPoint.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentCourseController : ControllerBase
    {
        private readonly IStudentCourseService _studentCourseService;

        public StudentCourseController(IStudentCourseService studentCourseService)
        {
            _studentCourseService = studentCourseService;
        }


        /// <summary>
        /// دریافت تمامی کاربرانی که یک دوره خاص را خریداری کرده‌اند
        /// این متد لیستی از کاربران را که دوره خاصی را خریداری کرده‌اند، برمی‌گرداند.
        /// </summary>

        [HttpGet("Course/{courseId}/Users")]
        public async Task<IActionResult> GetUsersInCourse(Guid courseId)
        {
            try
            {
                var users = await _studentCourseService.GetUsersCourses(courseId);
                return Ok(users);
            }
            catch (Exception ex)
            {
                // ثبت خطا (اختیاری)
                return BadRequest($"خطا در دریافت کاربران در دوره: {ex.Message}");
            }
        }
        /// <summary>
        /// بررسی خریداری دوره توسط یک کاربر خاص
        /// این متد بررسی می‌کند که آیا کاربر خاصی دوره مشخصی را خریداری کرده است یا خیر.
        /// </summary>

        [HttpGet("HasExistForUser")]
        public async Task<IActionResult> HasExistForUser(Guid courseId, Guid userId)
        {
            try
            {
                // بررسی وجود کاربر در دوره با استفاده از سرویس
                var result = await _studentCourseService.HasExist(userId, courseId);

                // بازگشت نتیجه
                return Ok(result); // اگر true یا false باشد، به‌صورت مناسب برگردانده می‌شود
            }
            catch (Exception ex)
            {
                // مدیریت خطا و بازگشت BadRequest با پیام مناسب
                return BadRequest($"خطا در بررسی وجود کاربر در دوره: {ex.Message}");
            }
        }


        /// <summary>
        /// افزودن یک دانش‌آموز به دوره خریداری شده
        /// این متد یک دانش‌آموز را به دوره‌ای که خریداری کرده است، اضافه می‌کند.
        /// </summary>

        [HttpPost("Add")]
        public async Task<IActionResult> AddStudentToCourse(StudentCoursesVm studentCoursesVm)
        {
            try
            {
                // نگاشت StudentCoursesVm به مدل موجود قبل از ارسال به سرویس
                var studentCourses = new StudentCourses
                {
                    UserId = studentCoursesVm.UserId,
                    CourseId = studentCoursesVm.CourseId
                };

                var result = await _studentCourseService.AddStudentToCourse(studentCourses);
                return Ok(result);
            }
            catch (Exception ex)
            {
                // ثبت خطا (اختیاری)
                return BadRequest($"خطا در افزودن دانش‌آموز به دوره: {ex.Message}");
            }
        }
        /// <summary>
        /// مدل داده برای افزودن یک دانش‌آموز به چند دوره مختلف
        /// این کلاس اطلاعات مربوط به یک دانش‌آموز (شناسه کاربر) و لیستی از شناسه‌های دوره‌ها را برای افزودن به سیستم ذخیره می‌کند.
        /// </summary>
        [HttpPost("AddMultiple")]
        public async Task<ActionResult<AddStatusVm>> AddMultipleStudentCourse(StudentMultipleCoursesVm studentCoursesVm)
        {
            try
            {
                
                var result = await _studentCourseService.AddStudentMultipleCourse(studentCoursesVm);
                return result;
            }
            catch (Exception ex)
            {
                // ثبت خطا (اختیاری)
                return BadRequest($"خطا در افزودن دانش‌آموز به دوره: {ex.Message}");
            }
        }

        /// <summary>
        /// حذف دانش‌آموز از دوره خریداری شده
        /// این متد یک دوره را از دوره‌ای که خریداری شده ی دانش اموز حذف می‌کند.
        /// </summary>

        [HttpDelete("Delete/{courseId}/{userId}")]
        public async Task<IActionResult> DeleteStudentFromCourse(Guid courseId, Guid userId)
        {
            try
            {
                var result = await _studentCourseService.DeleteStudentFromCourse(courseId, userId);
                return Ok(result);
            }
            catch (Exception ex)
            {
                // ثبت خطا (اختیاری)
                return BadRequest($"خطا در حذف دانش‌آموز از دوره: {ex.Message}");
            }
        }
    }
}
