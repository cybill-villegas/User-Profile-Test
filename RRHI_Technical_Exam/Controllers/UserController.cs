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
        public async Task<ActionResult<IEnumerable<User>>> GetAll()
        {
            var user = await _userRepository.GetAllUsersAsync();

            return Ok(user);
        }

        [HttpGet("getuserbyid/{id}")]
        public async Task<ActionResult<IEnumerable<User>>> GetById()
        {
            var user = await _userRepository.GetAllUsersAsync();

            return Ok(user);
        }

        [HttpPost("createuser")]
        public async Task<ActionResult<IEnumerable<User>>> Create()
        {
            var user = await _userRepository.GetAllUsersAsync();

            return Ok(user);
        }

        [HttpPut("updateuser")]
        public async Task<ActionResult<IEnumerable<User>>> Update()
        {
            var user = await _userRepository.GetAllUsersAsync();

            return Ok(user);
        }

        [HttpDelete("deleteuser/{id}")]
        public async Task<ActionResult<IEnumerable<User>>> Delete()
        {
            var user = await _userRepository.GetAllUsersAsync();

            return Ok(user);
        }
    }
}
