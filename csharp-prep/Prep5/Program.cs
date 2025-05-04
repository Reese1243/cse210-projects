using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }

        static string PromptUserName()
        {
            Console.WriteLine("Please enter your name: ");
            string userName = Console.ReadLine();
            return userName;
        }

        static int PromptUserNumber()
        {
            Console.WriteLine("What is your favorite number?: ");
            int favNumber = int.Parse(Console.ReadLine());
            return favNumber;

        }

        static int SquareNumber(int number)
        {
            int squareNumber = number * number;
            return squareNumber;
        }

        static void DisplayResult()
        {
            DisplayWelcome();
            string userName = PromptUserName();
            int favNumber = PromptUserNumber();
            int numberSquared = SquareNumber(favNumber);
            Console.WriteLine($"{userName}, Your favorite number squared is {numberSquared}");

        }

        DisplayResult();

    }
}