using DataAccess.DataModels;
using Microsoft.AspNetCore.Mvc;
using ToDoList.Services.Interfaces;

namespace ToDoList.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController: ControllerBase
    {
        private readonly IUserService _userService;
        
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        [Route("all")]
        public List<User> Users()
        {
            return _userService.GetAll();
        }

        [HttpPost]
        [Route("new")]
        public async Task<int> NewUser([FromBody] User user)
        {
            return await _userService.AddNew(user);
        }

        [HttpDelete]
        [Route("delete/{id}")]
        public void DeleteUser(int id)
        {
            _userService.DeleteUser(id);
        }
    }
}
