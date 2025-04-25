using System;


class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter your grade percentage: ");
        string gradePercentageInput = Console.ReadLine();
        
        int x = int.Parse(gradePercentageInput);
        int gradeA = 90;
        int gradeB = 80;
        int gradeC = 70;
        int gradeD = 60;
        string letterGrade = "";
        
        if (x >= gradeA)
        {
            letterGrade = "A";
        }
        else if (x >= gradeB)
        {
            letterGrade = "B";
        }
        else if (x >= gradeC)
        {
            letterGrade = "C";
        }
        else if (x >= gradeD)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }

        
        if (letterGrade == "B" || letterGrade == "C" || letterGrade == "D")
        {
            Console.WriteLine($"You have recieved a {letterGrade} for this class.");
        }
        else
        {
            Console.WriteLine($"You have recieved an {letterGrade} for this class.");
        }
        if (x < gradeC)
        {
            Console.WriteLine("you did not pass the class with a 70 or higher. Better luck next time!");
        }
    }
}