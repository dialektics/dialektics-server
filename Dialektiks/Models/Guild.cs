namespace Dialektiks.Models
{
    public class Guild
    {
        public int Id {  get; set; }
        public string banner {  get; set; }
        public int ownerId {  get; set; }
        public User owner { get; set; }
        public string description {  get; set; }
        public string icon {  get; set; }
        public int max_members {  get; set; }
        public int member_count {  get; set; }
        public string name {  get; set; }

        public List<Channel> channels { get; set; }
        public List<Message> messages { get; set; }
        public List<GuildMember> members { get; set; }
    }
}
