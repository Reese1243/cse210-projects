class EventGathering : Event
{
    private string _weather = "";

    public EventGathering(string eventTitle, string description, string eventType, DateOnly date, TimeOnly time, Address address, string weather) : base(eventTitle, description, eventType, date, time, address)
    {
        _weather = weather;
    }

    public override void FullDetails()
    {
        Console.WriteLine("Full Details:");
        StandardDetails();
        Console.WriteLine($"The Weather might be {_weather} today");
    }
}