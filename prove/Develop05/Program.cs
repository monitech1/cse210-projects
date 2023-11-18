// Program.cs
class Program
{
    static void Main()
    {
        QuestManager questManager = new QuestManager();

        //some goals created
        questManager.CreateGoal("Run a marathon", "simple", 1000);
        questManager.CreateGoal("Read scriptures", "eternal", 100);
        questManager.CreateGoal("Attend the temple", "checklist", 50, 10);

        //initial goals
        questManager.DisplayGoals();

        // Record events
        Goal marathonGoal = questManager.Goals.Find(g => g.ToString().Contains("Run a marathon"));
        questManager.RecordEvent(marathonGoal);

        Goal scriptureGoal = questManager.Goals.Find(g => g.ToString().Contains("Read scriptures"));
        questManager.RecordEvent(scriptureGoal);

        ChecklistGoal templeGoal = (ChecklistGoal)questManager.Goals.Find(g => g.ToString().Contains("Attend the temple"));
        for (int i = 0; i < 5; i++)
        {
            templeGoal.RecordCompletion();
            questManager.RecordEvent(templeGoal);
        }

        // Display updated goals
        questManager.DisplayGoals();
    }
}
