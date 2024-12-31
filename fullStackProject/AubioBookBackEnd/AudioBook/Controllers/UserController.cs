using AudioBook.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AudioBook.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private AudioBookContext _context;
        public UserController(AudioBookContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult<User>> ValidateUser(User user)
        {
            if (_context.Users == null)
            {
                return NotFound("");
            }

            var validatedUser = await _context.Users.Where(u => u.Username == user.Username && u.Password == user.Password).FirstOrDefaultAsync<User>();

            if (validatedUser == null)
            {
                return NotFound("");
            }
            else
            {
                return Ok(validatedUser);
            }
        }

        //[HttpPost]
        //public async Task<ActionResult<User>> PostUser(User user)
        //{
        //    if (_context.Users == null)
        //    {
        //        return Problem("Entity set 'AudioBookContext.Users'  is null.");
        //    }
        //    _context.Users.Add(user);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetUser", new { id = user.Id }, user);
        //}

    }
}
