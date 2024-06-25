using FreeLancerAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System.Net;

namespace FreeLancerAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProjectsController : ControllerBase
    {
        private readonly OpeningTimeOption _openingTime;
        public ProjectsController(IOptions<OpeningTimeOption> option)
        {
            _openingTime = option.Value;
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }
        [HttpGet("id")]
        public IActionResult GetById(int id)
        {
            return Ok();
        }
        [HttpPost]
        public IActionResult Post([FromBody]ProjectModel project)
        {
            if (project.Title.Length > 50)
            {
                return BadRequest();
            }
            return CreatedAtAction(nameof(GetById), new { id = project.ID}, project);
        }
        [HttpPut("id")]
        public IActionResult Put(int id, [FromBody] ProjectModel project)
        {
            return NoContent();
        }
        [HttpDelete("id")]
        public IActionResult Delete(int id)
        {
            return NoContent();
        }
        [HttpPost("{id}/comments")]
        public IActionResult PostComment(int id, [FromBody] CreateCommentModel comment)
        {
            return NoContent();
        }
    }
}
