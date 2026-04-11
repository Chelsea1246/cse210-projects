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

    internal ReadOnlySpan<char> GetDisplayString()
    {
        throw new NotImplementedException();
    }
}