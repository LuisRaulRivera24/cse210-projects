using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Here I create a numbers list
        List<int> numbersList = new List<int>();
        int number;

        Console.WriteLine();
        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");

        // The user will keep entering numbers that will be added to the list until they type "0"
        do
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());

            if (number != 0)
            {
                numbersList.Add(number);
            }
        } while (number != 0);

        // Here I calculate the sum, average, and max from the list created
        int sum = numbersList.Sum();
        double average = numbersList.Average();
        int max = numbersList.Max();

        // Here I create a positive and negative number list
        List<int> positiveNumberList = new List<int>();
        List<int> negativeNumberList = new List<int>();

        // Here I sort my numbers list
        numbersList.Sort();

        // Here I go through each number in my list and separate them to the respective positive/negative numbers lists
        for (int i = 0; i < numbersList.Count; i++)
        {
            if (numbersList[i] >= 0)
            {
                positiveNumberList.Add(numbersList[i]);
            }
            else
            {
                negativeNumberList.Add(numbersList[i]);
            }
        }

        // Here I find the smallest value in the positive number list
        int smallestPositive = positiveNumberList.Min();

        // Here I print my results
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");
        Console.WriteLine($"The smallest positive number is: {smallestPositive}");
        Console.WriteLine("The sorted list is:");
        // Here I print every number in my numbers list from smallest to largest
        foreach (int individualNumber in numbersList)
        {
            Console.WriteLine(individualNumber);
        }
        Console.WriteLine();
    }
}