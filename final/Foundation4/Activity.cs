using System.ComponentModel.DataAnnotations;

public class Activity
{
    private string _date;
    private int _length;
    private string _activityType;

    protected Activity(string date, int length)
    {
        _date = date;
        _length = length;
    }
    protected void SetActivityType(string activityType)
    {
        _activityType = activityType;
    }
    protected int GetLength()
    {
        return _length;
    }
    protected virtual double CalculateDistance()
    {
        return 0;
    }
    protected virtual double CalculateSpeed()
    {
        return 0;
    }
    protected virtual double CalculatePace()
    {
        return 0;
    }
    public void GetSummary()
    {
        Console.WriteLine($"{_date} {_activityType} ({_length} min)- Distance {CalculateDistance()} miles, Speed {CalculateSpeed()} mph, Pace: {CalculatePace()} min per mile\n");
    }
}