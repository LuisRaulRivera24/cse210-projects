using System.Net;

public class ListingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _usedPrompts;

    public ListingActivity(string name, string description)
    {
        _name = name;
        _description = description;

        _usedPrompts = new List<string>();

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
        
        Console.WriteLine();
        DisplayEndingMessage();
    }
    private void GetRandomPrompt()
    {
        Random random = new Random();
        int numberIndex = random.Next(0, _prompts.Count);
        string randomPrompt = _prompts[numberIndex];
        _usedPrompts.Add(randomPrompt);

        Console.WriteLine($" --- {randomPrompt} ---");

        _prompts.Remove(randomPrompt);

        if (!_prompts.Any())
        {
            foreach (string prompt in _usedPrompts)
            {
                _prompts.Add(prompt);
            }
        }
    }
    private List<string> GetListFromUser()
    {
        List<string> userList = new List<string>();
        return userList;
    }
}