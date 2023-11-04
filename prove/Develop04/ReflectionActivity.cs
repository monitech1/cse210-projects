using System;

class ReflectionActivity : MindfulnessActivity
{
    private List<string> prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    public ReflectionActivity(int duration) : base(duration) { }

    public override void StartActivity()
    {
        base.StartActivity();
        Console.WriteLine("This activity will help you reflect on times when you have shown strength and resilience.");

        for (int i = 1; i <= duration; i++)
        {
            string randomPrompt = GetRandomPrompt();
            Console.WriteLine($"Reflect on: {randomPrompt} ({i}/{duration} seconds)");
            Thread.Sleep(1000); // Pause for 1 second
            Console.Clear(); // Clear the console
            DisplayQuestions();
            Thread.Sleep(2000); // Pause for 2 seconds (with a spinner animation)
            Console.Clear(); // Clear the console
        }
    }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(prompts.Count);
        return prompts[index];
    }

    private void DisplayQuestions()
    {
        List<string> questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };

        foreach (string question in questions)
        {
            Console.WriteLine(question);
            Thread.Sleep(2000); // Pause for 2 seconds (with a spinner animation)
            Console.Clear(); // Clear the console
        }
    }
}
