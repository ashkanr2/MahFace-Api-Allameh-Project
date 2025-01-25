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

        /// <summary>
        /// افزودن تصویر جدید
        /// این متد تصویر جدید را با استفاده از اطلاعات ورودی اضافه می‌کند.
        /// </summary>

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


        /// <summary>
        /// دریافت تصویر بر اساس شناسه
        /// این متد تصویر مشخصی را با استفاده از شناسه آن بازیابی می‌کند.
        /// </summary>

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



        /// <summary>
        /// بارگذاری تصویر از طریق فایل انتخاب شده
        /// این متد تصویر را از یک فایل بارگذاری شده دریافت کرده و آن را ذخیره می‌کند.
        /// </summary>

        [HttpPost("uploadByChosingFile")]
        public async Task<AddStatusVm> UploadImage(IFormFile file)
        {
            AddStatusVm addStatusVm = new();
            if (file == null || file.Length == 0)
            {
                addStatusVm.IsValid=false;
                addStatusVm.StatusMessage="";
                return addStatusVm;
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
            return createdImage;
        }

        /// <summary>
        /// دانلود تصویر به صورت فایل
        /// این متد تصویر را بر اساس شناسه آن دریافت کرده و به صورت فایل برای کاربر ارسال می‌کند.
        /// </summary>

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
        /// <summary>
        /// دانلود تصویر از طریق رشته base64
        /// این متد تصویر را از رشته base64 دریافت کرده و آن را به صورت فایل برای کاربر ارسال می‌کند.
        /// </summary>

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
        /// <summary>
        /// حذف تصویر
        /// این متد تصویر مشخصی را با استفاده از شناسه آن از سیستم حذف می‌کند.
        /// </summary>
        [HttpDelete("DeleteImage")]
        public async Task<IActionResult> DeleteImage(Guid id)
        {
            await _imageService.DeleteImage(id);
            return NoContent();
        }

    }
}
