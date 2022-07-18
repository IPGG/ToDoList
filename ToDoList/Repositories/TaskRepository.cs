using DataAccess.DataModels;
using ToDoList.Repositories.Interfaces;

namespace ToDoList.Repositories
{
    public class TaskRepository: ITaskRepository
    {
        private readonly Context _context;

        public TaskRepository(Context context)
        {
            _context = context;
        }

        public List<DataAccess.DataModels.Task> AllTasks()
        {
            return _context.Tasks.ToList();
        }

        public void NewTask(DataAccess.DataModels.Task task)
        {
            _context.Tasks.Add(task);
            _context.SaveChanges();
        }
        
        public DataAccess.DataModels.Task GetTaskById(int id)
        {
            return _context.Tasks.Where(x => x.Id == id).FirstOrDefault();
        }

        public void DeleteTask(DataAccess.DataModels.Task task)
        {
            _context.Tasks.Remove(task);
            _context.SaveChanges();
        }
    }
}
