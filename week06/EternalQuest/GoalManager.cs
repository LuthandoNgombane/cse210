//LN - Import necessary namespaces
using System;
using System.Collections.Generic;
using System.IO;

//LN - Define the GoalManager class to manage goals, scores, and levels
public class GoalManager
{
    //LN - List to store all the user's goals
    private List<Goal> _goals;

    //LN - Total score accumulated by the user
    private int _score;

    //LN - Current level of the user (bonus feature)
    private int _level;

    //LN - Constructor to initialize the goal manager with default values
    public GoalManager()
    {
        //LN - Initialize the list of goals
        _goals = new List<Goal>();

        //LN - Start score at 0
        _score = 0;

        //LN - Set initial level to 1
        _level = 1;
    }

    //LN - Method to add a new goal to the list
    public void AddGoal(Goal goal)
    {
        //LN - Add the goal to the goals list
        _goals.Add(goal);

        //LN - Display confirmation message
        Console.WriteLine($"Added goal: {goal.GetDetailsString()}");
    }

    //LN - Method to record an event for a specific goal
    public void RecordEvent(int index)
    {
        //LN - Check that the index is valid
        if (index >= 0 && index < _goals.Count)
        {
            //LN - Get the selected goal
            Goal goal = _goals[index];

            //LN - Call the RecordEvent method on the goal
            goal.RecordEvent();

            //LN - Add points from the goal to the total score
            _score += goal.GetPoints();

            //LN - If it's a completed checklist goal, add bonus points
            if (goal is ChecklistGoal checklist && checklist.IsComplete())
            {
                _score += checklist.GetBonusPoints();
            }

            //LN - Update the user's level if needed
            UpdateLevel();
        }
        else
        {
            //LN - Inform the user about an invalid index
            Console.WriteLine("Invalid goal index.");
        }
    }

    //LN - Method to display all current goals with their progress
    public void DisplayGoals()
    {
        //LN - Show the heading for goals
        Console.WriteLine("\nGoals:");

        //LN - Loop through each goal and display its details
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. { _goals[i].GetDetailsString()}");
        }
    }

    //LN - Display the current score and level of the user
    public void DisplayScore()
    {
        Console.WriteLine($"\nCurrent Score: {_score} | Level: {_level}");
    }

    //LN - Save all goals and the score to a file
    public void SaveGoals(string filename)
    {
        //LN - Open a file to write
        using (StreamWriter writer = new StreamWriter(filename))
        {
            //LN - Write the score on the first line
            writer.WriteLine(_score);

            //LN - Write each goal's data using its string representation
            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }

        //LN - Confirm save
        Console.WriteLine("Goals saved successfully.");
    }

    //LN - Load goals and score from a file
    public void LoadGoals(string filename)
    {
        //LN - Check if the file exists
        if (File.Exists(filename))
        {
            //LN - Read all lines from the file
            string[] lines = File.ReadAllLines(filename);

            //LN - First line is the saved score
            _score = int.Parse(lines[0]);

            //LN - Clear current goal list before loading new data
            _goals.Clear();

            //LN - Loop through each goal entry and reconstruct it
            for (int i = 1; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split(':');
                string type = parts[0];
                string[] data = parts[1].Split(',');

                switch (type)
                {
                    //LN - Rebuild a SimpleGoal
                    case "SimpleGoal":
                        _goals.Add(new SimpleGoal(data[0], data[1], int.Parse(data[2])));

                        //LN - Simulate completion if it was completed
                        _goals.Last().RecordEvent();
                        break;

                    //LN - Rebuild an EternalGoal
                    case "EternalGoal":
                        _goals.Add(new EternalGoal(data[0], data[1], int.Parse(data[2])));
                        break;

                    //LN - Rebuild a ChecklistGoal and simulate its progress
                    case "ChecklistGoal":
                        ChecklistGoal goal = new ChecklistGoal(data[0], data[1], int.Parse(data[2]), 
                            int.Parse(data[3]), int.Parse(data[4]));
                        for (int j = 0; j < int.Parse(data[5]); j++)
                            goal.RecordEvent();
                        _goals.Add(goal);
                        break;
                }
            }

            //LN - Update the level after loading data
            UpdateLevel();

            //LN - Confirm load
            Console.WriteLine("Goals loaded successfully.");
        }
        else
        {
            //LN - Inform the user if no file is found
            Console.WriteLine("No save file found.");
        }
    }

    //LN - Method to update the level based on score
    private void UpdateLevel()
    {
        //LN - Calculate level based on score (1000 points per level)
        int newLevel = _score / 1000 + 1;

        //LN - If level increases, notify the user
        if (newLevel > _level)
        {
            _level = newLevel;
            Console.WriteLine($"Congratulations! You've reached Level {_level}!");
        }
    }
}
