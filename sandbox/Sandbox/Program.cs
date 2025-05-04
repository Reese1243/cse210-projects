using System;
using System.Runtime.InteropServices.Marshalling;

class Program
{
    static double AddNumbers(double a, double b)
    {
        return a + b;
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, CSE 210 Sandbox!");
        // Add your code here

        List<int> myNumbers = new List<int>();
        myNumbers.Add(10);
        myNumbers.Add(99);
        myNumbers.Add(-123);
        foreach(int i in myNumbers)
        {
            Console.WriteLine(i);
        }

        bool done = false;
        while (!done)
        {
            done = true;
        }

        do {
            Console.WriteLine("");
        } while (!done);
        
        

    }

    
}