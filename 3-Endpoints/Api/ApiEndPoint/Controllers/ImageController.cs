using MAhface.Domain.Core1.Dto;
using MAhface.Domain.Core1.Entities.BasicInfo.Business;
using MAhface.Domain.Core1.Interface.IServices;
using MAhface.Infrastructure.EfCore.DBContext;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiEndPoint.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ImageController : ControllerBase
    {
        private readonly IImageService _imageService;

        public ImageController(IImageService imageService)
        {
            _imageService = imageService;
        }


        [HttpPost("AddImage")]
        public async Task<IActionResult> AddImage([FromBody] ImageDto imageDto)
        {
            if (imageDto == null)
            {
                return BadRequest("Image data is required.");
            }

            var createdImage = await _imageService.AddImage(imageDto);
            if (createdImage == null || createdImage.AddedId == Guid.Empty)
            {
                return NotFound("Unable to create the image.");
            }

            return Ok(createdImage.AddedId);
        }



        [HttpGet("GetByImageId")]
        public async Task<ActionResult<ImageDto>> GetImage(Guid id)
        {
            var image = await _imageService.GetImageById(id);
            if (image == null)
            {
                return NotFound();
            }

            return image;
        }

 
        [HttpDelete("DeleteImage")]
        public async Task<IActionResult> DeleteImage(Guid id)
        {
            await _imageService.DeleteImage(id);
            return NoContent();
        }


        [HttpPost("uploadByChosingFile")]
        public async Task<IActionResult> UploadImage(IFormFile file)
        {
            if (file == null || file.Length == 0)
            {
                return BadRequest("No file uploaded.");
            }

            using var memoryStream = new MemoryStream();
            await file.CopyToAsync(memoryStream);
            byte[] fileBytes = memoryStream.ToArray();
            string base64String = Convert.ToBase64String(fileBytes);

            var imageDto = new ImageDto
            {
                Url = file.FileName, // Storing the file name as URL for simplicity
                Base64File = base64String,

            };

            var createdImage = await _imageService.AddImage(imageDto);
            return CreatedAtAction(nameof(GetImage), new { id = createdImage.AddedId }, createdImage);
        }

        // GET: api/Image/download/{id}
        [HttpGet("DownloadImageAsFile")]
        public async Task<IActionResult> DownloadImage(Guid id)
        {
            var imageBytes = await _imageService.GetImageBytes(id);
            if (imageBytes == null)
            {
                return NotFound();
            }

            string fileName = "image.png";
            string mimeType = "image/png";

            return File(imageBytes, mimeType, fileName);
        }
 
        [HttpPost("DownloadFromBase64")]
        public IActionResult DownloadImageFromBase64([FromBody] string base64String)
        {
            if (string.IsNullOrEmpty(base64String))
            {
                return BadRequest("Invalid base64 string.");
            }

            var imageBytes = _imageService.GetImageBytesFromBase64(base64String).Result;
            if (imageBytes == null)
            {
                return BadRequest("Invalid base64 string format.");
            }

            string fileName = "downloaded_image.png";
            string mimeType = "image/png";

            return File(imageBytes, mimeType, fileName);
        }
    }
}
