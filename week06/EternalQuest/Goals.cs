//LN - Define an abstract class named Goal
public abstract class Goal
{
    //LN - Protected field to store the name of the goal
    protected string _name;

    //LN - Protected field to store the description of the goal
    protected string _description;

    //LN - Protected field to store the point value of the goal
    protected int _points;

    //LN - Protected field to track if the goal is completed
    protected bool _isComplete;

    //LN - Constructor to initialize the goal's name, description, and points
    public Goal(string name, string description, int points)
    {
        //LN - Set the name of the goal
        _name = name;

        //LN - Set the description of the goal
        _description = description;

        //LN - Set the point value of the goal
        _points = points;

        //LN - Initialize the completion status as false
        _isComplete = false;
    }

    //LN - Abstract method that must be implemented to handle recording an event
    public abstract void RecordEvent(); 

    //LN - Abstract method that must be implemented to return goal data as a string
    public abstract string GetStringRepresentation(); 

    //LN - Virtual method that returns a formatted string with goal details
    public virtual string GetDetailsString()
    {
        //LN - Return a string showing whether the goal is complete, along with its name and description
        return $"[{(_isComplete ? "X" : " ")}] {_name} - {_description}";
    }

    //LN - Method to check if the goal is complete
    public bool IsComplete()
    {
        return _isComplete;
    }

    //LN - Method to retrieve the point value of the goal
    public int GetPoints()
    {
        return _points;
    }
}
