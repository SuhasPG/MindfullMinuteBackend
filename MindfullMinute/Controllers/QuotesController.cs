using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MindfullMinute.Application.JournalEntries.Dtos;
using MindfullMinute.Infrastructure.Data;
using System;

namespace MindfullMinute.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuotesController : ControllerBase
    {
        private readonly AuthDbContext _context;

        public QuotesController(AuthDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<QuotesFetchDto>>> GetQuotes()
        {
            var quotes = await _context.Quotes
                .Select(q => new QuotesFetchDto
                {
                    Text = q.Text,
                    Author = q.Author
                })
                .ToListAsync();

            return Ok(quotes);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<QuotesFetchDto>>> GetQuotesById(int id)
        {
            var quote = await _context.Quotes
                .Where(q => q.Id == id)
                .Select(q => new QuotesFetchDto
                {
                    Text = q.Text,
                    Author = q.Author
                })
                .ToListAsync();
            if(quote.Count == 0)
            {
                return NotFound();
            }
            return Ok(quote);
        }

        [HttpGet("Count")]
        public async Task<int> GetNumberOfQuotesStored()
        {
            int count = await _context.Quotes.CountAsync();
            return count;
        }
    }
}
