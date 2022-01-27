using Bogus;
using Dialektiks.Infrastructure;
using Dialektiks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dialektiks.Services
{
    public class SeedService
    {
        private readonly Context _dbContext;

        public SeedService(Context dbContext)
        {
            _dbContext = dbContext;
        }


        public void DeleteDatabase()
        {
            _dbContext.Database.EnsureDeleted();
        }
        public void CreateDatabase()
        { 
            _dbContext.Database.EnsureCreated();
        }

        public void Seed()
        {
            Randomizer.Seed = new Random(27963);
            Random random = new Random();

            var users = new Faker<User>("en").Rules((f, e) =>
            {
                e.username = f.Internet.UserName();
                e.discriminator = f.Random.Int().ToString();
                e.bot = f.Random.Bool();
                e.bio = f.Lorem.Paragraph();
                e.created_at = f.Date.Recent();
                e.verified = f.Random.Bool();
                e.disabled = f.Random.Bool();
                e.email = f.Internet.Email();
                e.settings = "ok cool";
            })
            .Generate(5)
            .ToList();

            var relationships = new Faker<Relationship>("en").Rules((f, e) =>
            {
                e.type = f.Random.Int();

                e.from = f.Random.ListItem(users);
                e.to = f.Random.ListItem(users);
            })
            .Generate(5)
            .ToList();

            var guilds = new Faker<Guild>("en").Rules((f, e) =>
            {
                e.banner = f.Name.JobTitle();
                e.description = f.Name.JobDescriptor();
                e.icon = f.Name.FirstName();
                e.max_members = f.Random.Int();
                e.member_count = 0;
                e.name = f.Name.FullName();

                e.owner = f.Random.ListItem(users);
            })
            .Generate(5)
            .ToList();

            var channels = new Faker<Channel>("en").Rules((f, e) =>
            {
                e.name = f.Name.JobTitle();
                e.created_at = f.Date.Recent();
                var values = typeof(ChannelType).GetEnumValues();
                e.type = (ChannelType)values.GetValue(random.Next(values.Length));

                e.guild = f.Random.ListItem(guilds);
            })
            .Generate(5)
            .ToList();

            var guildmembers = new Faker<GuildMember>("en").Rules((f, e) =>
            {
                e.nick = f.Internet.UserName();
                e.joined_at = f.Date.Recent();

                e.user = f.Random.ListItem(users);
                e.guild = f.Random.ListItem(guilds);
                //e.last_message = null;
            })
            .Generate(5)
            .ToList();

            var messages = new Faker<Message>("en").Rules((f, e) =>
            {
                e.content = f.Internet.ExampleEmail();
                e.mention_everyone = f.Random.Bool();
                e.pinned = f.Random.Bool();
                e.timestamp = f.Date.Recent();
                e.edited_timestamp = f.Date.Recent();

                e.channel = f.Random.ListItem(channels);
                e.member = f.Random.ListItem(guildmembers);
                e.guild = f.Random.ListItem(guilds);
            })
            .Generate(5)
            .ToList();

            var attachments = new Faker<Attachment>("en").Rules((f, e) =>
            {
                e.filename = f.Name.LastName();
                e.size = f.Random.Int();
                e.url = f.Internet.Url();
                e.height =f.Random.Int(); 
                e.width =f.Random.Int();

                e.message = f.Random.ListItem(messages);
            })
            .Generate(5)
            .ToList();

            _dbContext.Users.AddRange(users);
            _dbContext.SaveChanges();
            _dbContext.Relationships.AddRange(relationships);
            _dbContext.SaveChanges();
            _dbContext.Guilds.AddRange(guilds);
            _dbContext.SaveChanges();
            _dbContext.Channels.AddRange(channels);
            _dbContext.SaveChanges();
            _dbContext.GuildMembers.AddRange(guildmembers);
            _dbContext.SaveChanges();
            _dbContext.Messages.AddRange(messages);
            _dbContext.SaveChanges();
            _dbContext.Attachments.AddRange(attachments);
            _dbContext.SaveChanges();
        }
    }
}
