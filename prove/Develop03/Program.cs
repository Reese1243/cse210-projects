using System;

class Program
{
    static void Main(string[] args)
    {
        // List<string> test = new List<string>();
        // test = ["this", "is", "a", "list"];
        //Word exampleinstant = new Word();
        // string randomWord = exampleinstant.GetRandomWord(test);
        //Console.WriteLine(randomWord);
        //Console.WriteLine(exampleinstant.CensorWord(randomWord));
        string fullScripture = "Proverbs 3:5-6; Trust in the Lord with all thine heart and lean not unto thine own understanding; in all thy ways acknowledge him, and he shall direct thy paths.";
        ScriptureReference scripturetest = new ScriptureReference();
        List<string> verseList = new List<string>();
        verseList = scripturetest.GetVerse(fullScripture);
        foreach(string item in verseList)
        {
            Console.Write(item + " ");
        }
        //Console.WriteLine(scripturetest.GetReference(fullScripture));




        /// Proverbs 3:5-6 Trust in the Lord with all thine heart and lean not unto thine own understanding; in all thy ways acknowledge him, and he shall direct thy paths.


    }
}