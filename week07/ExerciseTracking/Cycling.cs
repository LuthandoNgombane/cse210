//LN - This class is derived from the Activity class. It represents a cycling activity.
//LN - The class contains properties and methods specific to cycling activities.
using System;

public class Cycling : Activity
{
    //LN - This property stores the speed of the cycling activity in miles per hour.
    //LN - The speed is stored as a double representing miles per hour.
    private double _speed; 

    //LN - Constructor to initialize the properties of the Cycling class.
    //LN - The constructor takes a DateTime object, an integer representing minutes, and a double representing speed as parameters.
    public Cycling(DateTime date, int minutes, double speed) : base(date, minutes)
    {
        _speed = speed;
    }

    //LN - This method is used to get the distance of the cycling activity.
    //LN - The distance is calculated based on the speed and duration of the activity.
    public override double GetDistance()
    {
        return (_speed * _minutes) / 60.0; 
    }

    //LN - This method is used to get the speed of the cycling activity.
    //LN - The speed is stored as a double representing miles per hour.
    public override double GetSpeed()
    {
        return _speed;
    }

    //LN - This method is used to get the pace of the cycling activity.
    //LN - The pace is calculated based on the speed of the activity.
    public override double GetPace()
    {
        return 60.0 / _speed; 
    }
}