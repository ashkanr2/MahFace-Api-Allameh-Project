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
        private readonly ISectionService _sectionService;

        public SectionController(ISectionService sectionService)
        {
            _sectionService = sectionService;
        }

        /// <summary>
        /// این متد یک قسمت جدید اضافه می‌کند.
        /// </summary>
        /// <param name="sectionDto">اطلاعات قسمت جدید</param>
        /// <returns>پیام موفقیت یا خطا</returns>
        [HttpPost]
        public async Task<IActionResult> AddSection([FromBody] SectionDto sectionDto)
        {
            var result = await _sectionService.AddSectionAsync(sectionDto);
            var resultVm = new SectionVm
            {
                Id = Guid.NewGuid(), // به‌عنوان مثال
                CourseId = result.CourseId,
                SeasionId = result.SeasionId,
                CategoryId = result.CategoryId,
                CourseLevel = result.CourseLevel,
                StatusMessage = "Section added successfully"
            };

            return Ok(resultVm);
        }

        /// <summary>
        /// این متد یک قسمت را به‌روزرسانی می‌کند.
        /// </summary>
        /// <param name="sectionDto">اطلاعات قسمت جدید</param>
        /// <returns>پیام موفقیت یا خطا</returns>
        [HttpPut]
        public async Task<IActionResult> UpdateSection([FromBody] SectionDto sectionDto)
        {
            var result = await _sectionService.UpdateSectionAsync(sectionDto);
            var resultVm = new SectionVm
            {
                Id = Guid.NewGuid(), // به‌عنوان مثال
                CourseId = result.CourseId,
                SeasionId = result.SeasionId,
                CategoryId = result.CategoryId,
                CourseLevel = result.CourseLevel,
                StatusMessage = "Section updated successfully"
            };

            return Ok(resultVm);
        }

        /// <summary>
        /// این متد یک قسمت را حذف می‌کند.
        /// </summary>
        /// <param name="id">شناسه بخش</param>
        /// <returns>پیام موفقیت یا خطا</returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSection(Guid id)
        {
            var isDeleted = await _sectionService.DeleteSectionAsync(id);
            if (isDeleted)
                return Ok(new { message = "Section deleted successfully" });

            return BadRequest(new { message = "Failed to delete section" });
        }

        /// <summary>
        /// این متد یک قسمت را با شناسه مشخص برمی‌گرداند.
        /// </summary>
        /// <param name="id">شناسه بخش</param>
        /// <returns>اطلاعات بخش</returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetSectionById(Guid id)
        {
            var sectionDto = await _sectionService.GetSectionByIdAsync(id);
            var resultVm = new SectionVm
            {
                Id = sectionDto.Id,
                CourseId = sectionDto.CourseId,
                SeasionId = sectionDto.SeasionId,
                CategoryId = sectionDto.CategoryId,
                CourseLevel = sectionDto.CourseLevel,
                StatusMessage = "Section found successfully"
            };

            return Ok(resultVm);
        }

        /// <summary>
        /// این متد همه بخش‌ها را برمی‌گرداند.
        /// </summary>
        /// <returns>لیست بخش‌ها</returns>
        [HttpGet]
        public async Task<IActionResult> GetAllSections()
        {
            var sectionsDto = await _sectionService.GetAllSectionsAsync();
            var resultVm = sectionsDto.Select(section => new SectionVm
            {
                Id = section.Id,
                CourseId = section.CourseId,
                SeasionId = section.SeasionId,
                CategoryId = section.CategoryId,
                CourseLevel = section.CourseLevel,
                StatusMessage = "Section found successfully"
            });

            return Ok(resultVm);
        }
    }


}
