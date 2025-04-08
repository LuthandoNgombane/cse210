public class WritingAssignment : Assignment
{

    //LN - Create a private field for the title of the writing assignment
    private string _title;

    //LN - Create a constructor that takes the student name, topic, and title as parameters
    public WritingAssignment(string studentName, string topic, string title)
        : base(studentName, topic)
    {
        _title = title;
    }

    //LN - Create a method that returns the writing information
    //LN - The method should return a string that includes the title and the student name
    public string GetWritingInformation()
    {
        return $"{_title} by {GetStudentName()}";
    }
}