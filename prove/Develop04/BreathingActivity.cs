using System;

internal class BreathingActivity : MindfulnessActivity
{
    public BreathingActivity(int duration) : base(duration) { }

    public override void StartActivity()
    {
        base.StartActivity();
        Console.WriteLine("This activity will help you relax by walking you through breathing in and out slowly.");

        Console.WriteLine("Get ready to begin your breathing exercise...");

        for (int i = duration; i > 0; i--)
        {
            Console.WriteLine($"Breathe in... ({i} seconds remaining)");
            Thread.Sleep(1000); // Pause for 1 second
            Console.Clear(); // Clear the console to remove previous messages
            Console.WriteLine($"Breathe out... ({i - 1} seconds remaining)");
            Thread.Sleep(1000); // Pause for 1 second
            Console.Clear(); // Clear the console
        }
    }
}
