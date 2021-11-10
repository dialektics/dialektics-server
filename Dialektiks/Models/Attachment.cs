namespace Dialektiks.Models
{
    public class Attachment
    {
        public int Id { get; set; }
        public string filename { get; set; }
        public int message_id { get; set; }
        public int size { get; set; }
        public string url { get; set; }
        public int height { get; set; }
        public int width { get; set; }
    }
}
