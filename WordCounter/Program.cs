// See https://aka.ms/new-console-template for more information
class Program
{
    public static void Main(string[] args)
    {
        WordCounter wordCounter = new WordCounter("This is a string of text");
        wordCounter.DisplayWords();

        int count = wordCounter.CountSingleWord("text");
        Console.WriteLine(count);

    }
}
