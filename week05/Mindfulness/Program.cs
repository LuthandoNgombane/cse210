//LN - Import System namespace for console input/output functionality
using System;

//LN - Import collections namespace to use List<T>
using System.Collections.Generic;

//LN - Define the Program class which contains the main entry point
class Program
{
    //LN - Define a static list to log completed activities during the session
    //LN - This allows feedback at the end of the session
    static List<string> activityLog = new List<string>();

    //LN - Main method: Entry point of the application
    static void Main(string[] args)
    {
        //LN - Create an instance of BreathingActivity
        BreathingActivity breathing = new BreathingActivity();

        //LN - Create an instance of ReflectingActivity
        ReflectingActivity reflecting = new ReflectingActivity();

        //LN - Create an instance of ListingActivity
        ListingActivity listing = new ListingActivity();

        //LN - Loop the menu until user chooses to quit
        while (true)
        {
            //LN - Clear the console for clean display
            Console.Clear();

            //LN - Display program menu options to the user
            Console.WriteLine("Mindfulness Program Menu:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflecting Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");

            //LN - Prompt user for input
            Console.Write("Select an option (1-4): ");
            string choice = Console.ReadLine();

            //LN - Exit loop if user chooses option 4
            if (choice == "4") break;

            //LN - Switch statement determines which activity to run
            switch (choice)
            {
                //LN - Run BreathingActivity and log completion
                case "1":
                    breathing.Run();
                    activityLog.Add($"Completed Breathing Activity for {breathing._duration} seconds");
                    break;

                //LN - Run ReflectingActivity and log completion
                case "2":
                    reflecting.Run();
                    activityLog.Add($"Completed Reflecting Activity for {reflecting._duration} seconds");
                    break;

                //LN - Run ListingActivity and log completion
                case "3":
                    listing.Run();
                    activityLog.Add($"Completed Listing Activity for {listing._duration} seconds");
                    break;

                //LN - Handle invalid input by showing error and pausing
                default:
                    Console.WriteLine("Invalid option. Press Enter to continue.");
                    Console.ReadLine();
                    break;
            }
        }

        //LN - Display summary of session after quitting
        Console.WriteLine("\nSession Summary:");

        //LN - If at least one activity was completed, list all
        if (activityLog.Count > 0)
        {
            Console.WriteLine("Activities completed this session:");

            //LN - Loop through and display each log entry
            foreach (string log in activityLog)
            {
                Console.WriteLine($"- {log}");
            }
        }
        else
        {
            //LN - Notify user that no activities were completed
            Console.WriteLine("No activities completed.");
        }

        //LN - Thank user after session ends
        Console.WriteLine("Thank you for using the Mindfulness Program!");
    }

    //LN - Creativity Comment:
    //LN - To exceed core requirements, I added an in-memory activity log that tracks completed activities
    //LN - and displays a summary when the user quits. This provides feedback on their session without
    //LN - requiring file I/O, enhancing the user experience beyond the basic specification.
}
