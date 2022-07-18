using DataAccess.DataModels;
using Microsoft.AspNetCore.Mvc;
using ToDoList.Repositories.Interfaces;
using ToDoList.Services.Interfaces;

namespace ToDoList.Services
{
    public class UserService: IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public List<User> GetAll()
        {
            return _userRepository.GetAll();
        }

        public async Task<int> AddNew(User user)
        {
            return await _userRepository.AddNew(user);
        }

        public void DeleteUser(int id)
        {
            _userRepository.DeleteUser(id);
        }
    }
}
