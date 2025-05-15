using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MindfullMinute.Application.Common.Interfaces;
using MindfullMinute.Application.JournalEntries.Dtos;
using MindfullMinute.Infrastructure.Services;

namespace MindfullMinute.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JournalController : ControllerBase
    {

        private readonly IJournalService _journalService;
        private readonly UserManager<IdentityUser> _userManager;
        //private readonly StreakService _streakService;
        public JournalController(IJournalService journalService, UserManager<IdentityUser> userManager)
        {
            _journalService = journalService;
            _userManager = userManager;
            
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] JournalEntryDto dto)
        {
            var userId = _userManager.GetUserId(User);
            var id = await _journalService.CreateJournalEntryAsync(dto, userId);
            return Ok(new { Id = id });
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var userId = _userManager.GetUserId(User);
            var entries = await _journalService.GetUserJournalEntriesAsync(userId);
            return Ok(entries);
        }

        [HttpGet("streak")]
        public async Task<IActionResult> GetStreak()
        {
            var userId = _userManager.GetUserId(User);
            var streak = await _journalService.GetUserStreakAsync(userId);
            return Ok(streak);
        }


    }
}
