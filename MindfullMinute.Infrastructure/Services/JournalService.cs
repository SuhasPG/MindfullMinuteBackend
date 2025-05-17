using Microsoft.EntityFrameworkCore;
using MindfullMinute.Application.Common.Interfaces;
using MindfullMinute.Application.JournalEntries.Dtos;
using MindfullMinute.Domain.Entities;
using MindfullMinute.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindfullMinute.Infrastructure.Services
{
    public class JournalService : IJournalService
    {
        private readonly AuthDbContext _context;
        private readonly StreakService _streakService;

        //public JournalService()
        //{
        //}

        public JournalService(AuthDbContext context, StreakService streakService)
        {
            _context = context;
            _streakService = streakService;

        }

        public async Task<int> CreateJournalEntryAsync(JournalEntryDto dto, string userId)
        {
            var entry = new JournalEntry
            {
                Title = dto.Title,
                Content = dto.Content,
                MoodEmoji = dto.MoodEmoji,
                UserId = userId
            };

            _context.JournalEntries.Add(entry);

            var streak = await _context.Streaks.FirstOrDefaultAsync(s => s.UserId == userId);
            if (streak == null)
            {
                streak = new Streak
                {
                    UserId = userId,
                    StartDate = entry.CreatedAt,
                    LastUpdated = entry.CreatedAt,
                    CurrentStreak = 1,
                    LongestStreak = 1
                };

                _context.Streaks.Add(streak);
            }
            else
            {
                _streakService.UpdateStreak(streak, entry.CreatedAt);
                _context.Streaks.Update(streak);
            }
            await _context.SaveChangesAsync();
            return entry.Id;
        }

        public Task DeleteJournalEntryAsync(string userId, int id)
        {
            return _context.JournalEntries
                .Where(j => j.Id == id && j.UserId == userId)
                .ExecuteDeleteAsync();
        }

        public async Task<List<JournalDetailsDto>> GetUserJournalEntriesAsync(string userId)
        {
            return await _context.JournalEntries
                .Where(j => j.UserId == userId)
                .Select(j => new JournalDetailsDto
                {
                    Id = j.Id,
                    Title = j.Title,
                    Content = j.Content,
                    MoodEmoji = j.MoodEmoji,
                    CreatedAt = j.CreatedAt
                }).ToListAsync();
        }

        public async Task<JournalDetailsDto> GetUserJournalEntryByIdAsync(string userId, int id)
        {
            return await _context.JournalEntries
                .Where(j => j.Id == id && j.UserId == userId)
                .Select(j => new JournalDetailsDto
                {
                    Id = j.Id,
                    Title = j.Title,
                    Content = j.Content,
                    MoodEmoji = j.MoodEmoji,
                    CreatedAt = j.CreatedAt

                }).FirstOrDefaultAsync();
        }

        public async Task<StreaksDto> GetUserStreakAsync(string userId)
        {
            var streak = await _context.Streaks.FirstOrDefaultAsync(s => s.UserId == userId);
            return new StreaksDto
            {
                CurrentStreak = streak?.CurrentStreak ?? 0,
                LongestStreak = streak?.LongestStreak ?? 0
            };


        }


        public async Task<JournalDetailsDto> UpdateEntry(string userId, int id, JournalEntryDto journalEntryDto)
        {
            var index = await _context.JournalEntries.FindAsync(id);
            if (index == null)
            {
                throw new Exception("Entry not found");
            }
            if (index.UserId != userId)
            {
                throw new Exception("You are not authorized to update this entry");
            }
            index.Title = journalEntryDto.Title;
            index.Content = journalEntryDto.Content;
            index.MoodEmoji = journalEntryDto.MoodEmoji;

            await _context.SaveChangesAsync();

            return new JournalDetailsDto
            {
                Id = index.Id,
                Title = index.Title,
                Content = index.Content,
                MoodEmoji = index.MoodEmoji,
                CreatedAt = index.CreatedAt
            };

        }

    }
}
