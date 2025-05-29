using System;

class Program
{
    static void Main(string[] args)
    {
        List<string> test = new List<string>();
        test = ["this", "is", "a", "list"];
        Word exampleinstant = new Word();
        string randomWord = exampleinstant.GetRandomWord(test);
        Console.WriteLine(randomWord);
        Console.WriteLine(exampleinstant.CensorWord(randomWord));

    }
}