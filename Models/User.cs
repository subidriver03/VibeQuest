using Microsoft.AspNetCore.Identity;

namespace VibeQuest.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string HeroName { get; set; } = string.Empty;

        public SkillProgress SkillProgress { get; set; } = new();
        public ICollection<QuestTask> Tasks { get; set; } = new List<QuestTask>();
        public ICollection<JournalEntry> JournalEntries { get; set; } = new List<JournalEntry>();
    }
}
