
using System.Runtime.InteropServices;

public class Journal
{
    public List<string> _entries = new List<string>();

    public string filename = "";

    
    JournalEntry entry = new JournalEntry();
    

    public void Display()
    {
        Console.WriteLine("Current unsaved work:");
        Console.WriteLine(entry._date);
        Console.WriteLine(entry._prompt);
        Console.WriteLine(entry._response);
    }

    public string ConvertToString()
    {
        string outputString = "";

        outputString = $"{entry._date}#{entry._prompt}#{entry._response}";

        return outputString;
    }

    public void WriteToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (string i in _entries)
            {
                outputFile.WriteLine(i);
            }
        }

    }

    public void ReadFromFile(string filename)
    {
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("#");


            string date = parts[0];
            string question = parts[1];
            string entryText = parts[2];

            entry.CreateEntry();
            _entries.Add(date);
            _entries.Add(question);
            _entries.Add(entryText);

        }
        ;
    }

}