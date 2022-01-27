using Dialektiks.Infrastructure;
using Dialektiks.Interfaces;
using Dialektiks.Models;

namespace Dialektiks.Services
{
    public class UserService : IUserService
    {
        private readonly Context _dbContext;

        public UserService(Context dbContext)
        {
            _dbContext = dbContext;
        }
        
        public void AddUser(User u)
        {
            _dbContext.Entry(u).State = Microsoft.EntityFrameworkCore.EntityState.Added;
            _dbContext.SaveChanges();
        }

        public void DeleteUser(int user_id)
        {
            User u = _dbContext.Users.SingleOrDefault(u => u.Id == user_id);
            _dbContext.Users.Remove(u);
            _dbContext.SaveChanges();
        }

        public List<Guild> GetAllOwnedGuilds(int user_id)
        {
            return _dbContext.Users.SingleOrDefault(u => u.Id == user_id).guilds;
            
        }

        public void UpdateUsername(int user_id,string username)
        {
            User u = _dbContext.Users.SingleOrDefault(u => u.Id == user_id);
            u.username = username;
            _dbContext.SaveChanges();
        }
    }
}
