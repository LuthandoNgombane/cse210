//LN - Import System namespace for console and date/time functionality
using System;

//LN - Import collections namespace to use List<T>
using System.Collections.Generic;

//LN - Define the ReflectingActivity class which inherits from the Activity base class
public class ReflectingActivity : Activity
{
    //LN - Define a list of prompts to help users recall meaningful experiences
    private List<string> _prompts = new List<string>
    {
        //LN - Prompt user to remember a time they stood up for someone
        "Think of a time when you stood up for someone else.",

        //LN - Prompt user to recall a difficult experience
        "Think of a time when you did something really difficult.",

        //LN - Prompt user to reflect on a time they helped someone
        "Think of a time when you helped someone in need.",

        //LN - Prompt user to think of a truly selfless act
        "Think of a time when you did something truly selfless."
    };

    //LN - Define a list of follow-up questions for deeper reflection
    private List<string> _questions = new List<string>
    {
        //LN - Ask why the experience was meaningful
        "Why was this experience meaningful to you?",

        //LN - Ask if they've done something similar before
        "Have you ever done anything like this before?",

        //LN - Ask how they began the experience
        "How did you get started?",

        //LN - Ask how they felt after completing it
        "How did you feel when it was complete?",

        //LN - Ask what made this situation successful compared to others
        "What made this time different than other times when you were not as successful?",

        //LN - Ask what they liked most about the experience
        "What is your favorite thing about this experience?",

        //LN - Ask what can be learned from the experience
        "What could you learn from this experience that applies to other situations?",

        //LN - Ask what they learned about themselves
        "What did you learn about yourself through this experience?",

        //LN - Ask how they can remember this experience in the future
        "How can you keep this experience in mind in the future?"
    };

    //LN - Constructor sets the name and description by calling the base class constructor
    public ReflectingActivity() : base("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
    }

    //LN - Run method starts the activity, displays a prompt and questions for reflection
    public void Run()
    {
        //LN - Call the base method to initialize activity and set duration
        StartActivity();

        //LN - Create a random generator to select prompts/questions
        Random rand = new Random();

        //LN - Display a random prompt to the user
        Console.WriteLine(_prompts[rand.Next(_prompts.Count)]);

        //LN - Ask the user to prepare and press Enter when ready
        Console.WriteLine("When you have something in mind, press Enter to continue.");

        //LN - Wait for user input before proceeding
        Console.ReadLine();

        //LN - Notify user that questions will begin shortly
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");

        //LN - Countdown before displaying questions
        ShowCountdown(5);

        //LN - Calculate when the activity should end
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        //LN - Loop through questions until the allotted time is over
        while (DateTime.Now < endTime)
        {
            //LN - Select a random reflection question
            string question = _questions[rand.Next(_questions.Count)];

            //LN - Display the selected question
            Console.Write($"> {question} ");

            //LN - Pause with spinner animation to allow user to think
            ShowSpinner(5);
        }

        //LN - Call the base method to end the activity and show closing message
        EndActivity();
    }
}
