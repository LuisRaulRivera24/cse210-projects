public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void Run()
    {
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(3);
        Console.WriteLine();

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        int breatheIn = 4;
        int breatheOut = 5;

        while (DateTime.Now < futureTime)
        {
            Console.Write("Breathe in...");
            ShowCountDown(breatheIn);
            Console.WriteLine();

            Console.Write("Now breathe out...");
            ShowCountDown(breatheOut);
            Console.WriteLine();
            Console.WriteLine();
        }

        DisplayEndingMessage();
    }
}