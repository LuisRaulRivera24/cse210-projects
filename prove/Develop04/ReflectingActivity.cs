public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    private List<string> _usedPrompts;
    private List<string> _usedQuestions;

    public ReflectingActivity(string name, string description)
    {
        _name = name;
        _description = description;

        _usedPrompts = new List<string>();
        _usedQuestions = new List<string>();


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

        Console.WriteLine();
        DisplayEndingMessage();

    }
    private string GetRandomPrompt()
    {
        Random random = new Random();
        int numberIndex = random.Next(0, _prompts.Count);
        _usedPrompts.Add(_prompts[numberIndex]);

        return _prompts[numberIndex];
    }
    private string GetRandomQuestion()
    {
        Random random = new Random();
        int numberIndex = random.Next(0, _questions.Count);
        _usedQuestions.Add(_questions[numberIndex]);
        
        return _questions[numberIndex];
    }
    private void DisplayPrompt()
    {
        string randomPrompt = GetRandomPrompt();
        Console.WriteLine($" --- {randomPrompt} ---\n");

        _prompts.Remove(randomPrompt);

        if (!_prompts.Any())
        {
            foreach (string prompt in _usedPrompts)
            {
                _prompts.Add(prompt);
            }
        }
    }
    private void DisplayQuestions()
    {
        string randomQuestion = GetRandomQuestion();
        Console.Write($"> {randomQuestion}");

        _questions.Remove(randomQuestion);

        if (!_questions.Any())
        {
            foreach (string question in _usedQuestions)
            {
                _questions.Add(question);
            }
        }
    }
}