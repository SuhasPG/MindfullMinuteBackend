using MindfullMinute.Application.JournalEntries.Dtos;
using MindfullMinute.Domain.Entities;


namespace MindfullMinute.Application.Common.Interfaces
{
    public interface IJournalService
    {
        public Task<JournalDetailsDto> UpdateEntry(string userId, int id, JournalEntryDto journalEntryDto);
        Task<int> CreateJournalEntryAsync(JournalEntryDto dto, string userId);
        Task DeleteJournalEntryAsync(string userId, int id);
        Task<List<JournalDetailsDto>> GetUserJournalEntriesAsync(string userId);
        public Task<JournalDetailsDto> GetUserJournalEntryByIdAsync(string userId, int id);
        Task<StreaksDto?> GetUserStreakAsync( string userId);
    }
}
