//LN - Import System namespace to access DateTime and console functionality
using System;

//LN - Define the BreathingActivity class, which inherits from the base Activity class
public class BreathingActivity : Activity
{
    //LN - Constructor for BreathingActivity that sets its name and description
    public BreathingActivity() : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    //LN - Run starts the breathing activity and manages the timed breathing loop
    public void Run()
    {
        //LN - Call the StartActivity method from the base class to initialize
        StartActivity();

        //LN - Calculate the time at which the session should end
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        //LN - Loop until the current time reaches the end time
        while (DateTime.Now < endTime)
        {
            //LN - Prompt user to breathe in and start a 4-second countdown
            Console.Write("Breathe in...");
            ShowCountdown(4);

            //LN - Break the loop if time has already expired after inhale
            if (DateTime.Now >= endTime) break;

            //LN - Prompt user to breathe out and start another 4-second countdown
            Console.Write("Breathe out...");
            ShowCountdown(4);
        }

        //LN - Call the EndActivity method from the base class to wrap up the session
        EndActivity();
    }
}
