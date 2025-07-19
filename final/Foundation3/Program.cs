using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        // lecture object 
        DateOnly date1 = new DateOnly(2025, 9, 17);
        TimeOnly time1 = new TimeOnly(16, 45);
        Address address1 = new Address("4723 beach lane", "Chareston", "South Carolina", "USA");
        EventLecture lecture = new EventLecture("The problem with destroying nuclear power",
        "There is a major problem today with the villifying of nuclear energy. listen to John Jones as he explains the perils of abandoning energy options.",
        "Lecture", date1, time1, address1, "John Jones", 60);

        lecture.StandardDetails();
        Console.WriteLine();
        lecture.FullDetails();
        Console.WriteLine();
        lecture.ShortDetails();
        Console.WriteLine();
        // ---------------------------------

        // reception object
        DateOnly date2 = new DateOnly(2026, 1, 9);
        TimeOnly time2 = new TimeOnly(6);
        Address address2 = new Address("9134 blue mountain road", "boise", "Idaho", "USA");
        List<string> attendees = new List<string>();
        attendees.Add("Jordan Mitchell");
        attendees.Add("Alicia Chen");
        attendees.Add("Marcus Bennett");
        attendees.Add("Priya Desai");
        attendees.Add("Liam O'Connor");
        EventReception reception = new EventReception("Connect & Collaborate",
        "Join us for an evening of meaningful connections at Connect & Collaborate — a premier business networking reception designed to bring together professionals, entrepreneurs, and industry leaders.",
        "Reception", "connect&colab12@gmail.com", date2, time2, address2, 20, attendees);

        reception.StandardDetails();
        Console.WriteLine();
        reception.FullDetails();
        Console.WriteLine();
        reception.ShortDetails();
        Console.WriteLine();
        // -------------------------------

        //Outdoor gathering object
        DateOnly date3 = new DateOnly(2025, 7, 26);
        TimeOnly time3 = new TimeOnly(6);
        Address address3 = new Address("3841 tall grass drive", "spring water colony", "montana", "USA");
        EventGathering gathering = new EventGathering("Bday BBQ at Dave's!",
        "You are invited to Dave's birthday barbeque!",
        "Outdoor Gathering",
        date3, time3, address3, "cloudy");

        gathering.StandardDetails();
        Console.WriteLine();
        gathering.FullDetails();
        Console.WriteLine();
        gathering.ShortDetails();
        Console.WriteLine();

        
    }
}