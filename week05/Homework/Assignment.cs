public class Assignment
{
    //LN - Create private fields for the student name and topic
    private string _studentName;
    private string _topic;

    //LN - Create a constructor that takes the student name and topic as parameters
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    //LN - Create a method that returns the summary of the assignment
    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }

    //LN - Create a method that returns the student name
    //LN - This method is used in the WritingAssignment class to get the student name
    public string GetStudentName()
    {
        return _studentName;
    }
}