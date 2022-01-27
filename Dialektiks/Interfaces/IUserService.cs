using Dialektiks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dialektiks.Interfaces
{
    interface IUserService
    {
        public void AddUser(User u);

        public List<Guild> GetAllOwnedGuilds(int user_id);
        
        public void DeleteUser(int user_id);

        public void UpdateUsername(int user_id,string username);
    }
}
