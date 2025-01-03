using Microsoft.AspNetCore.Mvc;
using RRHI_Technical_Exam.Interfaces;
using RRHI_Technical_Exam.Models;

namespace RRHI_Technical_Exam.Controllers
{
    [ApiController]
    [Route("api/")]
    public class UserController : Controller
    {
        private readonly IUserRepository _userRepository;
        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet("getallusers")]
        public async Task<ActionResult<IEnumerable<User>>> GetAll(int pageNumber = 1, int pageSize = 10)
        {
            var users = await _userRepository.GetAllUsersAsync(pageNumber, pageSize);
            return Ok(users);
        }

        [HttpGet("getuserbyid/{id}")]
        public async Task<ActionResult<IEnumerable<User>>> GetById(int id)
        {
            var user = await _userRepository.GetUserByIdAsync(id);

            if (user == null) {
                return NotFound();
            }

            return Ok(user);
        }

        [HttpPost("createuser")]
        public async Task<ActionResult> Create(User user)
        {
            await _userRepository.AddUserAsync(user);

            return CreatedAtAction(nameof(GetById), new { id = user.UserId }, user);
        }

        [HttpPut("updateuser")]
        public async Task<ActionResult> Update(int id, User user)
        {
            if (id != user.UserId)
            {
                return BadRequest();
            }

            await _userRepository.UpdateUserAsync(user);
            return NoContent();
        }

        [HttpDelete("deleteuser/{id}")]
        public async Task<ActionResult<IEnumerable<User>>> Delete(int id)
        {
            await _userRepository.DeleteUserAsync(id);

            return NoContent();
        }
    }
}
