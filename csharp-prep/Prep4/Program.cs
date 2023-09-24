using System;

namespace Prep5
{
    class Program
    {
        static void Main(string[] args)
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

        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            return Console.ReadLine();
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        static int SquareNumber(int number)
        {
            return number * number;
        }

        static void DisplayResult(string userName, int squaredNumber)
        {
            Console.WriteLine($"{userName}, the square of your number is {squaredNumber}");
        }
    }
}
