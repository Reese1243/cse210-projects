using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Guess a number 1 through 30");
        Random randomGenerator = new Random();
        int numberInt = randomGenerator.Next(1,30);
        Console.WriteLine("what is your guess?");
        string numberGuessString = Console.ReadLine();
        int numberGuessInt = int.Parse(numberGuessString);

       while (!(numberGuessInt == numberInt))
        {
            if (numberGuessInt < numberInt)
            {
                Console.WriteLine("Higher");
                numberGuessString = Console.ReadLine();
                numberGuessInt = int.Parse(numberGuessString);
            }
            else if (numberGuessInt > numberInt)
            {
                Console.WriteLine("Lower");
                numberGuessString = Console.ReadLine();
                numberGuessInt = int.Parse(numberGuessString);
            }
            
        }

        
        
        Console.WriteLine("You Guessed it!");
        
        

    }
}