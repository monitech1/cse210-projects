// Goal.cs
public class Goal
{
    protected string title;
    protected bool completed;
    protected int points;

    public Goal(string title, int points)
    {
        this.title = title;
        this.completed = false;
        this.points = points;
    }

    public virtual void MarkComplete()
    {
        completed = true;
    }

    public virtual int EarnPoints()
    {
        return completed ? points : 0;
    }

    public override string ToString()
    {
        return $"{title} [Completed: {completed}, Points: {points}]";
    }
}
