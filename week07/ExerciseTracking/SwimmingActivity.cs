class Swimming : Activity
{
    private int _laps;

    public Swimming(string date, int duration, int laps)
        : base(date, duration)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * 50 / 1000.0 * 0.62; // Convert laps to miles
    }

    public override double GetSpeed()
    {
        return (GetDistance() / Duration) * 60; // mph
    }

    public override double GetPace()
    {
        return Duration / GetDistance(); // min/mile
    }

    public override string GetSummary()
    {
        return base.GetSummary() + $" - Distance: {GetDistance():0.0} miles, Speed: {GetSpeed():0.0} mph, Pace: {GetPace():0.0} min/mile";
    }
}