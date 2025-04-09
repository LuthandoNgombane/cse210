//LN - Import System namespace to enable basic input/output operations
using System;

//LN - Declare the Activity class, which will act as a base for different activity types
public class Activity
{
    //LN - Field to store the name of the activity
    protected string _name;

    //LN - Field to store the description of the activity
    protected string _description;

    //LN - Field to store the user-defined duration of the activity in seconds
    public int _duration;

    //LN - Constructor to initialize the activity with a name and description
    public Activity(string name, string description)
    {
        //LN - Set the activity name based on constructor input
        _name = name;

        //LN - Set the activity description based on constructor input
        _description = description;

        //LN - Initialize duration to 0; will be updated in StartActivity()
        _duration = 0;
    }

    //LN - StartActivity handles user input and starts the session with a loading spinner
    public void StartActivity()
    {
        //LN - Display message that the activity is starting
        Console.WriteLine($"Starting {_name} Activity");

        //LN - Display the activity description to the user
        Console.WriteLine(_description);

        //LN - Prompt the user to enter how long they want the session to last
        Console.Write("How long, in seconds, would you like for your session? ");

        //LN - Read and convert the user input into an integer for the duration
        _duration = int.Parse(Console.ReadLine());

        //LN - Notify the user that the session is about to start
        Console.WriteLine("Get ready...");

        //LN - Display a spinner animation for 3 seconds to prepare the user
        ShowSpinner(3);
    }

    //LN - EndActivity wraps up the session and shows post-activity feedback
    public void EndActivity()
    {
        //LN - Display a closing congratulatory message
        Console.WriteLine("\nGood job!");

        //LN - Show a brief spinner animation as a transition
        ShowSpinner(2);

        //LN - Confirm that the activity has completed and show the duration
        Console.WriteLine($"You have completed the {_name} Activity for {_duration} seconds.");

        //LN - Show another spinner animation to conclude the session
        ShowSpinner(3);
    }

    //LN - ShowSpinner displays a simple rotating spinner for a given number of seconds
    protected void ShowSpinner(int seconds)
    {
        //LN - Define spinner animation characters to rotate
        string[] spinner = { "|", "/", "-", "\\" };

        //LN - Calculate total frames based on time and frame rate (4 frames/sec)
        int iterations = seconds * 4;

        //LN - Loop through each spinner frame to simulate animation
        for (int i = 0; i < iterations; i++)
        {
            //LN - Print the current spinner character
            Console.Write(spinner[i % 4]);

            //LN - Pause for 250 milliseconds to create frame timing
            Thread.Sleep(250);

            //LN - Erase the current character to make room for the next one
            Console.Write("\b \b");
        }

        //LN - Move to the next line after spinner completes
        Console.WriteLine();
    }

    //LN - ShowCountdown displays a countdown timer from the given number of seconds
    protected void ShowCountdown(int seconds)
    {
        //LN - Loop backwards from the given time to 1
        for (int i = seconds; i > 0; i--)
        {
            //LN - Display the current countdown number
            Console.Write($"{i}");

            //LN - Wait for one second before updating the display
            Thread.Sleep(1000);

            //LN - Erase the current number to replace it with the next one
            Console.Write("\b \b");
        }

        //LN - Move to the next line after countdown completes
        Console.WriteLine();
    }
}
