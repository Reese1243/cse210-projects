using System;
using System.Data;

class Program
{
    static void Main(string[] args)
    {
        string fullScripture = "Proverbs 3:5-6 Trust in the Lord with all thine heart and lean not unto thine own understanding; in all thy ways acknowledge him, and he shall direct thy paths.";

        ScriptureCensor scriptureCensor = new ScriptureCensor(fullScripture);

        int isHidden = 0;
        string logout = "";
        int verseIndex = scriptureCensor._verse.Count();
        List<string> newVerse = new List<string>();
        while (isHidden <= verseIndex)
        {
            scriptureCensor.DisplayReference();
            scriptureCensor.DisplayVerse();
            List<string> verse = scriptureCensor.GetVerse();
            Console.WriteLine("press enter to hide words or type quit to exit: ");
            logout = Console.ReadLine();

            if (logout == "quit")
            {
                break;
            }


            newVerse = scriptureCensor.CensorRandomStringInList(verse);
            scriptureCensor.SetVerse(newVerse);

            foreach (string i in newVerse)
            {
                if (i.Contains("_"))
                {
                    isHidden++;
                }
            }

            if (isHidden < verseIndex)
            {
                isHidden = 0;
            }

            Console.Clear();
        }

        scriptureCensor.DisplayReference();
        scriptureCensor.DisplayVerse();


        


    }
}