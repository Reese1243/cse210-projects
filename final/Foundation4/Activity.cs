abstract class Activity
{
    protected DateOnly _date;
    protected int _minutes = 0;

    public Activity(DateOnly date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    protected virtual double GetDistance(double numOfLaps)
    {
        double distance = numOfLaps * 50 / 1000 * 0.62;
        return distance;
    }

    protected virtual double GetSpeed(double distance)
    {
        double speed = distance / _minutes * 60;
        return speed;
    }

    protected virtual double GetPace(double distance)
    {
        double pace = _minutes / distance;
        return pace;
    }

    public abstract void GetSummary();
    
        
    

}