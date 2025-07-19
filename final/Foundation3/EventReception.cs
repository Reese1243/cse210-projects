class EventReception : Event
{
    private string _email = "";
    private int _maxCapacity = 0;
    private List<string> _attendees;

    public EventReception(string eventTitle, string description, string eventType, string email, DateOnly date, TimeOnly time, Address address, int maxCapacity, List<string> attendees) : base(eventTitle, description, eventType, date, time, address)
    {
        _maxCapacity = maxCapacity;
        _attendees = attendees;
        _email = email;
    }

    public override void FullDetails()
    {
        Console.WriteLine("Full Details:");
        StandardDetails();
        Console.WriteLine("registered attendees:");
        foreach (string attendee in _attendees)
        {
            Console.WriteLine(attendee);
        }
        Console.WriteLine($"Event Email: {_email}");
    }
}