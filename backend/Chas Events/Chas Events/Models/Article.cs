namespace Chas_Events.Models
{
    public class Article
    {
        public int Id { get; set; }
        public User Author { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Note { get; set; }
        public DateTime PublishedAt { get; set; }
    }
}
