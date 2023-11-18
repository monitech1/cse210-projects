// QuestManager.cs
using System;

public class QuestManager
{
    private List<Goal> goals;
    private int score;

    public List<Goal> Goals // Public property to access the goals
    {
        get { return goals; }
    }

    public int Score // Public property to access the score
    {
        get { return score; }
    }

    public QuestManager()
    {
        goals = new List<Goal>();
        score = 0;
    }

    public void CreateGoal(string title, string type, int points, int requiredCount = 0)
    {
        Goal newGoal;

        switch (type.ToLower())
        {
            case "simple":
                newGoal = new SimpleGoal(title, points);
                break;

            case "eternal":
                newGoal = new EternalGoal(title, points);
                break;

            case "checklist":
                newGoal = new ChecklistGoal(title, points, requiredCount);
                break;

            default:
                throw new ArgumentException("Invalid goal type");
        }

        goals.Add(newGoal);
    }

    public void RecordEvent(Goal goal)
    {
        int earnedPoints = goal.EarnPoints();
        score += earnedPoints;
        Console.WriteLine($"Event recorded! Earned {earnedPoints} points.");
    }

    public void DisplayGoals()
    {
        Console.WriteLine("Current Goals:");
        foreach (Goal goal in goals)
        {
            Console.WriteLine(goal);
        }

        Console.WriteLine($"Total Score: {score}");
    }

    public void SaveGoalsToFile()
    {
        // Implement saving goals to a file
    }

    public void LoadGoalsFromFile()
    {
        // Implement loading goals from a file
    }
}
