namespace Dialektiks.Models
{
    public class User
    {
        public int Id {  get; set; }
        public string username {  get; set; }
        public string discriminator {  get; set; }
        public Boolean bot {  get; set; }
        public string bio {  get; set; }
        public DateTime? created_at {  get; set; }
        public Boolean verified {  get; set; }
        public Boolean disabled {  get; set; }
        public string email {  get; set; }
        public JsonContent settings {  get; set; }
    }
}
