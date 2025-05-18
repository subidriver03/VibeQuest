using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using VibeQuest.Models;

namespace VibeQuest.Services
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<SkillProgress> SkillProgresses { get; set; }
        public DbSet<QuestTask> QuestTasks { get; set; }
    }
}
