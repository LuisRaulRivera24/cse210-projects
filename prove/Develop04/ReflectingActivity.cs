public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity(string name, string description)
    {
        _name = name;
        _description = description;

        _prompts = new List<string>{"Think of a time when you stood up for someone else.",
                                    "Think of a time when you did something really difficult.",
                                    "Think of a time when you helped someone in need.",
                                    "Think of a time when you did something truly selfless."};

        _questions = new List<string>{"Why was this experience meaningful to you?",
                                      "Have you ever done anything like this before?",
                                      "How did you get started?",
                                      "How did you feel when it was complete?",
                                      "What made this time different than other times when you were not as successful?",
                                      "What is your favorite thing about this experience?",
                                      "What could you learn from this experience that applies to other situations?",
                                      "What did you learn about yourself through this experience?",
                                      "How can you keep this experience in mind in the future?"};
    }

    public void Run()
    {
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(3);
        Console.WriteLine();

        Console.WriteLine("Consider the following prompt:\n");
        DisplayPrompt();

        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they are related to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(5);

        Console.Clear();
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < futureTime)
        {
            DisplayQuestions();
            ShowSpinner(7);
            Console.WriteLine();
        }

        Console.WriteLine("\n");
        DisplayEndingMessage();

    }
    private string GetRandomPrompt()
    {
        Random random = new Random();
        int numberIndex = random.Next(0, _prompts.Count);

        return _prompts[numberIndex];
    }
    private string GetRandomQuestion()
    {
        Random random = new Random();
        int numberIndex = random.Next(0, _questions.Count);
        
        return _questions[numberIndex];
    }
    private void DisplayPrompt()
    {
        Console.WriteLine($" --- {GetRandomPrompt()} ---\n");
    }
    private void DisplayQuestions()
    {
        Console.Write($"> {GetRandomQuestion()}");
    }
}