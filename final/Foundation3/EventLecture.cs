class EventLecture : Event
{
    private string _speakerName = "";
    private int _maxCapacity = 0;

    public EventLecture(string eventTitle, string eventDesc, string eventType, DateOnly date, TimeOnly time, Address address, string speakerName, int maxCapacity)
        : base(eventTitle, eventDesc, eventType, date, time, address)
    {
        _speakerName = speakerName;
        _maxCapacity = maxCapacity;
    }

    public override void FullDetails()
    {
        Console.WriteLine("Full Details:");
        StandardDetails();
        Console.WriteLine($"Speaker: {_speakerName}");
        Console.WriteLine($"Max Capacity: {_maxCapacity}");
    }
    
}