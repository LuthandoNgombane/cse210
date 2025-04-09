//LN - Define the SimpleGoal class, inheriting from the Goal base class
public class SimpleGoal : Goal
{
    //LN - Constructor that passes the name, description, and points to the base Goal constructor
    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
    }

    //LN - Override the RecordEvent method to mark the goal as complete
    public override void RecordEvent()
    {
        //LN - Check if the goal is not already complete
        if (!_isComplete)
        {
            //LN - Mark the goal as complete
            _isComplete = true;

            //LN - Display a message indicating completion and points earned
            Console.WriteLine($"Completed {_name}! Earned {_points} points.");
        }
        else
        {
            //LN - Display a message if the goal was already completed
            Console.WriteLine($"{_name} is already complete.");
        }
    }

    //LN - Override the GetStringRepresentation method to return goal data in a formatted string
    public override string GetStringRepresentation()
    {
        //LN - Return a string representation of the goal for saving to a file
        return $"SimpleGoal:{_name},{_description},{_points},{_isComplete}";
    }
}
