public class Comment
{
    private string _name;
    private string _comment;

    public Comment(string commentWithName)
    {
        string[] line = commentWithName.Split(":");
        string name = line[0];
        string comment = line[1];

        _name = name;
        _comment = comment;
    }

    public string GetComment()
    {
        return $"{_name}: {_comment}";
    }
}