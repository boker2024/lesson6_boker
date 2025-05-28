using Lesson6.Core.Enities;
using Lesson6.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lesson6.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController(IProjectService service) : ControllerBase
    {
        private readonly IProjectService _projectService = service;
        [HttpGet]
        public ActionResult<List<MyTask>> GetAllTasks()
        {
            return Ok(_projectService.GetAll());

        }
        [HttpGet("{id}")]
        public ActionResult<MyTask> GetTaskById(int id)
        {
            var task = _projectService.GetById(id);
            if (task is null)
                return NotFound();
            return Ok(task);
        }

        [HttpDelete("{id}")]
        public ActionResult<MyTask> DeleteProjectById(int id)
        {
            var p = _projectService.DeleteById(id);
            if (p is null)
                return NotFound();
            return Ok(p);
        }

        [HttpPost]
        public ActionResult<MyTask> AddProject([FromBody] Project t)
        {
            var task = _projectService.Add(t);
            return Ok(task);
        }


        [HttpPut("{id}")]
        public ActionResult<MyTask> UpdateProject([FromRoute] int id, [FromBody] Project t)
        {
            var p = _projectService.Update(id, t);
            if (p is null)
                return NotFound();
            return Ok(p);
        }


    }
}
