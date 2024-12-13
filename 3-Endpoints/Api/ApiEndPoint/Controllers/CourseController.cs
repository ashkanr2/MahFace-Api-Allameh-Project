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

        //[HttpGet("GetById/{id}")]
        //public async Task<ActionResult<CourseVm>> GetById(Guid id)
        //{
        //    var courseDto = await _coursesService.GetCourseById(id);
        //    if (courseDto == null)
        //    {
        //        return NotFound();
        //    }

        //    var courseVm = _mapper.Map<CourseVm>(courseDto);
        //    return Ok(courseVm);
        //}

        [HttpGet("GetById/{id}")]
        public async Task<ActionResult<Courses>> GetById(Guid id)
        {
            var course = await _coursesService.GetCourseById(id);
            if (course == null)
            {
                return NotFound();
            }

            return Ok(course);
        }



        [HttpGet("GetAllCourses")]
        public async Task<ActionResult<IEnumerable<CourseVm>>> GetAllCourses()
        {
            var courseDtos = await _coursesService.GetAllCourses();
            var courseVms = _mapper.Map<List<CourseVm>>(courseDtos);
            return Ok(courseVms);
        }

        [HttpPost("AddCourse")]
        public async Task<AddStatusVm> AddCourse(CourseVm courseVm)
        {
            var courseDto = _mapper.Map<CourseDto>(courseVm);
            var result = await _coursesService.AddCourse(courseDto);
            return result;
        }


        [HttpPut("UpdateCourse/{id}")]
        public async Task<IActionResult> UpdateCourse(CourseVm courseVm)
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
