﻿using ApiEndPoint.ViewModel;
using MAhface.Domain.Core.Dto;
using MAhface.Domain.Core.Entities.Study.Course;
using MAhface.Domain.Core.Interface.IServices;
using MAhface.Infrastructure.EfCore.DBContext;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiEndPoint.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        private readonly AllamehPrroject _context;
        private readonly ICourseService _CourseService;

        public CoursesController(AllamehPrroject context, ICourseService CourseService)
        {
            _context = context;
            _CourseService=CourseService;
        }

        // GET: api/Courses
        [HttpGet("GetAllCourses")]
        public async Task<ActionResult<IEnumerable<CourseDto>>> GetAllCourses()
        {
            //    var courseVm = new List <CourseVm> ();
            //    var courses= await _context.Courses.ToListAsync();
            //    foreach (var course in courses)
            //    {
            //        var view = _context.Views.Any(x => !x.IsDeleted && x.CourseId==course.Id);

            //    }
            //    return courses; 
            var courses = _context.Courses.ToList();
            return Ok(courses);

        }

        // GET: api/Courses/5
        [HttpGet("GetById")]
        public async Task<ActionResult<Courses>> GetCourseById(Guid id)
        {
            var course = await _context.Courses.FindAsync(id);

            if (course == null)
            {
                return NotFound();
            }

            return course;
        }



        // POST: api/Courses
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost("AddCourse")]
        public async Task<ActionResult<Courses>> PostCourse(CourseVm CourseVm)
        {
            Courses course = new Courses();
            course.Title= CourseVm.Title;
            course.CategoryId= CourseVm.CategoryId;
            course.CourseLevelId=1;
            course.Cost=CourseVm.cost;
            course.CourseDescription= CourseVm.CourseDescription;
            course.TeacherId= CourseVm.TeacherId;
            _context.Courses.Add(course);
            course.CreatedUserID=_context.Users.FirstOrDefault(x => x.IsSystemAccount).Id;
            course.CreatedDate=DateTime.Now;
            course.DeletedDate=DateTime.Now;
            course.IsDeleted=false;
            course.ISActive=true;
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCourse", new { id = course.Id }, course);
        }

        // DELETE: api/Courses/5
        [HttpDelete("IsDeleted")]
        public async Task<IActionResult> DeleteCourse(Guid id)
        {
            var course = await _context.Courses.FindAsync(id);
            if (course == null)
            {
                return NotFound();
            }

            if (course!=null) { course.IsDeleted=true; }
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CourseExists(Guid id)
        {
            return _context.Courses.Any(e => e.Id == id);
        }

        [HttpPost("UploadImage/{id}")]
        public async Task<ActionResult> UploadImage(Guid id, IFormFile file)
        {
            var course = await _context.Courses.FindAsync(id);
            if (course == null)
            {
                return NotFound();
            }

            // Check if file is null or not
            if (file == null || file.Length == 0)
            {
                return BadRequest("File is null or empty");
            }

            // Get file extension
            var extension = Path.GetExtension(file.FileName);

            // Generate a unique filename for the image
            var fileName = $"{Guid.NewGuid()}{extension}";

            // Path to save the image
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", fileName);

            // Save the image to the server
            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }

            // Update course with image URL
            course.ImageUrl = $"images/{fileName}";
            await _context.SaveChangesAsync();

            return Ok(new { message = "Image uploaded successfully", imageUrl = course.ImageUrl });
        }

        // GET: api/Courses/DownloadImage/{id}
        [HttpGet("DownloadImage/{id}")]
        public async Task<IActionResult> DownloadImage(Guid id)
        {
            var course = await _context.Courses.FindAsync(id);
            if (course == null || string.IsNullOrEmpty(course.ImageUrl))
            {
                return NotFound();
            }

            // Get the file path of the image
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", course.ImageUrl);

            // Check if file exists
            if (!System.IO.File.Exists(filePath))
            {
                return NotFound();
            }

            // Read the file and return as FileStreamResult
            var fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            return File(fileStream, "image/jpeg"); // You can set appropriate MIME type here
        }
    }
}
