using System.Text.Json.Serialization;
public class ChecklistGoal : Goal
{
    [JsonPropertyOrder(5)]
    [JsonPropertyName("Amount Completed")]
    public int _amountCompleted {get; set;}

    [JsonPropertyOrder(6)]
    [JsonPropertyName("Target")]
    public int _target {get; set;}

    [JsonPropertyOrder(7)]
    [JsonPropertyName("Bonus")]
    public int _bonus {get; set;}

    public ChecklistGoal(string name, string description, int points, int target, int bonus, int amountCompleted) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = amountCompleted;
        _classType = "ChecklistGoal";
    }

    public override int RecordEvent()
    {
        _amountCompleted += 1;
        
        if (_target == _amountCompleted)
        {
            return _points + _bonus;
        }
        else
        {
            return _points;
        } 
    }
    public override string GetStringRepresentation()
    {
        if (_amountCompleted >= _target)
        {
            return $"[X] {_shortName} ({_description}) --- Currently completed: {_amountCompleted}/{_target}";
        }
        else
        {
            return $"[ ] {_shortName} ({_description}) --- Currently completed: {_amountCompleted}/{_target}";
        }
    }
    public override string GetOutputFormat()
    {
        return $"{_classType}:{_shortName},{_description},{_points},{_bonus},{_target},{_amountCompleted}";
    }
}