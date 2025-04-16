public abstract class Goal
{
    private string _shortName;
    protected string _description;
    private string _points;

    public Goal(string name, string description, string points)
    {
        _shortName = name;
        _description = description;
        _points = points;

    }
    public string GetShortName()
    {
        return _shortName;
    }

    public  virtual int GetPoints()
    {
        return int.Parse(_points);
    }
    public abstract void RecordEvent();
    

    

    public abstract bool IsComplete();
    

    public virtual string GetDetailsString()
    {
        string representation;
        if (this is EternalGoal)
        {
            representation = "[∞]";
        }
        else if (IsComplete())
        {
            representation = "[X]";
        }
        else 
        {
            representation = "[]";
        }
        
        return $"{representation} {_shortName} ({_description})";
    }

    public abstract string GetStringRepresentation();
    
}