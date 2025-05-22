using System;
using System.IO.Enumeration;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Type 5 to quit \n 1: Create entry \n 2: Display entry \n 3: Save entry \n 4: Load entry");

        int select = 0;

        JournalEntry newEntry = new JournalEntry();
        Journal journal = new Journal();

        string unsavedEntry = "";

        while (select != 5)
        {

            string useInput = Console.ReadLine();
            select = int.Parse(useInput);

            switch (select)
            {
                case 1:
                    newEntry.CreateEntry();
                    unsavedEntry = journal.ConvertToString();
                    break;

                case 2:
                    journal.Display();
                    break;

                case 3:
                    Console.WriteLine("Please enter a file name:");
                    journal.filename = Console.ReadLine();
                    journal.WriteToFile(journal.filename);
                    break;

                case 4:
                    Console.WriteLine("please enter a filename to read:");
                    journal.ReadFromFile(journal.filename);
                    break;
            }
        

        }
    }
}