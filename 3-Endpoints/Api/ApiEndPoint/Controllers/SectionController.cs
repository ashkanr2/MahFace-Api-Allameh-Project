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

        // Create new section
        [HttpPost("CreateSection")]
        public async Task<ActionResult<AddStatusVm>> CreateSection([FromBody] CreateSectionRequest request)
        {
            var result = await _episodeService.CreateSection(request);
            return Ok(result);
        }

        // Update an existing section
        [HttpPut("UpdateSection/{sectionId}")]
        public async Task<ActionResult<UpdateStatus>> UpdateSection(Guid sectionId, [FromBody] UpdateSectionRequest request)
        {
            var result = await _episodeService.UpdateSection(sectionId, request);
            return Ok(result);
        }

        [HttpGet("GetAllSectionCourse/{courseId}")]
        public async Task<IActionResult> GetAllSectionCourse(Guid courseId)
        {
            var sectionDto = await _episodeService.GetAllSectionsForCourse(courseId);
            if (sectionDto == null)
            {
                return NotFound("Section not found");
            }
            return Ok(sectionDto);
        }




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

        //[HttpPost("UploadVideo/{sectionId}")]
        //public async Task<IActionResult> UploadVideo(Guid sectionId, IFormFile videoFile)
        //{
        //    var result = await _episodeService.UploadVideo(sectionId, videoFile);

        //    if (result.IsValid)
        //    {
        //        return Ok(result);
        //    }
        //    else
        //    {
        //        return BadRequest(result);
        //    }
        //}

        //[HttpPost("uploadByChoosingFile")]
        //public async Task<IActionResult> UploadByChoosingFile(
        //     [FromForm] IFormFile file,
        //     [FromForm] Guid courseId,
        //     [FromForm] Guid seasonId,
        //     [FromForm] Guid createdUserId,
        //     [FromForm] string? title = null)
        //{
        //    if (file == null || file.Length == 0)
        //    {
        //        return BadRequest("File is required and should not be empty.");
        //    }

        //    try
        //    {
        //        // Check if the file is a valid video (you can adjust the validation based on allowed file types)
        //        var allowedFileTypes = new[] { "video/mp4", "video/avi", "video/mkv" }; // Example video formats
        //        if (!allowedFileTypes.Contains(file.ContentType))
        //        {
        //            return BadRequest("Invalid file type. Only video files are allowed.");
        //        }

        //        // Create a CreateSectionRequest
        //        var request = new CreateSectionRequest
        //        {
        //            CourseId = courseId,
        //            SeasionId = seasonId,
        //            CreatedUserId = createdUserId,
        //            Title = title
        //        };

        //        // Call your service logic to create a section
        //        var createResult = await _episodeService.CreateSection(request);

        //        if (!createResult.IsValid)
        //        {
        //            return BadRequest(createResult.StatusMessage);
        //        }

        //        // Upload file logic for video
        //        var uploadResult = await _episodeService.UploadVideo(createResult.AddedId.Value, file);

        //        if (!uploadResult.IsValid)
        //        {
        //            return BadRequest(uploadResult.StatusMessage);
        //        }

        //        return Ok(new
        //        {
        //            SectionId = createResult.AddedId,
        //            Message = "Section created and video uploaded successfully."
        //        });
        //    }
        //    catch (Exception ex)
        //    {
        //        return StatusCode(500, $"An error occurred: {ex.Message}");
        //    }
        //}



    }
}
