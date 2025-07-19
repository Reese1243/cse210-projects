class ActivityRunning : Activity
{
    private double _distance = 0;

    public ActivityRunning(double distance, DateOnly date, int minutes) : base(date, minutes)
    {
        _distance = distance;
    }

    public override void GetSummary()
    {
        double speed = GetSpeed(_distance);
        double pace = GetPace(_distance);
        string summary = _date + " " + "Running" + $"({_minutes} min): " + $"Distance: {_distance} miles," + " " + $"Speed: {speed} MPH"
        + " " + $"Pace: {pace} mins per mile";
        Console.WriteLine(summary);
    }
}