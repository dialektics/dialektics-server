using Dialektiks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dialektiks.Interfaces
{
    interface IGuildService
    {
        public void AddGuild(Guild g, User u);

        public List<User> GetAllGuildMembers(int user_id);

        public void DeleteGuild(int guild_id);

        public void UpdateGuildMemberCount(int guild_id);
    }
}
