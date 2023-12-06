using System.Text.Json.Serialization;

[JsonDerivedType(typeof(Goal))]
[JsonDerivedType(typeof(SimpleGoal))]
[JsonDerivedType(typeof(EternalGoal))]
[JsonDerivedType(typeof(ChecklistGoal))]
public class Goal
{
    [JsonPropertyOrder(1)]
    [JsonPropertyName("Class")]
    public string _classType {get; set;}

    [JsonPropertyOrder(2)]
    [JsonPropertyName("Goal Name")]
    public string _shortName {get; set;}
    [JsonPropertyOrder(3)]
    [JsonPropertyName("Description")]
    public string _description {get; set;}
    [JsonPropertyOrder(4)]
    [JsonPropertyName("Points")]
    public int _points {get; set;}

    protected Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }
    public virtual int RecordEvent()
    {
        return -1;
    }

    public virtual string GetStringRepresentation()
    {
        return "";
    }
    public virtual string GetOutputFormat()
    {
        return "";
    }
}