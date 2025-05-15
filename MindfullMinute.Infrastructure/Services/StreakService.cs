using MindfullMinute.Domain.Entities;

namespace MindfullMinute.Infrastructure.Services
{
    public class StreakService
    {
        public void UpdateStreak(Streak streak, DateTime journalDate)
        {
            // Only update if the journal entry is after the last update (ignore same-day or backdated entries)
            if (journalDate.Date <= streak.LastUpdated.Date)
                return;

            var expectedNextDate = streak.LastUpdated.Date.AddDays(1);

            if (journalDate.Date == expectedNextDate)
            {
                streak.CurrentStreak++;
                streak.LastUpdated = journalDate.Date;
            }
            else if (journalDate.Date > expectedNextDate)
            {
                streak.CurrentStreak = 1;
                streak.StartDate = journalDate.Date;
                streak.LastUpdated = journalDate.Date;
            }

            if (streak.CurrentStreak > streak.LongestStreak)
            {
                streak.LongestStreak = streak.CurrentStreak;
            }
        }
    }
}
