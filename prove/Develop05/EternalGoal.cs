public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
        _classType = "EternalGoal";
    }

    public override int RecordEvent()
    {
        return _points;
    }
    public override string GetStringRepresentation()
    {
        return $"[ ] {_shortName} ({_description})";
    }
    public override string GetOutputFormat()
    {
        return $"{_classType}:{_shortName},{_description},{_points}";
    }
}