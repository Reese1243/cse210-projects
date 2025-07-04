public class SimpleGoal : Quest
{
    public SimpleGoal() : base()
    {

    }

    public override void CreateGoal()
    {
        Console.WriteLine("What is the name of your goal?");
        _goalName = Console.ReadLine();
        Console.WriteLine("Give a short description of your goal.");
        _goalDesc = Console.ReadLine();
        Console.WriteLine("how many points are associated with your goal?");
        _goalPoints = int.Parse(Console.ReadLine());

    }

    public override void CompletionReport()
    {
        _completed = true;
        int total = _goalPoints + _score;
        _score = total;
        CheckBox();
    }
    
}