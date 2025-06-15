class ListActivity : Activity
{
public List<string> _listPrompts = ["Who are people that you appreciate?",
"What are personal strengths of yours?",
"Who are people that you have helped this week?",
"When have you felt the Holy Ghost this month?",
"Who are some of your personal heroes?"];
    Activity activity = new Activity("Listing activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
    public ListActivity(string activityName, string activityDescription) : base(activityName, activityDescription)
    {
        _activityName = activityName;
        _activityDescription = activityDescription;
    }

    public void ListActivityCountDown()
    {
        activity.DisplayActivityName();
        Console.WriteLine();
        activity.DisplayDescription();
        Console.WriteLine();
        Console.WriteLine("how long in seconds do you wish to do this activity?");
        string usrInput = Console.ReadLine();
        int endTime = int.Parse(usrInput);
        activity.SetDuration(endTime);
        DateTime timer = activity.CountDownTimer();

        string randomPrompt = activity.GetRandomItem(_listPrompts);
        Console.WriteLine(randomPrompt);

        int countDown = 5;
        while (countDown > 0)
        {
            Console.Write(countDown);
            Thread.Sleep(1000);
            Console.Write("\b");
            countDown--;
        }
        Console.WriteLine("write your thoughts below: ");
        int numOfResponses = 0;
        while (DateTime.Now < timer)
        {
            Console.ReadLine();
            numOfResponses++;
        }

        Console.WriteLine($"you gave {numOfResponses} Responses!");
        activity.DisplayFinishingMessage();

    }   


}