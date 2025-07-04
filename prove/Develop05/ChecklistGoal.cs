public class ChecklistGoal : Quest
{

    int _currentNumOfCompletions;
    int _maxNumOfCompletions;
    int _bonusPoints;
    public ChecklistGoal() : base()
    {
        _currentNumOfCompletions = 0;
    }

    public override void CreateGoal()
    {
        Console.WriteLine("What is the name of your goal?");
        _goalName = Console.ReadLine();
        Console.WriteLine("Give a short description of your goal.");
        _goalDesc = Console.ReadLine();
        Console.WriteLine("how many points are associated with your goal?");
        _goalPoints = int.Parse(Console.ReadLine());
        Console.WriteLine("What is the maximum number of times this goal can be done?");
        _maxNumOfCompletions = int.Parse(Console.ReadLine());
        Console.WriteLine("How many bonus points will be for every time the activity is completed past the goal?");
        _bonusPoints = int.Parse(Console.ReadLine());


    }

    public override void CompletionReport()
    {
        int total = _goalPoints + _score;
        _score = total;
        _currentNumOfCompletions++;
        if (_currentNumOfCompletions == _maxNumOfCompletions)
        {
            _completed = true;
            CheckBox();
        }
        else if (_currentNumOfCompletions > _maxNumOfCompletions)
        {
            total = _bonusPoints + _score;
            _score = total;
        }

    }

    public override string ConcatToString()
    {
        string totalStr = _checkBox + " " + _goalName + ": " + _goalDesc + " -- " + _currentNumOfCompletions + "/" + _maxNumOfCompletions;
        return totalStr;
    }
    public override string SerializeForFile()
    {
        string totalStr = "ChecklistGoal" + "#" + _goalName + "#" + _goalDesc + "#" + _goalPoints + "#" + _completed + "#" + _bonusPoints + "#" + _currentNumOfCompletions + "#" + _maxNumOfCompletions;
        return totalStr;
    }

    public override void DeserializeFromFile(string serialString)
    {
        object[] parts = serialString.Split("#");
        parts[1] = _goalName;
        parts[2] = _goalDesc;
        parts[3] = _goalPoints;
        parts[4] = _completed;
        parts[5] = _bonusPoints;
        parts[6] = _currentNumOfCompletions;
        parts[7] = _maxNumOfCompletions;
    }

}