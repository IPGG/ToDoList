using DataAccess.DataModels;
using Moq;
using ToDoList.Repositories.Interfaces;
using ToDoList.Services;

namespace ToDoListTests
{
    public class Tests
    {
        private IUserRepository _userRepository;

        [SetUp]
        public void Setup()
        {
            var users = new List<User>()
            {
                new User()
                {
                    Id = 1,
                    Name = "Test",
                    Role = Role.Admin
                },
            };

            var userRepoMock = new Mock<IUserRepository>();
            userRepoMock.Setup(repo => repo.GetAll()).Returns(users);

            _userRepository = userRepoMock.Object;
        }

        [Test]
        public void Test1()
        {
            var service = new UserService(_userRepository);
            
            Assert.AreEqual(service.GetAll().Count(), 1);
        }
    }
}