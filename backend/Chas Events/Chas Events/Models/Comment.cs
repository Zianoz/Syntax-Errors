namespace Chas_Events.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public User Author { get; set; }
        public string Text { get; set; }
        public string ProfilePicture { get; set; }
        public DateTime CreatedAt { get; set; }
        public Event Event { get; set; }
    }
}
