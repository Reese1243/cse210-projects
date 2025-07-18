class Video
{
    string _author = "";
    string _title = "";
    int _length = 0;
    List<Comment> _comments = new List<Comment>();

    public Video(string author, string title, int length)
    {
        _author = author;
        _title = title;
        _length = length;
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public void DisplayVideoInfo()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Video Length: {_length}");
        Console.WriteLine($"Number of comments: {_comments.Count()}");
        foreach (Comment comment in _comments)
        {
            comment.DisplayComment();
        }

    }
}