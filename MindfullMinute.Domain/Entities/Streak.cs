

using Microsoft.AspNetCore.Identity;

namespace MindfullMinute.Domain.Entities
{
    public class Streak
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime LastUpdated { get; set; }
        public int CurrentStreak { get; set; }
        public int LongestStreak { get; set; }

        public string UserId { get; set; }
        public IdentityUser User { get; set; }

    }
}
