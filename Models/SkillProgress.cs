namespace VibeQuest.Models;

public class SkillProgress

{
    public int Mind { get; set; }
    public int Body { get; set; }
    public int Creativity { get; set; }
    public int Focus { get; set; }

    public int TotalXP => Mind + Body + Creativity + Focus;
}
