//using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNetCore.Identity;


namespace MindfullMinute.Domain.Entities
{
    public class JournalEntry
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public required string Content { get; set; }
        public required string MoodEmoji { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now; //added now

        public string UserId { get; set; }
        public IdentityUser User { get; set; }
    }
}
