public class MathAssignment : Assignment
{
    // Extra variables just for Math
    private string _textbookSection;
    private string _problems;

    // Constructor: takes all 4 things, and sends name & topic up to the parent using : base()
    public MathAssignment(string studentName, string topic, string textbookSection, string problems)
        : base(studentName, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }

    // Method: returns the section and problems
    public string GetHomeworkList()
    {
        return "Section " + _textbookSection + " Problems " + _problems;
    }
}
