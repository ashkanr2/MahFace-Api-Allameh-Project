using AutoMapper;
using MAhface.Domain.Core.Dto;
using MAhface.Domain.Core.Entities.Study.Course;
using MAhface.Domain.Core.Interface.IServices;
using MAhface.Domain.Core1.Dto;
using MAhface.Domain.Core1.Interface.IServices;
using Microsoft.AspNetCore.Mvc;

namespace ApiEndPoint.Controllers
{


    public class CourseController : ControllerBase
    {
        private readonly ICourseService _coursesService;
        private readonly IMapper _mapper;

        public CourseController(ICourseService coursesService, IMapper mapper)
        {
            _coursesService = coursesService;
            _mapper = mapper;
        }

        [HttpGet("GetById/{id}")]
        public async Task<ActionResult<CourseDetail>> GetById(Guid id)
        {
            var courseDetail = await _coursesService.GetCourseById(id);
            if (courseDetail == null)
            {
                return NotFound();
            }
          
            return Ok(courseDetail);
        }





        [HttpGet("GetAllCourses")]
        public async Task<ActionResult<IEnumerable<CourseVm>>> GetAllCourses()
        {
            var courseDtos = await _coursesService.GetAllCourses();
            var courseVms = _mapper.Map<List<CourseVm>>(courseDtos);
            return Ok(courseVms);
        }

        [HttpPost("AddCourse")]
        public async Task<AddStatusVm> AddCourse([FromBody] AddCourseVm courseVm)
        {
           
            var result = await _coursesService.AddCourse(courseVm);
            return result;
        }


        [HttpPut("UpdateCourse/{id}")]
        public async Task<IActionResult> UpdateCourse([FromBody] CourseVm courseVm)
        {
            var courseDto = _mapper.Map<CourseDto>(courseVm);
            var result = await _coursesService.UpdateCourse(courseDto);

            if (result.IsValid)
                return NoContent();
            else
                return BadRequest(result.StatusMessage);
        }

        [HttpDelete("DeleteCourse/{id}")]
        public async Task<IActionResult> DeleteCourse(Guid id)
        {
            var result = await _coursesService.DeleteCourse(id);
            if (result.IsValid)
                return NoContent();
            else
                return BadRequest(result.StatusMessage);
        }



    }
}
