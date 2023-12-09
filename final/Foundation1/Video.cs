public class Video
{
    private string _title;
    private string _author;
    private double _length;
    private List<Comment> _commentsList;

    public Video(string title, string author, double length, List<string> List)
    {
        _commentsList = new List<Comment>();

        _title = title;
        _author = author;
        _length = length;

        foreach(string c in List)
        {
            Comment comment = new Comment(c);
            _commentsList.Add(comment);
        }
    }

    private int TotalComments()
    {
        int total = _commentsList.Count;

        return total;
    }
    public void Display()
    {
        Console.WriteLine($"Title: {_title}, Author: {_author}, Length(seconds): {_length}\n");
        Console.WriteLine($"Total number of comments: {TotalComments()}");

        foreach (Comment comment in _commentsList)
        {
            Console.WriteLine(comment.GetComment());
        }
        
        Console.WriteLine();
        Console.WriteLine("#######################################################################################\n");
    }
}