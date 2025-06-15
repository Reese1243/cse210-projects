class BreathingActivity : Activity
{
    
    Activity activity = new Activity("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
    public BreathingActivity(string activityName, string activityDescription) : base(activityName, activityDescription)
    {
        _activityName = activityName;
        _activityDescription = activityDescription;

    }

    public void BreathTimerCountdown()
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
        int breathIn = 3;
        int breathOut = 6;

        activity.LoadingAnimation(5);
        while (DateTime.Now < timer)
        {
            Console.WriteLine("Breath in...");
            while (breathIn > 0)
            {
                Console.Write(breathIn);
                Thread.Sleep(1000);
                Console.Write("\b");
                breathIn--;
            }
            breathIn = 3;

            Console.WriteLine("Breath out...");
            while (breathOut > 0)
            {
                Thread.Sleep(1000);
                Console.Write(breathOut);
                Console.Write("\b");
                breathOut--;
            }
            breathOut = 6;


        }

        Console.WriteLine();
        activity.DisplayFinishingMessage();


    }
    
    
}