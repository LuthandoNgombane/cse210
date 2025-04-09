//LN - Define the ChecklistGoal class, inheriting from the Goal base class
public class ChecklistGoal : Goal
{
    //LN - Private field to track current progress count
    private int _currentCount;

    //LN - Private field to define how many times the goal must be recorded to complete
    private int _targetCount;

    //LN - Private field for the bonus points awarded upon completion
    private int _bonusPoints;

    //LN - Constructor to initialize checklist goal properties and pass base values
    public ChecklistGoal(string name, string description, int points, int targetCount, int bonusPoints) 
        : base(name, description, points)
    {
        //LN - Initialize the current count to 0
        _currentCount = 0;

        //LN - Set the required number of completions to reach the goal
        _targetCount = targetCount;

        //LN - Set the bonus points to award upon goal completion
        _bonusPoints = bonusPoints;
    }

    //LN - Override the RecordEvent method to track progress and check for completion
    public override void RecordEvent()
    {
        //LN - Only record progress if the goal is not yet complete
        if (!_isComplete)
        {
            //LN - Increment the progress counter
            _currentCount++;

            //LN - Display progress and earned points
            Console.WriteLine($"Recorded {_name}! Earned {_points} points. Progress: {_currentCount}/{_targetCount}");

            //LN - Check if the goal has reached or surpassed the target count
            if (_currentCount >= _targetCount)
            {
                //LN - Mark the goal as complete
                _isComplete = true;

                //LN - Announce goal completion and bonus points
                Console.WriteLine($"Completed {_name}! Earned bonus of {_bonusPoints} points!");
            }
        }
        else
        {
            //LN - Inform the user that the goal is already complete
            Console.WriteLine($"{_name} is already complete.");
        }
    }

    //LN - Override to return a detailed string with progress tracking
    public override string GetDetailsString()
    {
        //LN - Return formatted details including progress out of target
        return $"[{(_isComplete ? "X" : " ")}] {_name} - {_description} ({_currentCount}/{_targetCount})";
    }

    //LN - Override to return a string for saving the goal state
    public override string GetStringRepresentation()
    {
        //LN - Return a full representation string including progress and completion status
        return $"ChecklistGoal:{_name},{_description},{_points},{_targetCount},{_bonusPoints},{_currentCount},{_isComplete}";
    }

    //LN - Method to get the bonus points if the goal is complete
    public int GetBonusPoints()
    {
        //LN - Return bonus points only if the goal is marked complete
        return _isComplete ? _bonusPoints : 0;
    }
}
