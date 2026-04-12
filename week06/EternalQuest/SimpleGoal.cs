public class SimpleGoal : Goal
{
    private bool _isComplete;
   
    public SimpleGoal(string name, string description, int points) 
        : base(name, description, points){}

    public override void RecordEvent()
    {
        _isComplete = true;
        base.RecordEvent();
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetDisplayString()
    {
        string status = IsComplete() ? "[X]" : "[ ]";
        return $"{status} {Name} ({Description})";
    }
}