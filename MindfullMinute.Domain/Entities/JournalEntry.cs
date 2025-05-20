//using Microsoft.AspNet.Identity.EntityFramework;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;


namespace MindfullMinute.Domain.Entities
{
    public class JournalEntry
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public required string Title { get; set; }
        [Required]
        public required string Content { get; set; }
        [Required]
        [MoodValidation]
        public required string MoodEmoji { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now; 

        public string UserId { get; set; }
        public IdentityUser User { get; set; }
    }
}
