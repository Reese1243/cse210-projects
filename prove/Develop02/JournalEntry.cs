using System.Security.Cryptography;

public class JournalEntry
{
    public string _prompt = "";
    public string _response = "";
    public string _date = DateTime.Today.ToString();

    public void CreateEntry()
    {
        List<string> Prompts = new List<string>();
        Prompts = ["Who was the most interesting person I interacted with today?", "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?", "What was the strongest emotion I felt today?", "If I had one thing I could do over today, what would it be?",
        "What did I accomplish today?", "How did I make myself more productive today?"];

        Random randomIndex = new Random();
        int randomPrompt = randomIndex.Next(Prompts.Count);
        _prompt = Prompts[randomPrompt];
        Console.WriteLine($"{_prompt}");
        _response = Console.ReadLine();

    }

    
}
