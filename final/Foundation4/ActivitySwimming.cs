class ActivitySwimming : Activity
{
    private double _numOfLaps = 0;

    public ActivitySwimming(int numOfLaps, DateOnly date, int minutes) : base(date, minutes)
    {
        _numOfLaps = numOfLaps;
    }

    public override void GetSummary()
    {
        double distance = Math.Round(GetDistance(_numOfLaps), 2);
        double speed = Math.Round(GetSpeed(distance), 2);
        double pace = Math.Round(GetPace(distance), 2);
        string summary = _date + " " + "Swimming" + $"({_minutes} min): " + $"Distance: {distance} miles," + " " + $"Speed: {speed} MPH"
        + " " + $"Pace: {pace} mins per mile";
        Console.WriteLine(summary);
    }


}