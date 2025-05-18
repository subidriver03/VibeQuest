public class SkillProgress
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public string SkillType { get; set; } = string.Empty;
    public int XP { get; set; }

    public User? User { get; set; }
}
