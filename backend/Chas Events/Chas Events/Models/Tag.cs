namespace Chas_Events.Models
{
    public class Tag
    {
        public int Id { get; set; }
        public string TagName { get; set; }
        public ICollection<Event> Events { get; set; } = new List<Event>();
    }
}
