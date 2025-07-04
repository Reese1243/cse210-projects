public abstract class Quest
{
    protected int _score;
    protected bool _completed;
    protected string _goalName;
    protected string _goalDesc;
    protected int _goalPoints;
    protected string _checkBox;

    protected Quest()
    {
        _completed = false;
        _score = 0;
        _checkBox = "[ ]";
    }

    public abstract void CreateGoal();

    public abstract void CompletionReport();

    public void SetGoalName(string goalName)
    {
        _goalName = goalName;
    }

    public void SetGoalDesc(string goalDesc)
    {
        _goalDesc = goalDesc;
    }

    public void SetGoalPoints(int points)
    {
        _goalPoints = points;
    }

    public void CheckBox()
    {
        if (_completed == true)
        {
            _checkBox = "[x]";
        }
    }

    public virtual string ConcatToString()
    {
        string totalStr = _checkBox + " " + _goalName + ": " + _goalDesc;
        return totalStr;
    }

    public virtual string SerializeForFile()
    {
        string totalStr = "SimpleGoal" + "#" + _goalName + "#" + _goalDesc + "#" + _goalPoints + "#" + _completed;
        return totalStr;
    }

    public virtual void DeserializeFromFile(string serialString)
    {

        object[] parts = serialString.Split("#");
        parts[1] = _goalName;
        parts[2] = _goalDesc;
        parts[3] = _goalPoints;
        parts[4] = _completed;
    }

    public int GetPoints()
    {
        return _score;
    }

    public bool IsCompleted()
    {
        return _completed;
    }
    
}