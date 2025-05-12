namespace VibeQuest.Models;

public class QuestTask

{
    public string Title { get; set; }
    public string SkillCategory { get; set; }
    public int Difficulty { get; set; }
    public bool IsCompleted { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
}
