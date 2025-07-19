using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

abstract class Event
{
    protected string _eventTitle = "";
    protected string _eventDesc = "";
    protected string _eventType = "";
    protected DateOnly _date;
    protected TimeOnly _time;
    protected Address _address;

    public Event(string eventTitle, string eventDesc, string eventType, DateOnly date, TimeOnly time, Address address)
    {
        _eventTitle = eventTitle;
        _eventDesc = eventDesc;
        _date = date;
        _time = time;
        _address = address;
        _eventType = eventType;
    }

    public void StandardDetails()
    {
        Console.WriteLine(_eventTitle);
        Console.WriteLine(_eventDesc);
        Console.WriteLine(_date);
        Console.WriteLine(_time);
        _address.DisplayFullAddress();
    }

    public abstract void FullDetails();

    public void ShortDetails()
    {
        Console.WriteLine("Short Details:");
        Console.WriteLine(_eventType);
        Console.WriteLine(_eventTitle);
        Console.WriteLine(_date);
    }

    
}