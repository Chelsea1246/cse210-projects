public class ChecklistGoal : Goal
{
    private int _target;
    private int _count;

    public ChecklistGoal(string name, string description, int points, int target)
        : base(name, description, points)
    {
        _target = target;
    }

    public override void RecordEvent()
    {
        _count++;
    }

    public override bool IsComplete()
    {
        return _count >= _target;
    }

    public override string GetDisplayString()   
    {
        string status = IsComplete() ? "[X]" : "[ ]";
        return $"{status} {Name} ({Description}) -- Completed {_count}/{_target}";
    }
}