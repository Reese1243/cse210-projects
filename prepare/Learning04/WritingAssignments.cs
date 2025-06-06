class WritingAssignments : Assignment
{
    private string _title = "";

    public WritingAssignments(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;
    }

    public void GetWritingInfo()
    {
        Console.WriteLine($"{_title} by {_studentName}");
    }
}