using Examen.Models.nsUser.DTO;
using Examen.Services.UserService;
using Microsoft.AspNetCore.Mvc;

namespace Examen.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }


        [HttpGet]
        public async Task<IActionResult> GetAllUsers()
        {
            try
            {
                var users = await _userService.GetAllUsersAsync();
                if (users == null)
                {
                    return NotFound();
                }

                return Ok(users);
            }
            catch
            {

                return StatusCode(StatusCodes.Status500InternalServerError, "Eroare la preluarea datelor din baza de date.");
            }
        }

        // POST: api/user
        [HttpPost]
        public async Task<IActionResult> CreateUser([FromBody] CreateUserDTO user)
        {
            if (user == null)
            {
                return BadRequest("Obiectul User este null.");
            }
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                return Ok(await _userService.CreateUserAsync(user));
            }
            catch
            {

                return StatusCode(StatusCodes.Status500InternalServerError, "Eroare la crearea noului utilizator.");
            }
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetUserById(Guid id)
        {
            var user = await _userService.GetUserByIdAsync(id);
            if (user != null)
            {
                return Ok(user);
            }

            return NotFound();
        }
    }

}
