using ApiEndPoint.ViewModel;
using MAhface.Domain.Core1.Dto;
using MAhface.Domain.Core1.Interface.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace ApiEndPoint.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ViewsController : ControllerBase
    {
        private readonly IViewService _viewService;

        public ViewsController(IViewService viewService)
        {
            _viewService = viewService;
        }


        /// <summary>
        /// جزئیات یک View خاص را با شناسه یکتا بازیابی می‌کند.
        /// </summary>
        /// <param name="id">شناسه یکتای View.</param>
        /// <returns>
        /// اگر View پیدا شود، جزئیات آن را برمی‌گرداند. در غیر این صورت، پیامی در صورت بروز خطا نمایش داده می‌شود.
        /// </returns>


        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            try
            {
                var view = await _viewService.GetViewDetailsById(id);
                return Ok(view);
            }
            catch (Exception ex)
            {
                // Return a generic error message
                return StatusCode(500, new { message = ex.Message });
            }
        }

        /// <summary>
        /// بررسی می‌کند که آیا کاربر یک دوره خاص را مشاهده کرده است و در صورت موجود بودن، زمان آخرین ویدیو مشاهده‌شده را برمی‌گرداند.
        /// </summary>
        /// <param name="userId">شناسه یکتای کاربر.</param>
        /// <param name="courseId">شناسه یکتای دوره.</param>
        /// <returns>
        /// وضعیت اینکه آیا کاربر دوره را مشاهده کرده است و زمان آخرین ویدیو (در صورت موجود بودن) را برمی‌گرداند.
        /// </returns>


        [HttpGet("course/{courseId}/user/{userId}")]
        public async Task<IActionResult> HasUserViewedCourse(Guid userId, Guid courseId)
        {
            try
            {
                // Explicitly declare variable types during deconstruction
                (bool hasViewed, TimeOnly? lastVideoTime) = await _viewService.HasUserViewedCourse(userId, courseId);

                if (hasViewed)
                {
                    return Ok(new
                    {
                        hasViewed = true,
                        lastVideoTime = lastVideoTime?.ToString("HH:mm:ss")
                    });
                }

                return Ok(new { hasViewed = false });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message });
            }
        }


        [HttpGet("course/{courseId}")]
        public async Task<int> GetCourseView(Guid courseId)
        {
            try
            {
                // دریافت تعداد بازدیدها برای دوره مشخص
                var result = await _viewService.GetTotalViewsForCourse(courseId);
                if (result == null) result=0;
                return result;
            }
            catch (Exception ex)
            {
                // مدیریت خطا: ثبت یا گزارش خطا
                // اینجا می‌توانید خطا را لاگ کنید یا پیغام خطا را ارسال کنید
                // به عنوان مثال:
                Console.WriteLine($"Error occurred while getting views for course {courseId}: {ex.Message}");

                // اگر خطایی رخ دهد، می‌توانید 0 یا عدد دیگری را بازگشت دهید
                return 0;
            }
        }


        /// <summary>
        /// یک View جدید برای یک کاربر و دوره خاص اضافه می‌کند یا اگر View قبلاً وجود داشته باشد، آن را به‌روزرسانی می‌کند.
        /// اگر کاربر قبلاً دوره را مشاهده کرده باشد، زمان آخرین ویدیو به‌روزرسانی می‌شود.
        /// </summary>
        /// <param name="request">بدنه درخواست شامل  SectionId، UserId و LastVideoTime.</param>
        /// <returns>
        /// پیام وضعیت که نشان‌دهنده موفقیت یا شکست عملیات افزودن یا به‌روزرسانی View است.
        /// </returns>

        [HttpPost]
        public async Task<IActionResult> AddView([FromBody] AddViewRequest request)
        {
            try
            {
                var result = await _viewService.AddViewAsync(
                    request.SectionId,
                    request.UserId,
                    request.LastVideoTime
                );

                if (!result.IsValid)
                {
                    return BadRequest(new { message = result.StatusMessage });
                }

                return Ok(new { message = result.StatusMessage });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message });
            }
        }

    }

}
