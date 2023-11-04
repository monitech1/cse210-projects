using System;

class MindfulnessActivity
{
    protected int duration;

    public MindfulnessActivity(int duration)
    {
        this.duration = duration;
    }

    public virtual void StartActivity()
    {
        Console.WriteLine("Standard starting message and description");
        Thread.Sleep(2000);  // Pause for 2 seconds
        Console.WriteLine("Prepare to begin...");
        Thread.Sleep(2000);
    }

    public virtual void EndActivity()
    {
        Console.WriteLine("Good job! You've completed the activity.");
        Thread.Sleep(2000);
    }
}
