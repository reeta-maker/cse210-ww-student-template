public class WritingAssignment : Assignment
{
    // Extra variable just for Writing
    private string _title;

    // Constructor: sends name & topic to the parent, and saves the title here
    public WritingAssignment(string studentName, string topic, string title)
        : base(studentName, topic)
    {
        _title = title;
    }

    // Method: gets the student's name from the parent class and combines it with the title
    public string GetWritingInformation()
    {
        string studentName = GetStudentName();
        return _title + " by " + studentName;
    }
}
