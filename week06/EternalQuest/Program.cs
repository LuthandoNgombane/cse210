//LN - Import the System namespace for basic functionality
using System;

//LN - Main program class
class Program
{
    //LN - Entry point of the program
    static void Main(string[] args)
    {
        //LN - Create an instance of GoalManager to manage goals
        GoalManager manager = new GoalManager();

        //LN - Filename used for saving/loading goals
        string filename = "goals.txt";

        //LN - Main loop to show menu and process user input
        while (true)
        {
            //LN - Clear console before showing menu
            Console.Clear();

            //LN - Display program title
            Console.WriteLine("Eternal Quest Program");

            //LN - Show current score and level
            manager.DisplayScore();

            //LN - Show the main menu options
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. Quit");

            //LN - Get user choice
            Console.Write("Select an option (1-6): ");
            string choice = Console.ReadLine();

            //LN - Handle menu selection
            switch (choice)
            {
                case "1":

                    //LN - Call method to create a new goal
                    CreateGoal(manager); 
                    break;
                case "2":

                    //LN - Show list of current goals
                    manager.DisplayGoals(); 
                    break;
                case "3":

                    //LN - Show goals to choose from
                    manager.DisplayGoals(); 
                    Console.Write("Enter goal number to record: ");

                    //LN - Convert user input to index
                    int index = int.Parse(Console.ReadLine()) - 1; 

                    //LN - Record progress for the chosen goal
                    manager.RecordEvent(index); 
                    break;
                case "4":

                    //LN - Save goals to file
                    manager.SaveGoals(filename); 
                    break;
                case "5":

                    //LN - Load goals from file
                    manager.LoadGoals(filename); 
                    break;
                case "6":

                    //LN - Exit the program
                    return; 
                default:

                    //LN - Handle invalid menu choice
                    Console.WriteLine("Invalid option."); 
                    break;
            }

            //LN - Pause the program before returning to the menu
            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadLine();
        }
    }

    //LN - Method to create a new goal
    static void CreateGoal(GoalManager manager)
    {
        //LN - Display available goal types
        Console.WriteLine("\nGoal Types:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        //LN - Ask user to select a goal type
        Console.Write("Select goal type (1-3): ");
        string type = Console.ReadLine();

        //LN - Gather common input for all goal types
        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter goal description: ");
        string desc = Console.ReadLine();
        Console.Write("Enter points per event: ");
        int points = int.Parse(Console.ReadLine());

        //LN - Based on type, create the appropriate goal
        switch (type)
        {
            case "1":
                manager.AddGoal(new SimpleGoal(name, desc, points));
                break;
            case "2":
                manager.AddGoal(new EternalGoal(name, desc, points));
                break;
            case "3":
                Console.Write("Enter target count: ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus points: ");
                int bonus = int.Parse(Console.ReadLine());
                manager.AddGoal(new ChecklistGoal(name, desc, points, target, bonus));
                break;
            default:
                Console.WriteLine("Invalid goal type.");
                break;
        }
    }

    // Creativity Comment:
    //LN - To exceed requirements, I added a leveling system where the user gains a level every 1000 points.
    //LN - The level is displayed with the score in the menu and updates with a congratulatory message when achieved.
    //LN - This adds a gamification element to motivate users beyond just points.
}
