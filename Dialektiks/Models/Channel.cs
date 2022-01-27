using System.ComponentModel.DataAnnotations;

namespace Dialektiks.Models
{
    public class Channel
    {
        public int Id {  get; set; }
        public DateTime created_at {  get; set; }
        public int guildId {  get; set; }
        public Guild guild { get; set; }
        public string name {  get; set; }
        public ChannelType type {  get; set; }
        //public int last_message_id {  get; set; }
        //public Message? last_message { get; set; }

        public List<Message>? messages { get; set; } 
    }
}
