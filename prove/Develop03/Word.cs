using System.Security.Cryptography;

class Word
{
    string _word;

    //gets a random word from a list of strings
    public string GetRandomWord(List<string> wordList)
    {
        Random randomGen = new Random();
        int wordIndex = randomGen.Next(0, wordList.Count());
        return wordList[wordIndex];
    }


    // censors a random word with underscores
    public string CensorWord(string word)
    {
        string censorWord = "";
        int wordLength = word.Length;

        for (int i = 0; i < wordLength; i++)
        {
            censorWord = censorWord + "_";
        }

        return censorWord;
    }

    // sets the _word attribute to the string argument
    public void SetWord(string word)
    {
        _word = word;
    }

    // displays the _word attribute
    public void DisplayWord()
    {
        Console.WriteLine(_word);
    }

}