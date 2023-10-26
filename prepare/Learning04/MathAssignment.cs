public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    //MathAssignment with four parameters
    public MathAssignment(string studentName, string topic, string textbookSection, string problems)
        : base(studentName, topic)
    {
        // Set the MathAssignment specific variables
        _textbookSection = textbookSection;
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        return $"Section {_textbookSection} Problems {_problems}";
    }
}
