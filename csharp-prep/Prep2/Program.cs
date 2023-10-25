using System;

class Program
{
    static void Main(string[] args)
    {
        // Here I get the user input for their grade
        Console.WriteLine();
        Console.Write("What is your grade percentage? ");
        string gradeInput = Console.ReadLine();
        int grade = int.Parse(gradeInput);
        string letter;

        // Here I calculate the letter grade
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Here I calculate if the grade is a "+", or "-", or no sign.
        if ((grade % 10 >= 7) && (letter != "A") && (letter != "F"))
        {
            Console.WriteLine($"{letter}+");
        }
        else if ((grade % 10 < 3) && (letter != "F") && (grade != 100))
        {
            Console.WriteLine($"{letter}-");
        }
        else
        {
            Console.WriteLine(letter);
        }

        // Here I print out if they passed the course or not.
        if (grade >= 70)
        {
            Console.WriteLine("You passed the course, congratulations!");
        }
        else
        {
            Console.WriteLine("You did not pass the course, next time you will get it!");
        }
        Console.WriteLine();
    }
}