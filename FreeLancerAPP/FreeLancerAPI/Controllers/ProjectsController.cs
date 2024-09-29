using FreeLancer.Application.InputModels;
using FreeLancer.Application.Services.Interfaces;
using FreeLancer.Application.ViewModels;
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
        private readonly IProjectService _projectService;
        public ProjectsController(IProjectService projectService)
        {
            _projectService = projectService;
        }
        [HttpGet]
        public IActionResult Get()
        {
            var projects = _projectService.GetAll();
            return Ok(projects);
        }
        [HttpGet("id")]
        public IActionResult GetById(int id)
        {
            ProjectDetailsViewModel project = _projectService.GetById(id);
            return Ok(project);
        }
        [HttpPost]
        public IActionResult Post([FromBody] NewProjectInputModel inputModel)
        {
            if (inputModel.Title.Length > 50)
            {
                return BadRequest();
            }

            int id = _projectService.Create(inputModel);
            return CreatedAtAction(nameof(GetById), new { id = id}, inputModel);
        }
        [HttpPut("id")]
        public IActionResult Put([FromBody] UpdateProjectInputModel projectInputModel)
        {
            _projectService.Update(projectInputModel);
            return NoContent();
        }

        [HttpPut("{id}/start")]
        public IActionResult Start(int id)
        {
            _projectService.Start(id);
            return NoContent();
        }

        [HttpPut("{id}/finish")]
        public IActionResult Finish(int id)
        {
            _projectService.Finish(id);
            return NoContent();
        }


        [HttpDelete("id")]
        public IActionResult Delete(int id)
        {
            _projectService.Delete(id);
            return NoContent();
        }
        [HttpPost("{id}/comments")]
        public IActionResult PostComment([FromBody] CreateCommentInputModel inputModel)
        {
            _projectService.CreateComment(inputModel);
            return NoContent();
        }
    }
}
