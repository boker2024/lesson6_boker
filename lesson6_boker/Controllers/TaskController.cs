using Lesson6.Core.Enities;
using Lesson6.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lesson6.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController(ITaskService service) : ControllerBase
    {
        public readonly ITaskService _taskService=service;
        [HttpGet]
        public ActionResult<List<MyTask>> GelAll()
        {
            return Ok(_taskService.GetAll());
        }
        [HttpPost]
        public ActionResult<MyTask> Add(MyTask m)
        {
            return Ok(_taskService.Add  (m));
        }
    }
}
