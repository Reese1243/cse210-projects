using System.Security;

class ScriptureReference
{
    private string _reference;
    private List<string> _verse;

    private string SplitReference(String scripture)
    {
        List<string> scriptureParts = new List<string>();
        string[] parts = scripture.Split(" ");
        foreach (string part in parts)
        {
            scriptureParts.Add(part);
        }
        string reference = scriptureParts[0] + " " + scriptureParts[1];
        return reference;

    }

    private List<string> SplitVerse(String scripture)
    {
        List<string> scriptureParts = new List<string>();

        //takes a string and seperates it into a list
        string[] parts = scripture.Split(" ");
        foreach (string part in parts)
        {
            scriptureParts.Add(part + " ");
        }
        scriptureParts.RemoveAt(0);
        scriptureParts.RemoveAt(0);
      

        return scriptureParts;
    }

    public string ListToString(List<string> list)
    {
        string newString = "";
        foreach (string item in list)
        {
            newString = item + " ";
        }
        return newString;
    }

    public void SetReference(string scripture)
    {
        string reference = SplitReference(scripture);
        _reference = reference;
    }

    public void SetVerse(string scripture)
    {
        List<string> verse = new List<string>();
        verse = SplitVerse(scripture);
        _verse = verse;
    }

    public string GetReference()
    {
        return _reference;
    }

    public List<string> GetVerse()
    {
        return _verse;
    }

    public void DisplayVerseAndReference()
    {
        Console.Write(_reference);
        foreach (string part in _verse)
        {
            Console.Write(part);
        }
    }
}