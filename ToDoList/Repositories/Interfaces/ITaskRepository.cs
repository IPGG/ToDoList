namespace ToDoList.Repositories.Interfaces
{
    public interface ITaskRepository
    {
        List<DataAccess.DataModels.Task> AllTasks();
        void NewTask(DataAccess.DataModels.Task task);
        DataAccess.DataModels.Task GetTaskById(int id);
        void DeleteTask(DataAccess.DataModels.Task task);
    }
}
