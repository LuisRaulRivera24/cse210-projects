using System.Runtime.CompilerServices;

public class Entry
{
    public string _date {get; set;}
    public string _promptText {get; set;}
    public string _entryText {get; set;}

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