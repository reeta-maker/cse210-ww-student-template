public class Assignment
{
    // Private variables to store the data
    private string _studentName;
    private string _topic;

    // Constructor: runs when we create a new Assignment
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    // Getter: lets other classes safely read the private _studentName
    public string GetStudentName()
    {
        return _studentName;
    }

    // Method: combines name and topic into one string
    public string GetSummary()
    {
        return _studentName + " - " + _topic;
    }
}
