using ApiEndPoint.ViewModel;
using MAhface.Domain.Core.Dto;
using MAhface.Domain.Core.Entities.BasicInfo.Accounting;
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

        // GET: api/teacher/GetAllActive
        [HttpGet("GetAllActive")]
        public async Task<ActionResult<IEnumerable<TeacherDto>>> GetAllActiveTeachers()
        {
            var teachers = await _teacherService.GetAllActiveTeachers();
            return Ok(teachers);
        }

        // GET: api/teacher/GetAllInactive
        [HttpGet("GetAllInactive")]
        public async Task<ActionResult<IEnumerable<TeacherDto>>> GetAllInactiveTeachers()
        {
            var teachers = await _teacherService.GetAllInactiveTeachers();
            return Ok(teachers);
        }

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


        // POST: api/teacher/Create
        [HttpPost("Create")]
        public async Task<AddStatusVm> CreateTeacher( Guid userId)
        {
            AddStatusVm vm = new AddStatusVm();
            
            try
            {
                var existTeacher = await _teacherService.GetTeacherByUSerId(userId);
                if (existTeacher != null)
                {
                    vm.IsValid = false;
                    vm.StatusMessage="استادی با این ایدی وجود دارد";
                    return vm;
                }

                var teacher = await _teacherService.CreateTeacher(userId);
                return teacher;

            }
            catch (Exception ex)
            {
                vm.IsValid=false;
                vm.StatusMessage = ex.Message;
                return vm;
            }
        }

        // PUT: api/teacher/Update/{id}
        [HttpPut("ChangeActivation")]
        public async Task<UpdateStatus> UpdateTeacher(Guid id, bool teacherActivation)
        {
           
            UpdateStatus updateStatus = new UpdateStatus(); 
            try
            {
                var techerDto = await _teacherService.GetTeacherById(id);
                if (techerDto == null) 
                {
                    updateStatus.IsValid = false;
                    updateStatus.StatusMessage="دیتایی پیدا نشد ";
                    return updateStatus;
                }
                techerDto.IsActive=teacherActivation;
                await _teacherService.UpdateTeacher(techerDto);
                updateStatus.IsValid = true;
                updateStatus.StatusMessage="با موفقیت انجام شد ";
                return updateStatus;
            }
            catch (Exception ex)
            {
                return updateStatus;
            }
        }

        // DELETE: api/teacher/Delete/{id}
        [HttpDelete("Delete/{id}")]
        public async Task<IActionResult> DeleteTeacher(Guid id)
        {
            await _teacherService.DeleteTeacher(id);
            return NoContent(); // Successful deletion, no content needed
        }
    }
}
