namespace Dialektiks.Models
{
    public class Attachment
    {
        public int Id { get; set; }
        public string filename { get; set; }
        public int messageId { get; set; }
        public Message message { get; set; }
        public int size { get; set; }
        public string url { get; set; }
        public int height { get; set; }
        public int width { get; set; }
    }
}
