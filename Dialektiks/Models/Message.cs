namespace Dialektiks.Models
{
    public class Message
    {
        public int Id {  get; set; }
        public int channel_id {  get; set; }
        public int member_id {  get; set; }
        public int guild_id {  get; set; }
        public string content {  get; set; }
        public bool mention_everyone {  get; set; }
        public bool pinned {  get; set; }
        public DateTime? timestamp {  get; set; }
        public DateTime? edited_timestamp {  get; set; }
    }
}
