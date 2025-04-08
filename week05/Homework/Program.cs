using System;

class Program
{
    static void Main(string[] args)
    {

        //LN - Instantiate the classes and call their methods to test them
        //LN - Create an instance of the Assignment class and call GetSummary
        Assignment assignment = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(assignment.GetSummary());

        //LN - Create an instance of the MathAssignment class and call GetSummary and GetHomeworkList
        MathAssignment math = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(math.GetSummary());
        Console.WriteLine(math.GetHomeworkList());

        //LN - Create an instance of the WritingAssignment class and call GetSummary and GetWritingInformation
        WritingAssignment writing = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(writing.GetSummary());
        Console.WriteLine(writing.GetWritingInformation());
    }
}