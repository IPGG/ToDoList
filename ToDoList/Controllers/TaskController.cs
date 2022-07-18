using DataAccess.DataModels.DTOs;
using Microsoft.AspNetCore.Mvc;
using ToDoList.Services.Interfaces;

namespace ToDoList.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TaskController: ControllerBase
    {
        private readonly ITaskService _taskService;

        public TaskController(ITaskService taskService)
        {
            _taskService = taskService;
        }

        [HttpGet]
        [Route("all")]
        public List<DataAccess.DataModels.Task> Tasks()
        {
            return _taskService.GetAll();
        }

        [HttpGet]
        [Route("{id}")]
        public DataAccess.DataModels.Task FindTaskById(int id)
        {
            return _taskService.FindTaskById(id);
        }

        [HttpPost]
        [Route("new")]
        public void NewTask([FromBody] NewTaskDTO task)
        {
            _taskService.NewTask(task);
        }

        [HttpDelete]
        [Route("delete/{id}")]
        public void DeleteTask(int id)
        {
            _taskService.DeleteTask(id);
        }
    }
}
