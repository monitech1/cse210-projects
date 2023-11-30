using System;

internal class ListingActivity : MindfulnessActivity
{
    private List<string> prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity(int duration) : base(duration) { }

    public override void StartActivity()
    {
        base.StartActivity();
        Console.WriteLine("This activity will help you reflect on the good things in your life.");
        Console.WriteLine("Get ready to list items...");

        for (int i = duration; i > 0; i--)
        {
            string randomPrompt = GetRandomPrompt();
            Console.WriteLine($"List items related to: {randomPrompt} ({i} seconds remaining)");
            Thread.Sleep(1000); // Pause for 1 second
            Console.Clear(); // Clear the console
        }

        Console.WriteLine("Activity completed. Please review the items you listed.");
    }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(prompts.Count);
        return prompts[index];
    }
}
