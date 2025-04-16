public class ChecklistGoal : Goal
{
    private int _amountCompleted = 0;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, string points, int bonus, int target, int amountCompleted) : base(name, description, points)
    {
        _bonus = bonus;
        _target = target;
        _amountCompleted = amountCompleted;
        
    }

    
    public override void RecordEvent()
    {
        _amountCompleted ++;
        Console.WriteLine($"Congratulations! You have completed '{GetShortName()}' {_amountCompleted} times");

        if (_amountCompleted >= _target)
        {
            Console.WriteLine($"Congratulations! You've completed the goal and earned a bonus");
        }

    }
    public override int GetPoints()
    {
        if (_amountCompleted >= _target)
        {
            return base.GetPoints() + _bonus;
        }
        return base.GetPoints();
    }
    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetDetailsString()
    {
        return $"[ ] {GetShortName()} ({_description}) -- Currently Completed {_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal,{GetShortName()},{_description},{GetPoints()},{_bonus},{_target},{_amountCompleted}";
    }

    

}