using System;

class Program
{
    static void Main(string[] args)
    {
        // User manually inputs a number to guess

        // Console.Write("What is the magic number? ");
        // string magicNumber = Console.ReadLine();
        // int actualNumber = int.Parse(magicNumber);

        // The player will keep playing as long as they say "yes"
        string playAgain = "yes";
        while (playAgain == "yes")
        {
            // This is the random number generator
            Random randomNumberGenerator = new Random();
            int actualNumber = randomNumberGenerator.Next(1,101);

            // This is the variable for the number guess
            int numberGuess;
            // Here I keep track of the total number of guesses
            int totalGuesses = 0;

            // This is my do-while loop which will keep going until the user guesses the random number
            do
            {
                // User enters a guess
                Console.Write("What is your guess? ");
                string guess = Console.ReadLine();
                numberGuess = int.Parse(guess);
                
                // Here I add 1 for every guess that is taken
                totalGuesses++;
                
                // The user will be guided to guess right
                if (numberGuess > actualNumber)
                {
                    Console.WriteLine("Lower");
                }
                else if (numberGuess < actualNumber)
                {
                    Console.WriteLine("Higher");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"You made a total of {totalGuesses} guess(es).");
                    // User gets asked if he wants to play again. If "yes", another game starts.
                    Console.Write("Do you want to play again? (yes/no): ");
                    playAgain = Console.ReadLine();
                }
            } while (numberGuess != actualNumber);
        }
    }
}