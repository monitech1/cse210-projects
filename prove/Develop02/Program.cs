using System;

class Program
{
    static List<JournalEntry> journalEntries = new List<JournalEntry>();
    static List<string> prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };

    static void Main(string[] args)
    {
        bool continueRunning = true;

        while (continueRunning)
        {
            Console.WriteLine("Journal Program Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");
            Console.WriteLine("6 Thank you for writinng your journal");

            int choice = GetUserChoice(1, 5);

            switch (choice)
            {
                case 1:
                    WriteNewEntry();
                    break;
                case 2:
                    DisplayJournal();
                    break;
                case 3:
                    SaveJournalToFile();
                    break;
                case 4:
                    LoadJournalFromFile();
                    break;
                case 5:
                    continueRunning = false;
                    break;
            }
        }
    }

    static void WriteNewEntry()
    {
        Console.WriteLine("Writing a new entry...");
        string prompt = GetRandomPrompt();
        Console.WriteLine($"Prompt: {prompt}");
        Console.Write("Your response: ");
        string response = Console.ReadLine();
        string date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

        JournalEntry entry = new JournalEntry(date, prompt, response);
        journalEntries.Add(entry);

        Console.WriteLine("Entry added successfully!");
    }

    static void DisplayJournal()
    {
        Console.WriteLine("Journal Entries:");
        foreach (JournalEntry entry in journalEntries)
        {
            Console.WriteLine($"Date: {entry.Date}");
            Console.WriteLine($"Prompt: {entry.Prompt}");
            Console.WriteLine($"Response: {entry.Response}");
            Console.WriteLine();
        }
    }

    static void SaveJournalToFile()
    {
        Console.Write("Enter the filename to save the journal: ");
        string fileName = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (JournalEntry entry in journalEntries)
            {
                writer.WriteLine($"{entry.Date},{entry.Prompt},{entry.Response}");
            }
        }

        Console.WriteLine("Journal saved to file successfully!");
    }

    static void LoadJournalFromFile()
    {
        Console.Write("Enter the filename to load the journal: ");
        string fileName = Console.ReadLine();

        if (File.Exists(fileName))
        {
            journalEntries.Clear();
            using (StreamReader reader = new StreamReader(fileName))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 3)
                    {
                        string date = parts[0];
                        string prompt = parts[1];
                        string response = parts[2];
                        JournalEntry entry = new JournalEntry(date, prompt, response);
                        journalEntries.Add(entry);
                    }
                }
            }

            Console.WriteLine("Journal loaded from file successfully!");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }

    static string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(prompts.Count);
        return prompts[index];
    }

    static int GetUserChoice(int minValue, int maxValue)
    {
        int choice;
        while (!int.TryParse(Console.ReadLine(), out choice) || choice < minValue || choice > maxValue)
        {
            Console.Write($"Please enter a valid choice ({minValue}-{maxValue}): ");
        }
        return choice;
    }
}
