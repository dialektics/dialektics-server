using Dialektiks.Infrastructure;
using Dialektiks.Interfaces;
using Dialektiks.Models;

namespace Dialektiks.Services
{
    public class GuildService : IGuildService
    {
        private readonly Context _dbContext;

        public GuildService(Context dbContext)
        {
            _dbContext = dbContext;
        }

        public void AddGuild(Guild g, User u)
        {
            u.guilds.Add(g);

            _dbContext.SaveChanges();
        }

        public void DeleteGuild(int guild_id)
        {
            Guild g = _dbContext.Guilds.SingleOrDefault(g => g.Id == guild_id);
            _dbContext.Guilds.Remove(g);
            _dbContext.SaveChanges();
        }

        public List<User> GetAllGuildMembers(int user_id)
        {
            List<GuildMember> members = _dbContext.Guilds.SelectMany(g => g.members).ToList();
            return members.Select(m => m.user).ToList();
        }

        public void UpdateGuildMemberCount(int guild_id)
        {
            Guild g = _dbContext.Guilds.SingleOrDefault(g => g.Id == guild_id);
            g.member_count += 1;
            _dbContext.SaveChanges();
        }
    }
}
