using EmBackend.Utils;
using System.ComponentModel.DataAnnotations;

namespace EmBackend.Entities
{
    public class Event
    {
        [Key]
        public long Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.Now.Truncate(TimeSpan.TicksPerSecond);
        public DateTime UpdatedAt { get; set; } = DateTime.Now.Truncate(TimeSpan.TicksPerSecond);
        public DateTime Date { get; set; }
    }
}
