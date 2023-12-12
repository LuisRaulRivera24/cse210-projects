using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        List<string> addressOne = new List<string>{"3516 Vineyard Drive",
                                                   "Euclid",
                                                   "OH",
                                                   "44132"};

        List<string> addressTwo = new List<string>{"4950 Romines Mill Road",
                                                   "Rowlett",
                                                   "TX",
                                                   "75088"};

        List<string> addressThree = new List<string>{"1705 New York Avenue",
                                                     "Woodland Hills",
                                                     "CA",
                                                     "91303"};

        new Lecture("English Lessons", "We will be teaching the basics of grammar, vocabulary, and conversation skills.", "10/24/2023", "11:30am - 4:30pm", addressOne, "John Adams", 50);
        new Reception("It All Started With A Dance", "Come join us in celebrating the long awaited wedding of Tyler and Sarah!", "04/25/2024", "6:00pm - 7:30pm", addressTwo, "UnitingLives@receptions.com");
        new OutdoorGathering("Outdoor Movie Night", "Come join us in our outdoor movie night to watch The Minions!", "12/20/2023", "8:00pm - 10:00pm", addressThree, "sunny with 2% chance of rain");
    }
}