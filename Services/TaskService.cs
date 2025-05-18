using VibeQuest.Models;

namespace VibeQuest.Services
{
    public class TaskService
    {
        // Task and skill tracking
        public List<QuestTask> Tasks { get; private set; } = new();
        public SkillProgress Progress { get; private set; } = new();

        // Journal entries
        private List<JournalEntry> _journalEntries = new();
        public List<JournalEntry> GetJournalEntries() => _journalEntries;

        // Add a new task
        public void AddTask(QuestTask task)
        {
            Tasks.Add(task);
        }

        // Mark task as completed and award XP
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

        // Add a journal entry and award Mental Clarity XP
        public void AddJournalEntry(JournalEntry entry)
        {
            _journalEntries.Add(entry);
            Progress.Mind += 5; // Optional: Adjust XP for reflections
        }

        // Spend XP across categories (prioritized)
        public bool SpendXP(int amount)
        {
            if (Progress.TotalXP < amount)
                return false;

            // Try to deduct from largest pool first
            var pools = new List<(string Skill, int XP)>
            {
                ("Mind", Progress.Mind),
                ("Body", Progress.Body),
                ("Creativity", Progress.Creativity),
                ("Focus", Progress.Focus)
            };

            pools = pools.OrderByDescending(p => p.XP).ToList();

            foreach (var (skill, _) in pools)
            {
                int available = GetSkillXP(skill);
                int toDeduct = Math.Min(available, amount);

                SetSkillXP(skill, available - toDeduct);
                amount -= toDeduct;

                if (amount <= 0) break;
            }

            return true;
        }

        private int GetSkillXP(string skill) =>
            skill switch
            {
                "Mind" => Progress.Mind,
                "Body" => Progress.Body,
                "Creativity" => Progress.Creativity,
                "Focus" => Progress.Focus,
                _ => 0
            };

        private void SetSkillXP(string skill, int value)
        {
            switch (skill)
            {
                case "Mind": Progress.Mind = value; break;
                case "Body": Progress.Body = value; break;
                case "Creativity": Progress.Creativity = value; break;
                case "Focus": Progress.Focus = value; break;
            }
        }
    }
}
