using ApiEndPoint.ViewModel;
using MAhface.Domain.Core1.Dto;
using MAhface.Domain.Core1.Interface.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiEndPoint.Controllers
{


    [Route("api/[controller]")]
    [ApiController]
    public class SectionController : ControllerBase
    {
        private readonly IEpisodeService _episodeService;

        public SectionController(IEpisodeService episodeService)
        {
            _episodeService = episodeService;
        }





        /// <summary>
        /// دریافت جزئیات یک بخش بر اساس شناسه
        /// این متد اطلاعات یک بخش را با استفاده از شناسه آن بازیابی می‌کند.
        /// </summary>

        // Get section details
        [HttpGet("GetSectionDetails/{sectionId}")]
        public async Task<ActionResult<EpisodeDto>> GetSectionDetails(Guid sectionId)
        {
            var sectionDto = await _episodeService.GetSectionDetails(sectionId);
            if (sectionDto == null)
            {
                return NotFound("Section not found");
            }
            return Ok(sectionDto);
        }

        /// <summary>
        /// دریافت تمامی بخش‌های مربوط به یک فصل
        /// این متد لیستی از بخش‌های مربوط به یک فصل خاص را برمی‌گرداند.
        /// </summary>

        [HttpGet("GetAllSeasonSection/{seasonId}")]
        public async Task<IActionResult> GetAllSeasonSection(Guid seasonId)
        {
            var sectionDto = await _episodeService.GetAllSectionsForSeason(seasonId);
            if (sectionDto == null)
            {
                return NotFound("Section not found");
            }
            return Ok(sectionDto);
        }

        /// <summary>
        /// دریافت تمامی بخش‌های مربوط به یک دوره خاص
        /// این متد لیستی از بخش‌های مربوط به یک دوره خاص را برمی‌گرداند.
        /// </summary>

        [HttpGet("GetAllCourseSection/{courseId}")]
        public async Task<IActionResult> GetAllSectionCourse(Guid courseId)
        {
            var sectionDto = await _episodeService.GetAllSectionsForCourse(courseId);
            if (sectionDto == null)
            {
                return NotFound("Section not found");
            }
            return Ok(sectionDto);
        }

        /// <summary>
        /// به‌روزرسانی بخش
        /// این متد اطلاعات یک بخش موجود را با استفاده از شناسه آن و داده‌های ورودی به‌روزرسانی می‌کند.
        /// </summary>
        [HttpPut("UpdateSection/{sectionId}")]
        public async Task<ActionResult<UpdateStatus>> UpdateSection(Guid sectionId, [FromBody] UpdateSectionRequest request)
        {
            var result = await _episodeService.UpdateSection(sectionId, request);
            return Ok(result);
        }
        /// <summary>
        /// ایجاد بخش جدید
        /// این متد یک بخش جدید را با استفاده از داده‌های ورودی ایجاد می‌کند.
        /// </summary>
        [HttpPost("CreateSection")]
        public async Task<ActionResult<AddStatusVm>> CreateSection([FromBody] CreateSectionRequest request)
        {
            var result = await _episodeService.CreateSection(request);
            return Ok(result);
        }

    }
}
