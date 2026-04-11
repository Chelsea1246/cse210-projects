public class ChecklistGoal : Goal
{
    private int _target;
    private int _count;
    private int _bonus;

    public ChecklistGoal(string name, string desc, int points, int target, int bonus)
        : base(name, desc, points)
    {
        _target = target;
        _bonus = bonus;
        _count = 0;
    }

    public override void RecordEvent()
    {
        _count++;
    }

    public override bool IsComplete()
    {
        return _count >= _target;
    }

    public override string   GetDisplayString
    {
        get
        {
            string status = IsComplete() ? "[X]" : "[ ]";
            return $"{status} {Name} ({Description}) -- Completed {_count}/{_target}";
        }
    }
}