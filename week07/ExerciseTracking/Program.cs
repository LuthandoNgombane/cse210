using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //LN - Create a list of activities
        //LN - Each activity is an instance of a derived class (Running, Cycling, Swimming)
        List<Activity> activities = new List<Activity>
        {
            new Running(new DateTime(2022, 11, 3), 30, 3.0),    
            new Cycling(new DateTime(2022, 11, 3), 45, 12.0),    
            new Swimming(new DateTime(2022, 11, 3), 20, 20)      
        };

        //LN - Print the summary of each activity
        //LN - The summary includes the date, type of activity, duration, distance, speed, and pace
        Console.WriteLine("Exercise Tracking Summary:");
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}