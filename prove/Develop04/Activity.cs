class Activity
{
    protected string _activityName = "";
    protected string _activityDescription = "";
    protected int _endTime = 0;
    protected string _finishingMessage = "you completed the activity! well done.";

    public Activity(string activityName, string activityDescription)
    {
        _activityName = activityName;
        _activityDescription = activityDescription;
    }

    public void SetDuration(int duration)
    {
        _endTime = duration;
    }
    public void GetDuration()
    {
        Console.WriteLine(_endTime);
    }
    public DateTime CountDownTimer()
    {
        DateTime currentTime = DateTime.Now;
        DateTime duration = currentTime.AddSeconds(_endTime);
        return duration;
    }

    public void LoadingAnimation(int seconds)
    {
        DateTime currentTime = DateTime.Now;
        DateTime duration = currentTime.AddSeconds(seconds);
        int sleepTime = 1000;
        while (DateTime.Now < duration)
        {
            Thread.Sleep(sleepTime);
            Console.Write(".");
            Console.Write("\b");
            Thread.Sleep(sleepTime);
            Console.Write("o");
            Console.Write("\b");
            Thread.Sleep(sleepTime);
            Console.Write("O");
            Console.Write("\b");
            Thread.Sleep(sleepTime);
            Console.Write("0");
            Console.Write("\b");
        }
    }

    public void DisplayDescription()
    {
        Console.WriteLine(_activityDescription);
    }
    public void DisplayFinishingMessage()
    {
        Console.WriteLine(_finishingMessage);
    }

    public void DisplayActivityName()
    {
        Console.WriteLine(_activityName);
    }

     public string GetRandomItem(List<string> items)
    {
        Random numberGen = new Random();
        int wordIndex = numberGen.Next(0, items.Count);
        string item = items[wordIndex];
        return item;
    }
   
}