using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("What is your first names? ");
        string first = Console.ReadLine();

        Console.Write("What is your last name? ");
        string last = Console.ReadLine();

        Console.WriteLine($"Your name is {last}, {first} {last}.");
    }
}