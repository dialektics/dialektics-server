namespace Dialektiks.Models
{
    public class Relationship
    {
        public int Id { get; set; }
        public int from_id { get; set; }
        public int to_id { get; set; }
        public int type { get; set; }
    }
}
