using System.Runtime.CompilerServices;

public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public void Display()
    {
        DateTime currentTime = DateTime.Now;
        _date = currentTime.ToShortDateString();

        PromptGenerator prompt = new PromptGenerator();
        _promptText = prompt.GetRandomPrompt();
        Console.Write(_promptText + " ");

        _entryText = Console.ReadLine();

    }
}