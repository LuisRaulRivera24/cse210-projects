using System.ComponentModel.DataAnnotations;

public class Menu
{
    private string _meditating;
    private int _menuOption;

    public void DisplayMenu()
    {
        while (_meditating != "finished")
        {
            Console.Write("""
            Menu Options:
                1. Start breathing activity
                2. Start reflecting activity
                3. Start listing activity
                4. Quit
            Select a choice from the menu: 
            """);

            _menuOption = int.Parse(Console.ReadLine());

            if (_menuOption == 1)
            {
                Console.Clear();
                BreathingActivity breathingActivity = new BreathingActivity("Breathing Activity", """
                                                                            relax by walking you through breathing in and out slowly.
                                                                            Clear your mind and focus on your breathing.
                                                                            """);
                breathingActivity.DisplayStartingMessage();
                breathingActivity.Run();
            }
            else if (_menuOption == 2)
            {
                Console.Clear();
                ReflectingActivity reflectingActivity = new ReflectingActivity("Reflecting Activity", """
                                                                                reflect on times in your life when you have shown strength and resilience.
                                                                                This will help you recognize the power you have and how you can use it in other aspects of your life.
                                                                                """);
                reflectingActivity.DisplayStartingMessage();
                reflectingActivity.Run();
            }
            else if (_menuOption == 3)
            {
                Console.Clear();
                ListingActivity listingActivity = new ListingActivity("Listing Activity", "reflect on the good things in your life by having you list as many things as you can in a certain area.");
                listingActivity.DisplayStartingMessage();
                listingActivity.Run();   
            } 
            else
            {
                if (_menuOption == 4)
                {
                    _meditating = "finished";
                }
                else
                {
                    Console.Clear();
                }
            }
        }
    }
}