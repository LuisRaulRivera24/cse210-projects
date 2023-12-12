public class OutdoorGathering : Event
{
    private string _weatherStatement;

    public OutdoorGathering(string title, string description, string date, string time, List<string> address, string weatherStatement) : base(title, description, date, time, address)
    {
        _weatherStatement = weatherStatement;

        Console.WriteLine("\nFULL DETAILS/");
        DisplayOutdoorDetails(title, description, date, time, address);
    }

    private void DisplayOutdoorDetails(string title, string description, string date, string time, List<string> address)
    {
        Event e = new Event(title, description, date, time, address);
        Console.WriteLine($"""

        Come and enjoy the outdoors!
        The weather will be {_weatherStatement}.

        """);
        Console.WriteLine("SHORT DESCRIPTION\n");
        OutdoorShortDescription(title, date);
    }
    private void OutdoorShortDescription(string title, string date)
    {
        Console.WriteLine($"""
        Outdoor Gathering
        "{title}"
        Date: {date}

        """);

        Console.WriteLine("##############################################################################################################################");
    }
}