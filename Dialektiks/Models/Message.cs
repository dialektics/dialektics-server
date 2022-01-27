namespace Dialektiks.Models
{
    public class Message
    {
        public int Id {  get; set; }
        public int channelId {  get; set; }
        public Channel channel { get; set; } 
        public int memberId {  get; set; }
        public GuildMember member { get; set; }
        public int guildId {  get; set; }
        public Guild guild { get; set; }
        public string content {  get; set; }
        public bool mention_everyone {  get; set; }
        public bool pinned {  get; set; }
        public DateTime? timestamp {  get; set; }
        public DateTime? edited_timestamp {  get; set; }

        public List<Attachment> attachments { get; set; }
    }
}
