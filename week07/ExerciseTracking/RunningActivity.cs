class Running : Activity
{
    private double _distance; // in miles

    public Running(string date, int duration, double distance)
        : base(date, duration)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return (_distance / Duration) * 60; // mph
    }

    public override double GetPace()
    {
        return Duration / _distance; // min/mile
    }

    public override string GetSummary()
    {
        return base.GetSummary() + $" - Distance: {GetDistance():0.0} miles, Speed: {GetSpeed():0.0} mph, Pace: {GetPace():0.0} min/mile";
    }
}