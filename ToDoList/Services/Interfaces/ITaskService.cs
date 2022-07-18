using DataAccess.DataModels.DTOs;

namespace ToDoList.Services.Interfaces
{
    public interface ITaskService
    {
        List<DataAccess.DataModels.Task> GetAll();
        DataAccess.DataModels.Task FindTaskById(int id);
        void NewTask(NewTaskDTO task);
        void DeleteTask(int id);
    }
}
