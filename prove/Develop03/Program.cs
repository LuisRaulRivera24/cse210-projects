using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

// TO EXCEED REQUIREMENTS, I COMPLETED THE STRETCH CHALLENGE — RANDOMLY SELECT FROM ONLY THOSE WORDS THAT ARE NOT ALREADY HIDDEN.
class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        Reference reference = new Reference("Proverbs", 3, 5, 6);

        Scripture scripture = new Scripture(reference, """
        Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.
        """ );

        string keepGoing = "not done";
        while (keepGoing != "quit")
        {
            Console.WriteLine($"{scripture.GetDisplayText()}\n");
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            keepGoing = Console.ReadLine();
            
            if (scripture.IsCompletelyHidden() == true)
            {
                keepGoing = "quit";
            }
            
            int randomNumber;
            if (scripture.GetListCount() == 1)
            {
                randomNumber = 1;
            }
            else if (scripture.GetListCount() % 2 == 0)
            {
                randomNumber = 2;
            }
            else
            {
                randomNumber = 3;
            }
            scripture.HideRandomWords(randomNumber);
            Console.Clear();
        }
    }
}