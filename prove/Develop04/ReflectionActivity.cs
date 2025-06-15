using System.Runtime.CompilerServices;
using System.Security.Cryptography;

class ReflectionActivity : Activity
{
    Activity activity = new Activity("Reflection activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
    public List<string> _prompts = ["Think of a time when you stood up for someone else.",
"Think of a time when you did something really difficult.",
"Think of a time when you helped someone in need.",
"Think of a time when you did something truly selfless."];
    public List<string> _questions = ["Why was this experience meaningful to you?",
"Have you ever done anything like this before?",
"How did you get started?",
"How did you feel when it was complete?",
"What made this time different than other times when you were not as successful?",
"What is your favorite thing about this experience?",
"What could you learn from this experience that applies to other situations?",
"What did you learn about yourself through this experience?",
"How can you keep this experience in mind in the future?"];
    public ReflectionActivity(string activityName, string activityDescription) : base(activityName, activityDescription)
    {
        _activityName = activityName;
        _activityDescription = activityDescription;
    }

   

    public void ReflectionTimerCountDown()
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

        // gets random prompt from the prompts attribute
        string randomprompt = activity.GetRandomItem(_prompts);
        Console.WriteLine(randomprompt);

        while (DateTime.Now < timer)
        {
            string randomquestion = activity.GetRandomItem(_questions);
            Console.WriteLine(randomquestion);
            activity.LoadingAnimation(6);
        }

        activity.DisplayFinishingMessage();


    }

}