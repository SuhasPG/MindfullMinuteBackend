using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindfullMinute.Application.JournalEntries.Dtos
{
    public class JournalDetailsDto
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string MoodEmoji { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
