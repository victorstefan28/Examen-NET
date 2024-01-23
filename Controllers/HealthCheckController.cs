using Microsoft.AspNetCore.Mvc;
using static Examen.Data.ApiResponse.Responses.Responses;

namespace Examen.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HealthCheckController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetHealth()
        {
            var data = new { Name = "Alive" };
            var response = new NotFoundResponse<object>();

            return Ok(response);
        }
    }
}
