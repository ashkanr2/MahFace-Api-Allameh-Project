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
