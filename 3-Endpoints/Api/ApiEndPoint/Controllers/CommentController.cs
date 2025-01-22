using MAhface.Domain.Core1.Dto;
using MAhface.Domain.Core1.Entities.Study.Course;
using MAhface.Domain.Core1.Interface.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiEndPoint.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        private readonly ICommentService _commentService;

        public CommentController(ICommentService commentService)
        {
            _commentService = commentService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            try
            {
                var comment = await _commentService.GetById(id);
                return comment == null
                    ? NotFound(new { Message = "نظر مورد نظر پیدا نشد." })
                    : Ok(comment);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { Message = "خطایی در سرور رخ داده است.", Error = ex.Message });
            }
        }

        [HttpGet("user/{userId}")]
        public async Task<IActionResult> GetAllUsersComments(Guid userId)
        {
            try
            {
                var comments = await _commentService.GetAllUsersComments(userId);
                return Ok(comments);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { Message = "خطایی در دریافت نظرات کاربر رخ داده است.", Error = ex.Message });
            }
        }

        [HttpGet("course/{courseId}")]
        public async Task<IActionResult> GetAllCourseComments(Guid courseId)
        {
            try
            {
                var comments = await _commentService.GetAllCourseComments(courseId);
                return Ok(comments);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { Message = "خطایی در دریافت نظرات دوره رخ داده است.", Error = ex.Message });
            }
        }

        [HttpPost]
        public async Task<IActionResult> AddComment([FromBody] AddCommentVm addCommentVm)
        {
            try
            {
                var result = await _commentService.AddComment(addCommentVm);
                return result.IsValid
                    ? Ok(new { Message = "نظر با موفقیت افزوده شد.", AddedId = result.AddedId })
                    : BadRequest(new { Message = result.StatusMessage });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { Message = "خطایی در افزودن نظر رخ داده است.", Error = ex.Message });
            }
        }

        [HttpPut]
        public async Task<IActionResult> UpdateComment([FromBody] Comment comment)
        {
            try
            {
                var result = await _commentService.UpdateComment(comment);
                return result.IsValid
                    ? Ok(new { Message = "نظر با موفقیت به‌روزرسانی شد." })
                    : BadRequest(new { Message = result.StatusMessage });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { Message = "خطایی در به‌روزرسانی نظر رخ داده است.", Error = ex.Message });
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteComment(Guid id)
        {
            try
            {
                var result = await _commentService.DeleteComment(id);
                return result.IsValid
                    ? Ok(new { Message = "نظر با موفقیت حذف شد." })
                    : BadRequest(new { Message = result.StatusMessage });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { Message = "خطایی در حذف نظر رخ داده است.", Error = ex.Message });
            }



        }
    }
}