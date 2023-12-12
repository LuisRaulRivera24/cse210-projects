public class Lecture : Event
{
    private string _speakerName;
    private int _capacity;

    public Lecture(string title, string description, string date, string time, List<string> address, string speakerName, int capacity) : base(title, description, date, time, address)
    {
        _speakerName = speakerName;
        _capacity = capacity;

        Console.WriteLine("\nFULL DETAILS/");
        DisplayLectureDetails(title, description, date, time, address);
    }

    private void DisplayLectureDetails(string title, string description, string date, string time, List<string> address)
    {
        Event e = new Event(title, description, date, time, address);
        Console.WriteLine("\nCome join us at our Lecture!");
        Console.WriteLine($"""
        {_speakerName} will be speaking!
        Capacity: {_capacity}

        """);
        Console.WriteLine("SHORT DESCRIPTION\n");
        LectureShortDescription(title, date);
    }
    private void LectureShortDescription(string title, string date)
    {
        Console.WriteLine($"""
        Lecture
        "{title}"
        Date: {date}

        """);

        Console.WriteLine("##############################################################################################################################");
    }
}