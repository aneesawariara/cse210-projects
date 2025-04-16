public class SimpleGoal : Goal
{
    private bool _isComplete = false;

    public SimpleGoal(string name, string description, string points) : base(name, description, points)
    {
        
    }

    public override void RecordEvent()
    {
        _isComplete = true;
        Console.WriteLine($"Goal {GetShortName()} marked as complete.");
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        return $"Simple Goal,{GetShortName()},{_description},{GetPoints()},{_isComplete}";
    }

    

}