namespace Dialektiks.Models
{
    public class Relationship
    {
        public int Id { get; set; }
        public int fromId { get; set; }
        public User from { get; set; }
        public int toId { get; set; }
        public User to { get; set; }
        public int type { get; set; }
    }
}
