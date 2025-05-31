class ScriptureCensor
{

    public string _reference;
    public List<string> _verse;


    Word word = new Word();
    ScriptureReference scriptureReference = new ScriptureReference();

    public ScriptureCensor(string scripture)
    {
        scriptureReference.SetReference(scripture);
        scriptureReference.SetVerse(scripture);
        _reference = scriptureReference.GetReference();
        _verse = scriptureReference.GetVerse();
    }



    public List<string> CensorRandomStringInList(List<string> verse)
    {
        string randomWord = word.GetRandomWord(verse);
        string censoredWord = word.CensorWord(randomWord);
        int wordIndex = verse.IndexOf(randomWord);
        verse[wordIndex] = censoredWord;
        return verse;
    }


    public string GetReference()
    {
        return _reference;
    }

    public List<string> GetVerse()
    {
        return _verse;
    }

    public void SetReference(string reference)
    {
        _reference = reference;
    }

    public void SetVerse(List<string> verse)
    {
        _verse = verse;
    }

    public void DisplayReference()
    {
        Console.Write(_reference);
    }

    public void DisplayVerse()
    {
        foreach (string i in _verse)
        {
            Console.Write(i);
        }
    }


}