using DataAccess.DataModels;
using Microsoft.AspNetCore.Mvc;

namespace ToDoList.Services.Interfaces
{
    public interface IUserService
    {
        List<User> GetAll();
        Task<int> AddNew(User user);
        void DeleteUser(int id);
    }
}
