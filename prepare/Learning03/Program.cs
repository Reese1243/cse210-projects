using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction example_1 = new Fraction();
        Fraction example_2 = new Fraction(5);
        Fraction example_3 = new Fraction(3, 4);
        Fraction example_4 = new Fraction(1, 3);

        Console.WriteLine(example_1.GetFractionString());
        Console.WriteLine(example_1.GetDecimalValue());
        Console.WriteLine(example_2.GetDecimalValue());
        Console.WriteLine(example_2.GetFractionString());
        Console.WriteLine(example_3.GetFractionString());
        Console.WriteLine(example_3.GetDecimalValue());
        Console.WriteLine(example_4.GetFractionString());
        Console.WriteLine(example_4.GetDecimalValue());

    }
}