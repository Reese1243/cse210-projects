using System.Security;

class ScriptureReference
{
    private string _reference;
    private List<string> _verse;

    private string SplitReference(String scripture)
    {
        List<string> scriptureParts = new List<string>();
        string[] parts = scripture.Split(";");
        foreach (string part in parts)
        {
            scriptureParts.Add(part);
        }

        return scriptureParts[0];

    }

    private List<string> SplitVerse(String scripture)
    {
        List<string> scriptureParts = new List<string>();

        //takes a string and seperates it into a list
        string[] parts = scripture.Split(" ");
        foreach (string part in parts)
        {
            scriptureParts.Add(part);
        }
        scriptureParts.RemoveAt(0);
        scriptureParts.RemoveAt(0);
      

        return scriptureParts;
    }

    public string GetReference(string scripture)
    {
        string reference = SplitReference(scripture);
        return reference;
    }

    public List<string> GetVerse(string scripture)
    {
        List<string> verse = new List<string>();
        verse = SplitVerse(scripture);
        return verse;
    }

    public void SetReference(string reference)
    {
        _reference = reference;
    }

    public void SetVerse(List<string> verse)
    {
        _verse = verse;
    }

    public void DisplayVerseAndReference()
    {
        Console.WriteLine(_reference);
        foreach (string part in _verse)
        {
            Console.Write(part);
        }
    }
}