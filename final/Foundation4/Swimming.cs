public class Swimming : Activity
{
    private int _laps;

    public Swimming(string date, int length, int laps) : base(date, length)
    {
        _laps = laps;
        SetActivityType("Swimming");
    }

    protected override double CalculateDistance()
    {
        double distance = _laps * 50 / 1000 * 0.62;

        return Math.Round(distance, 2);
    }
    protected override double CalculateSpeed()
    {
        double distance = _laps * 50 / 1000 * 0.62;
        int lngth = GetLength();
        double speed = (distance / lngth) * 60;

        return Math.Round(speed, 2);
    }
    protected override double CalculatePace()
    {
        double distance = _laps * 50 / 1000 * 0.62;
        int lngth = GetLength();
        double speed = (distance / lngth) * 60;
        double pace = 60 / speed;

        return Math.Round(pace, 2);
    }
}