using MindfullMinute.Application.JournalEntries.Dtos;
using MindfullMinute.Domain.Entities;


namespace MindfullMinute.Application.Common.Interfaces
{
    public interface IJournalService
    {
        Task<int> CreateJournalEntryAsync(JournalEntryDto dto, string userId);
        Task<List<JournalDetailsDto>> GetUserJournalEntriesAsync(string userId);
        Task<StreaksDto?> GetUserStreakAsync( string userId);
    }
}
