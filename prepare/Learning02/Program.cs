using System;

class Program
{
    static void Main(string[] args)
    {
        bool playAgain;

        do
        {
            Random random = new Random();
            int magicNumber = random.Next(1, 101); // Generate a random number between 1 and 100
            int numberOfGuesses = 0;
            int guess;

            Console.WriteLine("Welcome to the Guess My Number game!");
            Console.WriteLine("I've selected a magic number between 1 and 100.");
            Console.WriteLine("Try to guess it!");

            do
            {
                Console.Write("Enter your guess (1-100): ");
                if (int.TryParse(Console.ReadLine(), out guess))
                {
                    if (guess < 1 || guess > 100)
                    {
                        Console.WriteLine("Please enter a number between 1 and 100.");
                    }
                    else if (guess < magicNumber)
                    {
                        Console.WriteLine("Higher");
                    }
                    else if (guess > magicNumber)
                    {
                        Console.WriteLine("Lower");
                    }
                    else
                    {
                        Console.WriteLine("You guessed it!");
                    }

                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            } while (guess != magicNumber);

            Console.WriteLine($"It took you {numberOfGuesses} guesses to find the magic number.");
            Console.Write("Do you want to play again? (yes/no): ");
            string playAgainResponse = Console.ReadLine().ToLower();

            playAgain = (playAgainResponse == "yes");

        } while (playAgain);

        Console.WriteLine("Thanks for playing! Goodbye!");
    }
}
