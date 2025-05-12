using VibeQuest.Models;

namespace VibeQuest.Services
{
    public class TaskService
    {
        public List<QuestTask> Tasks { get; private set; } = new();
        public SkillProgress Progress { get; private set; } = new();

        public void AddTask(QuestTask task)
        {
            Tasks.Add(task);
        }

        public void CompleteTask(QuestTask task)
        {
            if (!task.IsCompleted)
            {
                task.IsCompleted = true;
                int xp = task.Difficulty * 10;

                switch (task.SkillCategory.ToLower())
                {
                    case "mind": Progress.Mind += xp; break;
                    case "body": Progress.Body += xp; break;
                    case "creativity": Progress.Creativity += xp; break;
                    case "focus": Progress.Focus += xp; break;
                }
            }
        }
    }
}
