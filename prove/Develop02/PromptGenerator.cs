public class PromptGenerator
{
    public List<string> _prompts = new List<string>
    {
        "What was the strongest emotion I felt today?",
        "What was the best part of my day?",
        "Who did I get a chance to talk with today?",
        "What is something I learned today?",
        "Do I have any fun plans coming up?",
    };

    public string GetRandomPrompt()
    {   

        Random randomPrompt = new Random();
        int promptIndex = randomPrompt.Next(_prompts.Count);

        return _prompts[promptIndex];
    }
}