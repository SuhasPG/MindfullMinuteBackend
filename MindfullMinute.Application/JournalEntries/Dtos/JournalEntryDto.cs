

using MindfullMinute.Domain;
using System.ComponentModel.DataAnnotations;

namespace MindfullMinute.Application.JournalEntries.Dtos
{
    public class JournalEntryDto
    {
        [Required]
        [MaxLength(100)]
        public string Title { get; set; }

        [Required]
        public string Content { get; set; }

        [Required]
        [MoodValidation] 
        public string MoodEmoji { get; set; }
    }

}
