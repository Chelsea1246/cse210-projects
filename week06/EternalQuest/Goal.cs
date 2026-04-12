public class Goal
{
    public string Name;
    public string Description;
    public int Points;
    public Goal(string name, string description, int points)
    {
        Name = name;
        Description = description;
        Points = points;
    }

    public virtual void RecordEvent()
    {
        Console.WriteLine($"You have completed the goal: {Name} and earned {Points} points!");
    }

    public virtual string GetDisplayString()
    {
        return $"{Name} ({Description})";
    }
    public virtual bool IsComplete()
    {
        return false;
    }
}