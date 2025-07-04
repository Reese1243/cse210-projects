using System.IO;
using System.IO.Enumeration;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {


        SimpleGoal simpleGoal = new SimpleGoal();
        EternalGoal eternalGoal = new EternalGoal();
        ChecklistGoal checklistGoal = new ChecklistGoal();


        int select = 0;

        List<string> goalStrings = new List<string>();
        List<string> serialGoals = new List<string>();

        void PrintMenu()
        {
        Console.WriteLine("Menu");
        Console.WriteLine("1. Create new goal");
        Console.WriteLine("2. List goals");
        Console.WriteLine("3. Save goals");
        Console.WriteLine("4. Load goals");
        Console.WriteLine("5. Record event");
        Console.WriteLine("6. Quit");
        }


        PrintMenu();

        while (select != 6)
        {
            int userInput = int.Parse(Console.ReadLine());
            switch (userInput)
            {
                case 1:
                    Console.WriteLine("What type of goal would you like to create?");
                    Console.WriteLine("1. Simple goal");
                    Console.WriteLine("2. Eternal goal");
                    Console.WriteLine("3. Checklist goal");
                    int input2 = int.Parse(Console.ReadLine());
                    switch (input2)
                    {
                        case 1:
                            simpleGoal.CreateGoal();
                            string simpleGoalString = simpleGoal.ConcatToString();
                            goalStrings.Add(simpleGoalString);
                            string simpleGoalSerial = simpleGoal.SerializeForFile();
                            serialGoals.Add(simpleGoalSerial);
                            PrintMenu();
                            break;
                        case 2:
                            eternalGoal.CreateGoal();
                            string eternalGoalString = eternalGoal.ConcatToString();
                            goalStrings.Add(eternalGoalString);
                            string eternalGoalSerial = eternalGoal.SerializeForFile();
                            serialGoals.Add(eternalGoalSerial);
                            PrintMenu();
                            break;
                        case 3:
                            checklistGoal.CreateGoal();
                            string checklistGoalString = checklistGoal.ConcatToString();
                            goalStrings.Add(checklistGoalString);
                            string checklistGoalSerial = checklistGoal.SerializeForFile();
                            serialGoals.Add(checklistGoalSerial);
                            PrintMenu();
                            break;
                    }
                    break;

                case 2:
                    foreach (string goal in goalStrings)
                    {
                        Console.WriteLine(goal);
                    }
                    break;

                case 3:
                    Console.WriteLine("Provide desired filename");
                    string userfilename = Console.ReadLine();
                    using (StreamWriter outputFile = new StreamWriter(userfilename))
                    {
                        foreach (string goal in serialGoals)
                        {
                            outputFile.WriteLine(goal + ",");
                        }
                    }
                    break;

                case 4:
                    Console.WriteLine("Provide a file to load");
                    userfilename = Console.ReadLine();
                    string[] lines = System.IO.File.ReadAllLines(userfilename);
                    foreach (string line in lines)
                    {
                        string[] parts = line.Split(",");
                        foreach (string part in parts)
                        {
                            serialGoals.Add(part);
                        }
                    }
                    foreach (string item in serialGoals)
                    {
                        if (item.Contains("SimpleGoal"))
                        {
                            simpleGoal.DeserializeFromFile(item);
                            string simpleGoalString = simpleGoal.ConcatToString();
                            goalStrings.Add(simpleGoalString);
                            bool completed = simpleGoal.IsCompleted();
                            if (completed == true)
                            {
                                simpleGoal.CheckBox();
                            }
                        }
                        else if (item.Contains("EternalGoal"))
                        {
                            eternalGoal.DeserializeFromFile(item);
                            string eternalGoalString = eternalGoal.ConcatToString();
                            goalStrings.Add(eternalGoalString);
                        }
                        else if (item.Contains("ChecklistGoal"))
                        {
                            checklistGoal.DeserializeFromFile(item);
                            string checklistGoalString = checklistGoal.ConcatToString();
                            goalStrings.Add(checklistGoalString);
                            bool completed = checklistGoal.IsCompleted();
                            if (completed == true)
                            {
                                checklistGoal.CheckBox();
                            }
                        }
                    }
                    break;

                case 5:
                    int index = 0;
                    Console.WriteLine("which goal did you complete?");
                    foreach (string item in goalStrings)
                    {
                        Console.WriteLine($"{index}. {item}");
                        index++;
                    }
                    int userindex = int.Parse(Console.ReadLine());
                    string selectedGoal = serialGoals[userindex];

                    if (selectedGoal.Contains("SimpleGoal"))
                    {
                        simpleGoal.DeserializeFromFile(selectedGoal);
                        simpleGoal.CompletionReport();
                    }
                    else if (selectedGoal.Contains("EternalGoal"))
                    {
                        eternalGoal.DeserializeFromFile(selectedGoal);
                        eternalGoal.CompletionReport();
                    }
                    else if (selectedGoal.Contains("ChecklistGoal"))
                    {
                        checklistGoal.DeserializeFromFile(selectedGoal);
                        checklistGoal.CompletionReport();
                    }
                    break;

                case 6:
                    break;









            }
        }


     }
}