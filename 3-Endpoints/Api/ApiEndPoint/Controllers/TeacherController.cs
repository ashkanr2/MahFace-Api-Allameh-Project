using ApiEndPoint.ViewModel;
using MAhface.Domain.Core.Dto;
using MAhface.Domain.Core.Interface.IServices;
using MAhface.Domain.Core1.Dto;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiEndPoint.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        private readonly ITeacherService _teacherService;

        public TeacherController(ITeacherService teacherService)
        {
            _teacherService = teacherService;
        }

        /// <summary>
        /// دریافت تمامی معلمان فعال
        /// این متد لیستی از معلمان فعال را برمی‌گرداند.
        /// </summary>

        // GET: api/teacher/GetAllActive
        [HttpGet("GetAllActive")]
        public async Task<ActionResult<IEnumerable<TeacherDto>>> GetAllActiveTeachers()
        {
            var teachers = await _teacherService.GetAllActiveTeachers();
            return Ok(teachers);
        }
        /// <summary>
        /// دریافت تمامی معلمان غیرفعال
        /// این متد لیستی از معلمان غیرفعال را برمی‌گرداند.
        /// </summary>

        // GET: api/teacher/GetAllInactive
        [HttpGet("GetAllInactive")]
        public async Task<ActionResult<IEnumerable<TeacherDto>>> GetAllInactiveTeachers()
        {
            var teachers = await _teacherService.GetAllInactiveTeachers();
            return Ok(teachers);
        }
        /// <summary>
        /// دریافت اطلاعات یک معلم بر اساس شناسه معلم
        /// این متد اطلاعات یک معلم را با استفاده از شناسه آن برمی‌گرداند.
        /// </summary>

        // GET: api/teacher/GetById/{id}
        [HttpGet("GetById/{teacherId}")]
        public async Task<ActionResult<TeacherDto>> GetTeacherById(Guid teacherId)
        {
            var teacher = await _teacherService.GetTeacherById(teacherId);
            if (teacher == null)
            {
                return NotFound();
            }
            return Ok(teacher);
        }
        /// <summary>
        /// دریافت اطلاعات یک معلم بر اساس شناسه کاربری
        /// این متد اطلاعات معلم را با استفاده از شناسه کاربری آن برمی‌گرداند.
        /// </summary>

        [HttpGet("GetByUserId/{userId}")]
        public async Task<ActionResult<TeacherDto>> GetTeacherByUserId(Guid userId)
        {
            var teacher = await _teacherService.GetTeacherByUSerId(userId);
            if (teacher == null)
            {
                return NotFound();
            }
            return Ok(teacher);
        }

        /// <summary>
        /// ایجاد یک معلم جدید
        /// این متد یک معلم جدید را با استفاده از شناسه کاربری آن ایجاد می‌کند.
        /// </summary>

        // POST: api/teacher/Create
        [HttpPost("Create")]
        public async Task<AddStatusVm> CreateTeacher( Guid userId)
        {
            if (userId == Guid.Empty)
            {
                UpdateStatus update =new UpdateStatus();
                update.IsValid = true;
                update.StatusMessage="آیدی  کاربر خالی نباید باشد ";
            }

            
                var result = await _teacherService.CreateTeacher(userId);
                return result;
            
        }


        /// <summary>
        /// حذف یک معلم بر اساس شناسه معلم
        /// این متد معلمی را که شناسه آن مشخص شده است حذف می‌کند.
        /// </summary>

        // DELETE: api/teacher/Delete/{id}
        [HttpDelete("Delete/{id}")]
        public async Task<IActionResult> DeleteTeacher(Guid id)
        {
            await _teacherService.DeleteTeacher(id);
            return NoContent(); // Successful deletion, no content needed
        }
    }
}
