using System;
using System.IO;
using System.IO.Enumeration;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        int numberChoice;
        do
        {
            Console.Write(
                """
                Please select one of the following choices:
                1. Write
                2. Display
                3. Load
                4. Save
                5. Quit
                What would you like to do? 
                """);

            numberChoice = int.Parse(Console.ReadLine());

            if (numberChoice == 1)
            {
                Entry newEntry = new Entry();
                newEntry.Display();
                journal.AddEntry(newEntry);
            }
            else if (numberChoice == 2)
            {
                journal.DisplayAll();
            }
            else if (numberChoice == 3)
            {
                Console.WriteLine("What is the filename?");
                string fileName = Console.ReadLine();
                journal.LoadFromFile(fileName);
            }
            else if (numberChoice == 4)
            {
                Console.WriteLine("What is the filename?");
                string fileName = Console.ReadLine();
                journal.SaveToFile(fileName);
            }
            else
            {
                numberChoice = 5;
            }
        } while (numberChoice != 5);
    }
}