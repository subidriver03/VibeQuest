namespace VibeQuest.Models
{
    public class JournalEntry
    {
        public int Id { get; set; }
        public string Text { get; set; } = string.Empty;
        public DateTime Timestamp { get; set; }
    }
}
