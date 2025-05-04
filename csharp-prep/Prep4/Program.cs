using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices.Marshalling;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Add a number: ");
        int numberInput = int.Parse(Console.ReadLine());
        numbers.Add(numberInput); 
        int listSize = numbers.Count();
        int sum = numberInput;
        int highestNumber = 0;
        
        
        while (numberInput != 0)
        {
            Console.WriteLine("Add a number: ");
            numberInput = int.Parse(Console.ReadLine());
            numbers.Add(numberInput);
            sum += numberInput;
            listSize ++;

        }

        foreach (int number in numbers)
        {
            
            if (highestNumber < number)
            {
                highestNumber = number;
            }
        }

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {((float)sum) / listSize}");
        Console.WriteLine($"The largest number is {highestNumber}");

    }
}