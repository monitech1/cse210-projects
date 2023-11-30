using System;

namespace Prep3
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Random random = new Random();

            do
            {
                int magicNumber = random.Next(1, 101); // Generates a random number between 1 and 100
                int numberOfGuesses = 0;
                int userGuess;

                Console.WriteLine("Welcome to the Guess My Number game!");
                Console.WriteLine("I've selected a magic number between 1 and 100.");
                Console.WriteLine("Try to guess it.");

                do
                {
                    Console.Write("Enter your guess: ");
                    userGuess = Convert.ToInt32(Console.ReadLine());
                    numberOfGuesses++;

                    if (userGuess < magicNumber)
                    {
                        Console.WriteLine("Higher");
                    }
                    else if (userGuess > magicNumber)
                    {
                        Console.WriteLine("Lower");
                    }
                    else
                    {
                        Console.WriteLine($"You guessed it in {numberOfGuesses} attempts!");
                    }
                } while (userGuess != magicNumber);

                Console.Write("Do you want to play again? (yes/no): ");
            } while (Console.ReadLine().ToLower() == "yes");
        }
    }
}
