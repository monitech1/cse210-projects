// ChecklistGoal.cs
public class ChecklistGoal : Goal
{
    private int completionCount;
    private int requiredCount;

    public ChecklistGoal(string title, int points, int requiredCount) : base(title, points)
    {
        this.requiredCount = requiredCount;
        this.completionCount = 0;
    }

    public void RecordCompletion()
    {
        if (completionCount < requiredCount)
        {
            completionCount++;
            Console.WriteLine($"Recorded completion! Current count: {completionCount}/{requiredCount}");
        }
        else
        {
            Console.WriteLine("Goal already completed the required number of times.");
        }
    }

    public override int EarnPoints()
    {
        return base.EarnPoints();
    }

    public override string ToString()
    {
        return $"{base.ToString()} - Completed {completionCount}/{requiredCount} times";
    }
}
