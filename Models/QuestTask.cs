namespace VibeQuest.Models
{
    public class QuestTask
    {
        public ApplicationUser? User { get; set; }
        public string Title { get; set; } = string.Empty;
        public string SkillCategory { get; set; } = string.Empty;
        public int Difficulty { get; set; }  // 1 (easy) to 5 (hard), maybe?
        public bool IsCompleted { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public int XP => Difficulty * 10;
    }
}
