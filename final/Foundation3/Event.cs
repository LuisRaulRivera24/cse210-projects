public class Event
{
    private string _title;
    private string _description;
    private string _date;
    private string _time;

    public Event(string title, string description, string date, string time, List<string> address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;

        DisplayStandardDetails(address);
    }

    private void DisplayStandardDetails(List<string> address)
    {
        Console.WriteLine("STANDARD DETAILS\n");
        Console.WriteLine($"""
        Title: {_title}
        Description: {_description}
        Date: {_date}
        Time: {_time}
        """);
        Address addr = new Address(address);
        Console.WriteLine(addr.DisplayAddress());
    }
}