public class MathAssignment : Assignment
{   
    //LN - Create private fields for the textbook section and problems
    private string _textbookSection;
    private string _problems;

    //LN - Create a constructor that takes the student name, topic, textbook section, and problems as parameters
    public MathAssignment(string studentName, string topic, string textbookSection, string problems)
        : base(studentName, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }

    //LN - Create a method that returns the homework list
    public string GetHomeworkList()
    {
        return $"Section {_textbookSection} Problems {_problems}";
    }
}