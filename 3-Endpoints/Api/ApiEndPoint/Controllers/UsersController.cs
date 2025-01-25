using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MAhface.Domain.Core.Entities.BasicInfo.Accounting;
using MAhface.Infrastructure.EfCore.DBContext;
using Microsoft.AspNetCore.Identity;
using MAhface.Domain.Core1.Interface.IServices;
using MAhface.Domain.Core1.Dto;

namespace ApiEndPoint.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
      
        private readonly IUserService _UserService;
        public UsersController( IUserService userService)
        {
            _UserService = userService;
                       
        }

        /// <summary>
        /// دریافت لیست تمامی کاربران
        /// این متد لیستی از تمام کاربران سیستم را برمی‌گرداند.
        /// </summary>

        [HttpGet("GetAll")]
        public async Task<ActionResult<IEnumerable<UserDto>>> GetUsers()
        {
            //return await _context.Users.ToListAsync();
            var Users =  await _UserService.GetAllUsers();
            if (User==null)
            {
                return NotFound();
            }
            return Ok(Users);
        }

        /// <summary>
        /// دریافت اطلاعات یک کاربر بر اساس شناسه
        /// این متد اطلاعات یک کاربر خاص را با استفاده از شناسه آن بازیابی می‌کند.
        /// </summary>

        [HttpGet("GetById")]
        public async Task<ActionResult<UserDto>> GetUser(Guid id)
        {
            var user = await _UserService.GetUserById(id);

            if (user == null)
            {
                return NotFound();
            }

            return Ok(user);
        }



        /// <summary>
        /// حذف یک کاربر
        /// این متد یک کاربر مشخص را با استفاده از شناسه آن از سیستم حذف می‌کند.
        /// </summary>

        [HttpDelete("Delete")]
        public async Task<IActionResult> DeleteUser(Guid id)
        {
            var result = _UserService.DeleteUser(id);
            return Ok(result);
        }

        
    }
}
