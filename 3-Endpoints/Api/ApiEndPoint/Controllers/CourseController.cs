using ApiEndPoint.ViewModel;
using MAhface.Domain.Core.Dto;
using MAhface.Domain.Core.Interface.IServices;
using MAhface.Domain.Core1.Dto;
using Microsoft.AspNetCore.Mvc;

namespace ApiEndPoint.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly ICoursesService _coursesService;

        public CourseController(ICoursesService coursesService)
        {
            _coursesService = coursesService;
        }

        [HttpGet("GetById")]
        public async Task<ActionResult<CourseVm>> GetCourse(Guid id)
        {
            var courseDto = await _coursesService.GetCourseById(id);
            if (courseDto == null)
            {
                return NotFound();
            }

            var addcourseVm = new AddCourseVm
            {
                Id=courseDto.Id,
                Title = courseDto.Title,
                CourseLevelId = courseDto.CourseLevelId,
                TeacherId = courseDto.TeacherId,
                CategoryId = courseDto.CategoryId,
                CourseDescription = courseDto.CourseDescription,
                Cost = courseDto.Cost,
                ImageBase64 = courseDto.ImageDto.Base64File,
               
                // Map other properties as needed
            };

            return Ok(addcourseVm);
        }

        [HttpGet("GetAllCourses")]
        public async Task<ActionResult<IEnumerable<CourseVm>>> GetAllCourses()
        {
            var courseDtos = await _coursesService.GetAllCourses();
            var courseVms = new List<CourseVm>();
            foreach (var courseDto in courseDtos)
            {
                var courseVm = new CourseVm
                {
                    Id= courseDto.Id,
                    Title = courseDto.Title,
                    CourseLevelId = courseDto.CourseLevelId,
                    TeacherId = courseDto.TeacherId,
                    CategoryId = courseDto.CategoryId,
                    CourseDescription = courseDto.CourseDescription,
                    
                    Cost = courseDto.Cost,
                    ImageBase64 = courseDto.ImageDto?.Base64File
                   
                };
                courseVms.Add(courseVm);
            }

            return Ok(courseVms);
        }

        [HttpPost("AddCourse")]
        public async Task<AddStatusVm> AddCourse(CourseVm courseVm)
        {
            AddStatusVm addStatusVm = new AddStatusVm();
            var courseDto = new CourseDto
            {
                Title = courseVm.Title,
                CourseLevelId = courseVm.CourseLevelId,
                TeacherId = courseVm.TeacherId,
                CategoryId = courseVm.CategoryId,
                CourseDescription = courseVm.CourseDescription,
                Cost = courseVm.Cost,
                ImageId = courseVm.ImageId,
                StarsNumber= courseVm.StarsNumber??2,
            };

           var result =  await _coursesService.AddCourse(courseDto);

            return result;
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCourse( CourseVm courseVm)
        {
           

            var courseDto = new CourseDto
            {
                Id = courseVm.Id,
                Title = courseVm.Title,
                CourseLevelId = courseVm.CourseLevelId,
                TeacherId = courseVm.TeacherId,
                CategoryId = courseVm.CategoryId,
                CourseDescription = courseVm.CourseDescription,
                Cost = courseVm.Cost,
                ImageDto = new MAhface.Domain.Core1.Dto.ImageDto()
                {
                    Url= courseVm.ImageUrl,
                    Base64File= courseVm.ImageBase64
                }
            };

            await _coursesService.UpdateCourse(courseDto);

            return NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCourse(Guid id)
        {
            await _coursesService.DeleteCourse(id);
            return NoContent();
        }

        [HttpPost("downloadFromBase64")]
        public IActionResult DownloadImageFromBase64([FromBody] string base64String)
        {
            if (string.IsNullOrEmpty(base64String))
            {
                return BadRequest("Invalid base64 string.");
            }

            try
            {
                // Convert base64 to byte array
                byte[] imageBytes = Convert.FromBase64String(base64String);

                // Define file name and type (assuming PNG for this example)
                string fileName = "downloaded_image.png";
                string mimeType = "image/png";

                return File(imageBytes, mimeType, fileName);
            }
            catch (FormatException)
            {
                return BadRequest("Invalid base64 string format.");
            }
        }

    }
}
