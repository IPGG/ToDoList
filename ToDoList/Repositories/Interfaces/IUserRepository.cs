using DataAccess.DataModels;
using Microsoft.AspNetCore.Mvc;

namespace ToDoList.Repositories.Interfaces
{
    public interface IUserRepository
    {
        List<User> GetAll();
        User FindUserById(int id);
        Task<int> AddNew(User user);
        void DeleteUser(int id);
    }
}
