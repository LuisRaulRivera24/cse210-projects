public class Cycling : Activity
{
    private double _speed;

    public Cycling(string date, int length, double speed) : base(date, length)
    {
        _speed = speed;
        SetActivityType("Cycling");
    }

    protected override double CalculateDistance()
    {
        int lngth = GetLength();
        double distance = _speed * (lngth / 60);

        return Math.Round(distance, 2);
    }
    protected override double CalculateSpeed()
    {
        return Math.Round(_speed, 2);
    }
    protected override double CalculatePace()
    {
        double pace = 60 / _speed;

        return Math.Round(pace, 2);
    }
}