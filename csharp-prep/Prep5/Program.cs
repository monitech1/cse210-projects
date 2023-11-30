using System;

namespace Prep5
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Display welcome message
            DisplayWelcome();

            // Prompt user for their name
            string userName = PromptUserName();

            // Prompt user for their favorite number
            int userNumber = PromptUserNumber();

            // Calculate the square of the number
            int squaredNumber = SquareNumber(userNumber);

            // Display the result
            DisplayResult(userName, squaredNumber);

            Console.ReadLine();
        }

        private static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }

        private static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            return Console.ReadLine();
        }

        private static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        private static int SquareNumber(int number)
        {
            return number * number;
        }

        private static void DisplayResult(string userName, int squaredNumber)
        {
            Console.WriteLine($"{userName}, the square of your number is {squaredNumber}");
        }
    }
}
