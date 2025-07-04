using System.Numerics;

public class EternalGoal : Quest
{
    public EternalGoal() : base()
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
        int total = _goalPoints + _score;
        _score = total;
    }

    public override string SerializeForFile()
    {
        string totalStr = "EternalGoal" + "#" + _goalName + "#" + _goalDesc + "#" + _goalPoints;
        return totalStr;
    }

    public override void DeserializeFromFile(string serialString)
    {
        object[] parts = serialString.Split("#");
        parts[1] = _goalName;
        parts[2] = _goalDesc;
        parts[3] = _goalPoints;
    }
}