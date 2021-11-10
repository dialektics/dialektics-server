namespace Dialektiks.Models
{
    public class GuildMember
    {
        public int Id { get; set; }
        public int user_id { get; set; }
        public int guild_id { get; set; }
        public string nick { get; set; }
        public DateTime joined_at { get; set; }
        public int last_message_id { get; set; }
    }
}
