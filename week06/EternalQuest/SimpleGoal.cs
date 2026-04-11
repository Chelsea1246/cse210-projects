public class SimpleGoal : Goal
{
    private bool _isComplete;
    private object _description;

    public SimpleGoal(string name, string desc, int points) 
        : base(name, desc, points)
    {
        _isComplete = false;
    }

    public override void RecordEvent()
    {
        _isComplete = true;
    }

    public override bool IsComplete
    {
        get { return _isComplete; }
    }

    public override string GetDisplayString()
    {
        string status = _isComplete ? "[X]" : "[ ]";
        return $"{status} {Name} ({Description})";
    }
}