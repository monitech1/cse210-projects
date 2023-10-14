using System;

class Program
{
    static void Main()
    {
        // Create a sample scripture
        Scripture scripture = new Scripture("Jacob 6:12", "O be wise; what can I say more?.");

        // Display the complete scripture
        scripture.Display();

        while (scripture.Words.Any(word => !word.IsHidden))
        {
            Console.WriteLine("Press Enter to continue or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;
// Hide 3 random words
            scripture.HideRandomWords(3); 
            Console.Clear();
            scripture.Display();
        }

        Console.WriteLine("All words are hidden. Program ended.");
    }
}

