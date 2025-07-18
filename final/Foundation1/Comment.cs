public class Comment
{
    string _name = "";
    string _text = "";

    public Comment(string name, string text)
    {
        _name = name;
        _text = text;
    }

    public void DisplayComment()
    {
        Console.WriteLine();
        Console.WriteLine(_name);
        Console.WriteLine(_text);
        Console.WriteLine();
    }
}