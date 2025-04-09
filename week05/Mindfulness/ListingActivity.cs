//LN - Import System namespace for console interaction and date/time functionality
using System;

//LN - Import collections namespace to use lists
using System.Collections.Generic;

//LN - Define ListingActivity class that inherits from Activity base class
public class ListingActivity : Activity
{
    //LN - Declare a private list of prompts to randomly select from
    private List<string> _prompts = new List<string>
    {
        //LN - Prompt to reflect on people you appreciate
        "Who are people that you appreciate?",

        //LN - Prompt to think about your strengths
        "What are personal strengths of yours?",

        //LN - Prompt to list people you’ve helped recently
        "Who are people that you have helped this week?",

        //LN - Prompt to reflect on spiritual impressions
        "When have you felt the Holy Ghost this month?",

        //LN - Prompt to list your personal heroes
        "Who are some of your personal heroes?"
    };

    //LN - Variable to count how many items the user lists
    private int _count;

    //LN - Constructor initializes base class with name and description of the activity
    public ListingActivity() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }

    //LN - Run starts the activity, displays a random prompt, and collects user input
    public void Run()
    {
        //LN - Start the base activity (prompt for duration, show intro)
        StartActivity();

        //LN - Create a random number generator instance
        Random rand = new Random();

        //LN - Display a randomly selected prompt from the list
        Console.WriteLine(_prompts[rand.Next(_prompts.Count)]);

        //LN - Notify user to prepare for listing
        Console.WriteLine("Get ready to list items...");

        //LN - Countdown before starting to collect items
        ShowCountdown(5);

        //LN - Calculate the time the activity should end
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        //LN - Create a list to store user inputted items
        List<string> items = new List<string>();

        //LN - Prompt user to start listing items with Enter key
        Console.WriteLine("Start listing (press Enter after each item, or Enter twice to finish early):");

        //LN - Loop to capture user input until time runs out
        while (DateTime.Now < endTime)
        {
            //LN - Read item from user input
            string item = Console.ReadLine();

            //LN - If the input is empty (double Enter), exit loop early
            if (string.IsNullOrEmpty(item)) break;

            //LN - Add item to the list
            items.Add(item);
        }

        //LN - Count how many items were listed
        _count = items.Count;

        //LN - Display the total number of items listed
        Console.WriteLine($"You listed {_count} items.");

        //LN - End the base activity with closing message and spinner
        EndActivity();
    }
}
