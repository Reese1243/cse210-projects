class ActivityCycle : Activity
{
    private double _speed = 0;

    public ActivityCycle(double speed, DateOnly date, int minutes) : base(date, minutes)
    {
        _speed = speed;
    }

    protected double GetDistance()
    {
        double distance = _speed / 60 * _minutes;
        
        return Math.Round(distance, 2);
    }
    
    public override void GetSummary()
    {
        double distance = GetDistance();
        double pace = Math.Round(GetPace(distance), 1);
        string summary = _date + " " + "Cycling" + $"({_minutes} min): " + $"Distance: {distance} miles," + " " + $"Speed: {_speed} MPH"
        + " " + $"Pace: {pace} mins per mile";
        Console.WriteLine(summary);
    }
}