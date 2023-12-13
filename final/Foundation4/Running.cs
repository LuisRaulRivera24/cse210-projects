public class Running : Activity
{
    private double _distance;

    public Running(string date, int length, double distance) : base(date, length)
    {
        _distance = distance;
        SetActivityType("Running");
    }

    protected override double CalculateDistance()
    {
        return Math.Round(_distance, 2);
    }
    protected override double CalculateSpeed()
    {
        int lngth = GetLength();
        double speed = (_distance / lngth) * 60;

        return Math.Round(speed, 2);
    }
    protected override double CalculatePace()
    {
        int lngth = GetLength();
        double speed = (_distance / lngth) * 60;
        double pace = 60 / speed;

        return Math.Round(pace, 2);
    }
}