using FreeLancerAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace FreeLancerAPI.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class UsersController : ControllerBase
    {

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult Post([FromBody] CreateUserModel user)
        {
            return CreatedAtAction(nameof(GetById), new { id = 1}, user);
        }
    }
}
