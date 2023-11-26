using System.Net;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity(string name, string description)
    {
        _name = name;
        _description = description;

        _prompts = new List<string> {"Who are people that you appreciate?",
                                     "What are personal strengths of yours?",
                                     "Who are people that you have helped this week?",
                                     "When have you felt the Holy Ghost this month?",
                                     "Who are some of your personal heroes?"};
    }

    public void Run()
    {
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(3);
        Console.WriteLine();

        Console.WriteLine("List as many responses you can to the following prompt:");
        GetRandomPrompt();
        Console.Write($"You may begin in: ");
        ShowCountDown(5);
        List<string> myUserList = GetListFromUser();
        Console.WriteLine();

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < futureTime)
        {
            Console.Write("> ");
            string response = Console.ReadLine();
            myUserList.Add(response);
        }

        Console.WriteLine($"You listed {myUserList.Count} items!");
        
        Console.WriteLine("\n");
        DisplayEndingMessage();
    }
    private void GetRandomPrompt()
    {
        Random random = new Random();
        int numberIndex = random.Next(0, _prompts.Count);
        Console.WriteLine($" --- {_prompts[numberIndex]} ---");
    }
    private List<string> GetListFromUser()
    {
        List<string> userList = new List<string>();
        return userList;
    }
}