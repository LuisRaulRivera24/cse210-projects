using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome ();
        string name = PromptUserName ();
        int number = PromptUserNumber ();
        int numSquared = SquareNumber (number);
        DisplayResult (name, numSquared);
    }
    static void DisplayWelcome ()
    {
        Console.WriteLine();
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName ()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();
        return userName;
    }

    static int PromptUserNumber ()
    {
        Console.Write("Please enter your favorite number: ");
        int favoriteNumber = int.Parse(Console.ReadLine());
        return favoriteNumber;
    }

    static int SquareNumber (int num)
    {
        int squaredNum = num * num;
        return squaredNum;
    }

    static void DisplayResult (string name, int squaredNum)
    {
        Console.WriteLine($"{name}, the square of your number is {squaredNum}");
        Console.WriteLine();
    }
}