using ApiEndPoint.ViewModel;
using MAhface.Domain.Core.Dto;
using MAhface.Domain.Core.Interface.IServices;
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

            var courseVm = new CourseVm
            {
                Title = courseDto.Title,
                CourseLevelId = courseDto.CourseLevelId,
                TeacherId = courseDto.TeacherId,
                CategoryId = courseDto.CategoryId,
                CourseDescription = courseDto.CourseDescription,
                Cost = courseDto.Cost,
                //ImageBase64 = courseDto.ImageFile,
                // Map other properties as needed
            };

            return Ok(courseVm);
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
                    Title = courseDto.Title,
                    CourseLevelId = courseDto.CourseLevelId,
                    TeacherId = courseDto.TeacherId,
                    CategoryId = courseDto.CategoryId,
                    CourseDescription = courseDto.CourseDescription,
                    Cost = courseDto.Cost,
                    //ImageBase64 = courseDto.ImageFile
                    // Map other properties as needed
                };
                courseVms.Add(courseVm);
            }

            return Ok(courseVms);
        }

        [HttpPost("AddCourse")]
        public async Task<ActionResult<CourseVm>> AddCourse(CourseVm courseVm)
        {
            var courseDto = new CourseDto
            {
                Title = courseVm.Title,
                CourseLevelId = courseVm.CourseLevelId,
                TeacherId = courseVm.TeacherId,
                CategoryId = courseVm.CategoryId,
                CourseDescription = courseVm.CourseDescription,
                Cost = courseVm.Cost,
                //ImageFile = courseVm.ImageBase64
                // Map other properties as needed
            };

            await _coursesService.AddCourse(courseDto);

            return CreatedAtAction(nameof(GetCourse), new { id = courseDto }, courseVm);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCourse(Guid id, CourseVm courseVm)
        {
            if (id != courseVm.Id)
            {
                return BadRequest();
            }

            var courseDto = new CourseDto
            {
                Id = id,
                Title = courseVm.Title,
                CourseLevelId = courseVm.CourseLevelId,
                TeacherId = courseVm.TeacherId,
                CategoryId = courseVm.CategoryId,
                CourseDescription = courseVm.CourseDescription,
                Cost = courseVm.Cost,
                //ImageFile = courseVm.ImageBase64
                // Map other properties as needed
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


    }
}
