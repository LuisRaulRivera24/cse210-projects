public class Reception : Event
{
    private string _email;

    public Reception(string title, string description, string date, string time, List<string> address, string email) : base(title, description, date, time, address)
    {
        _email = email;

        Console.WriteLine("\nFULL DETAILS/");
        DisplayReceptionDetails(title, description, date, time, address, email);
    }

    private void DisplayReceptionDetails(string title, string description, string date, string time, List<string> address, string email)
    {
        Event e = new Event(title, description, date, time, address);

        Console.WriteLine($"""

        ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        We are delighted to have you join the reception!

        For RSVP, kindly email:
        {_email}
        ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

        """);
        Console.WriteLine("SHORT DESCRIPTION\n");
        ReceptionShortDescription(title, date);
    }
    private void ReceptionShortDescription(string title, string date)
    {
        Console.WriteLine($"""
        Reception
        "{title}"
        Date: {date}

        """);

        Console.WriteLine("##############################################################################################################################");
    }
}