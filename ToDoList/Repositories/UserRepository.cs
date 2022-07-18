using DataAccess.DataModels;
using Microsoft.AspNetCore.Mvc;
using ToDoList.Repositories.Interfaces;

namespace ToDoList.Repositories
{
    public class UserRepository: IUserRepository
    {
        private readonly Context _context;

        public UserRepository(Context context)
        {
            this._context = context;
        }

        public List<User> GetAll()
        {
            return this._context.Users.ToList();
        }

        public User FindUserById(int id)
        {
            return this._context.Users.Where(x => x.Id == id).FirstOrDefault();
        }

        public async Task<int> AddNew(User user)
        {
            await _context.Users.AddAsync(user);
            return await _context.SaveChangesAsync();            
        }

        public void DeleteUser(int id)
        {
            var targetUser = _context.Users.Where(x => x.Id == id).FirstOrDefault();
            if (targetUser != null)
            {
                _context.Users.Remove(targetUser);
                _context.SaveChanges();
            }
        }
    }
}
