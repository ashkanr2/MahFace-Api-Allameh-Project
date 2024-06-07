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

namespace ApiEndPoint.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly AllamehPrroject _context;
        private readonly UserManager<User> _userManager;

        public UsersController(AllamehPrroject context, UserManager<User>userManager)
        {
            _userManager = userManager;
            _context = context;
        }

        // GET: api/Users
        [HttpGet("GetAll")]
        public async Task<ActionResult<IEnumerable<User>>> GetUsers()
        {
            //return await _context.Users.ToListAsync();
            return await _userManager.Users.ToListAsync();
        }

        // GET: api/Users/5
        [HttpGet("GetById")]
        public async Task<ActionResult<User>> GetUser(Guid id)
        {
            var user = await _userManager.Users.FirstAsync(x=>x.Id==id);

            if (user == null)
            {
                return NotFound();
            }

            return user;
        }

        [HttpPut("UpdateUser")]
        public async Task<IActionResult> PutUser(Guid id, User user)
        {
            if (id != user.Id)
            {
                return BadRequest();
            }

            await _userManager.UpdateAsync(user);

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

 
        [HttpPost("AddUser")]
        public async Task<ActionResult<User>> AddUser(User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUser", new { id = user.Id }, user);
        }

        // DELETE: api/Users/5
        [HttpDelete("Delete")]
        public async Task<IActionResult> DeleteUser(Guid id)
        {
            var user = await _context.Users.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            _context.Users.Remove(user);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool UserExists(Guid id)
        {
            return _context.Users.Any(e => e.Id == id);
        }
    }
}
