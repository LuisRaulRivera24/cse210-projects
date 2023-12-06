using System.Text.Json.Serialization;
public class SimpleGoal : Goal
{
    [JsonPropertyOrder(5)]
    [JsonPropertyName("Complete")]
    public bool _isComplete {get; set;}

    public SimpleGoal(string name, string description, int points, bool completedOrNot) : base(name, description, points)
    {
        _classType = "SimpleGoal";
        _isComplete = completedOrNot;
    }

    public override int RecordEvent()
    {
        if (_isComplete == false)
        {
            _isComplete = true;
        }
        
        return _points;
    }
    public override string GetStringRepresentation()
    {
        if (_isComplete == true)
        {
            return $"[X] {_shortName} ({_description})";
        }
        else
        {
            return $"[ ] {_shortName} ({_description})";
        }
    }
    public override string GetOutputFormat()
    {
        return $"{_classType}:{_shortName},{_description},{_points},{_isComplete}";
    }
}