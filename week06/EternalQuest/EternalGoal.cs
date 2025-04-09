//LN - Define the EternalGoal class, inheriting from the Goal base class
public class EternalGoal : Goal
{
    //LN - Constructor that passes the name, description, and points to the base Goal constructor
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
    }

    //LN - Override the RecordEvent method to log the event without marking it as complete
    public override void RecordEvent()
    {
        //LN - Display a message indicating that the goal event was recorded and points were earned
        Console.WriteLine($"Recorded {_name}! Earned {_points} points.");
    }

    //LN - Override the GetStringRepresentation method to return goal data in a formatted string
    public override string GetStringRepresentation()
    {
        //LN - Return a string representation of the eternal goal for saving to a file
        return $"EternalGoal:{_name},{_description},{_points}";
    }
}
