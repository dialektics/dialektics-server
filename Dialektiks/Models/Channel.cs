namespace Dialektiks.Models
{
    public class Channel
    {
        public int Id {  get; set; }
        public DateTime created_at {  get; set; }
        public int guild_id {  get; set; }
        public string name {  get; set; }
        public int type {  get; set; }
        public int last_message_id {  get; set; }
    }
}
