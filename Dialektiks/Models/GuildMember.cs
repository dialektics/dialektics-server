namespace Dialektiks.Models
{
    public class GuildMember
    {
        public int Id { get; set; }
        public int userId { get; set; }
        public User user { get; set; }
        public int guildId { get; set; }
        public Guild guild { get; set; }
        public string nick { get; set; }
        public DateTime joined_at { get; set; }
        //public int last_message_id { get; set; }
        //public Message last_message { get; set; }

        public List<Message> messages { get; set; }
    }
}
