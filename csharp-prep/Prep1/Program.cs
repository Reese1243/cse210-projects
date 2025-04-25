using System;

class Program
{
    static void Main(string[] args)
    { 
        Console.WriteLine("Please enter your first name:");
        string firstName = Console.ReadLine();
        Console.WriteLine($"Your first name is {firstName}");
        Console.WriteLine("Please enter your last name:");
        string lastName = Console.ReadLine();
        Console.WriteLine($"Your last name is {lastName}");
        Console.WriteLine($"your name is {lastName}, {firstName} {lastName}");
    }
}