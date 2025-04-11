//LN - This class is derived from the Activity class. It represents a running activity.
//LN - The class contains properties and methods specific to running activities.
using System;

public class Running : Activity
{

    //LN - This property stores the distance of the running activity in miles.
    private double _distance; 

    //LN - Constructor to initialize the properties of the Running class.
    //LN - The constructor takes a DateTime object, an integer representing minutes, and a double representing distance as parameters.
    public Running(DateTime date, int minutes, double distance) : base(date, minutes)
    {
        _distance = distance;
    }

    //LN - This method is used to get the distance of the running activity.
    //LN - The distance is stored as a double representing miles.
    public override double GetDistance()
    {
        return _distance;
    }

    //LN - This method is used to get the speed of the running activity.
    //LN - The speed is calculated based on the distance and duration of the activity.
    public override double GetSpeed()
    {
        return (_distance / (double)_minutes) * 60; 
    }

    //LN - This method is used to get the pace of the running activity.
    //LN - The pace is calculated based on the distance and duration of the activity.
    public override double GetPace()
    {
        return _minutes / _distance;
    }
}