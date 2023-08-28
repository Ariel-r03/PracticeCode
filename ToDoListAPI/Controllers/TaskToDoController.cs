using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using ToDoListAPI.Data;
using ToDoListAPI.Models;

namespace ToDoListAPI.Controllers
{

    [ApiController]
    [Route("/tasks")]
    public class TaskToDoController : ControllerBase
    {
        [HttpGet]

        public async Task <ActionResult<List<TaskToDo>>> GetAll()
        {
            var function = new DTask();
            return Ok(await function.ShowTasks()) ;
        }

        [HttpPut]

        public async Task <ActionResult> Update([FromBody]TaskToDo parameters)
        {
            var function = new DTask();
            await function.UpdateStatus(parameters);
            return Ok();
        }

        [HttpPost]

        public async Task <ActionResult> Add([FromBody] TaskToDo parameters)
        {
            var function=new DTask();
            await function.AddNewTask(parameters);
            return Ok();
        }

        [HttpDelete("{id}")]

        public async Task DeleteTask(int id)
        {
            var function = new DTask();
            await function.DeleteTask(id);
        }

    }
}
