using System.ComponentModel.DataAnnotations.Schema;

namespace Chas_Events.Models
{
    public class Event
    {
        public int Id { get; set; }
        public User Creator { get; set; }
        public string EventTitle { get; set; }
        public string EventDescription { get; set; }
        public string EventNote { get; set; }
        public string EventNote2 { get; set; }
        public DateTime EventDate { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public TimeSpan Duration { get; set; }
        public string Location { get; set; }
        public ICollection<Tag> Tags { get; set; } = new List<Tag>();
        public ICollection<Comment> Comments { get; set; } = new List<Comment>();
        public ICollection<User> Interested { get; set; } = new List<User>();
        public ICollection<User> Attending { get; set; } = new List<User>();
        public ICollection<User> Organizers { get; set; } = new List<User>();
    }
}
