using DataAccess.DataModels.DTOs;
using ToDoList.Repositories.Interfaces;
using ToDoList.Services.Interfaces;

namespace ToDoList.Services
{
    public class TaskService: ITaskService
    {
        private readonly ITaskRepository _taskRepository;
        private readonly IUserRepository _userRepository;

        public TaskService(ITaskRepository taskRepository, IUserRepository userRepository)
        {
            _taskRepository = taskRepository;
            _userRepository = userRepository;
        }

        public List<DataAccess.DataModels.Task> GetAll()
        {
            var tasks = _taskRepository.AllTasks();
            tasks.ForEach(task =>
            {
                task.Assignee = _userRepository.FindUserById(task.AssigneeID);
            });
            return tasks;
        }

        public DataAccess.DataModels.Task FindTaskById(int id)
        {
            var task = _taskRepository.GetTaskById(id);
            task.Assignee = _userRepository.FindUserById(task.AssigneeID);
            return task;
        }

        public void NewTask(NewTaskDTO task)
        {
            var creatingUser = _userRepository.FindUserById(task.CreatingUserId);
            if (creatingUser == null)
            {
                return;
            }
            var newTask = new DataAccess.DataModels.Task();
            newTask.Name = task.Name;
            newTask.Description = task.Description;
            newTask.Assignee = creatingUser;
            newTask.CreatedOn = DateTime.Now;
            _taskRepository.NewTask(newTask);
        }

        public void DeleteTask(int id)
        {
            var targetTask = _taskRepository.GetTaskById(id);
            if (targetTask == null)
            {
                return;
            }
            _taskRepository.DeleteTask(targetTask);
        }
    }
}
