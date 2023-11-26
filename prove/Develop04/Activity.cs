using System.ComponentModel;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity()
    {
        _name = "";
        _description = "";
        _duration = -1;
    }

    public void DisplayStartingMessage()
    {
        Console.Write($"""
        Welcome to the {_name}.

        This activity will help you {_description}

        How long, in seconds, would you like for your session? 
        """);

        _duration = int.Parse(Console.ReadLine());
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!!");
        ShowSpinner(5);
        Console.WriteLine();

        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
        ShowSpinner(7);
        Console.Clear();
    }
    public void ShowSpinner(int seconds)
    {
        List<string> spinnerAnimation = new List<string>();
        spinnerAnimation.Add("|");
        spinnerAnimation.Add("/");
        spinnerAnimation.Add("-");
        spinnerAnimation.Add("\\");
        spinnerAnimation.Add("|");

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(seconds);

        int i = 0;
        while (DateTime.Now < futureTime)
        {
            Console.Write(spinnerAnimation[i]);
            Thread.Sleep(500);
            Console.Write("\b \b");
            i++;

            if (i == spinnerAnimation.Count)
            {
                i = 0;
            }
        }
    }
    public void ShowCountDown(int seconds)
    {
        for (int i = seconds;  i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}