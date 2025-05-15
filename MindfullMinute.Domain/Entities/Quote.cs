

namespace MindfullMinute.Domain.Entities
{
    public class Quote
    {
        public int Id { get; set; }
        public required string Text { get; set; }
        public required string Author { get; set; }
        
    }
}
