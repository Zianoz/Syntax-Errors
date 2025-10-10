namespace Chas_Events.Models
{
    public class Notification
    {
        public int Id { get; set; }
        public User Recipient { get; set; }
        public string Message { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsRead { get; set; }
    }
}
