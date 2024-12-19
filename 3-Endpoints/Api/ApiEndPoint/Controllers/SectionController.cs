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

        // Create new section
        [HttpPost("CreateSection")]
        public async Task<ActionResult<AddStatusVm>> CreateSection([FromBody] CreateSectionRequest request)
        {
            var result = await _sectionService.CreateSection(request);
            return Ok(result);
        }

        // Update an existing section
        [HttpPut("UpdateSection/{sectionId}")]
        public async Task<ActionResult<UpdateStatus>> UpdateSection(Guid sectionId, [FromBody] UpdateSectionRequest request)
        {
            var result = await _sectionService.UpdateSection(sectionId, request);
            return Ok(result);
        }

        // Get section details
        [HttpGet("GetSectionDetails/{sectionId}")]
        public async Task<ActionResult<SectionDto>> GetSectionDetails(Guid sectionId)
        {
            var sectionDto = await _sectionService.GetSectionDetails(sectionId);
            if (sectionDto == null)
            {
                return NotFound("Section not found");
            }
            return Ok(sectionDto);
        }
    
    
    }


}
