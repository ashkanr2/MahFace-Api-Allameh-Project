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

        // GET: api/Users
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

        // GET: api/Users/5
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

        [HttpPut("UpdateUser")]
        public async Task<IActionResult> PutUser(Guid id, UserDto userDto)
        {
            if (id != userDto.Id)
            {
                return BadRequest();
            }
           var result =  await _UserService.UpdateUser(userDto);

            return Ok(result);
        }

 
      
        [HttpDelete("Delete")]
        public async Task<IActionResult> DeleteUser(Guid id)
        {
            var result = _UserService.DeleteUser(id);
            return Ok(result);
        }

        
    }
}
