using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Mindfulness Program!");
        
        //choose an activity (Breathing, Reflection, or Listing)
        Console.WriteLine("Choose an activity: ");
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Reflection Activity");
        Console.WriteLine("3. Listing Activity");
        
        int selectedActivity;
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out selectedActivity) && selectedActivity >= 1 && selectedActivity <= 3)
            {
                break;
            }
            Console.WriteLine("Invalid input. Please enter a valid activity number (1-3).");
        }

        // Prompt the user to set the duration for the chosen activity
        Console.Write("Enter the duration (in seconds): ");
        int duration;
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out duration) && duration > 0)
            {
                break;
            }
            Console.WriteLine("Invalid input. Please enter a valid positive duration (in seconds).");
        }

        // Create an instance of the selected activity
        MindfulnessActivity activity;
        switch (selectedActivity)
        {
            case 1:
                activity = new BreathingActivity(duration);
                break;
            case 2:
                activity = new ReflectionActivity(duration);
                break;
            case 3:
                activity = new ListingActivity(duration);
                break;
            default:
                activity = new BreathingActivity(duration); // Default to Breathing Activity
                break;
        }

        // Call the StartActivity method for the chosen activity
        activity.StartActivity();

        // Simulate the activity duration (you need to implement the actual activity logic)
        // For now, let's just pause for the specified duration.
        Console.WriteLine($"Activity will run for {duration} seconds...");
        System.Threading.Thread.Sleep(duration * 1000);

        // Call the EndActivity method when the activity is completed
        activity.EndActivity();

        Console.WriteLine("Thank you for using the Mindfulness Program!");
    }
}
