//LN - This class is the base class for all activities. It contains properties and methods that are common to all activities.
using System;

public class Activity
{

    //LN - These are the properties of the Activity class. They are used to store the date and duration of the activity.
    //LN - The date is stored as a DateTime object and the duration is stored as an integer representing minutes.
    private DateTime _date;
    public int _minutes;

    //LN - Constructor to initialize the properties of the Activity class.
    //LN - The constructor takes a DateTime object and an integer as parameters.
    public Activity(DateTime date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    //LN - These are the properties of the Activity class. They are used to get the date and duration of the activity.
    //LN - The date is stored as a DateTime object and the duration is stored as an integer representing minutes.
    public virtual double GetDistance()
    {
        return 0;
    }

    //LN - This method is used to get the speed of the activity. It is a virtual method that can be overridden in derived classes.
    //LN - The speed is calculated based on the distance and duration of the activity.
    public virtual double GetSpeed()
    {
        return 0; 
    }

    //LN - This method is used to get the pace of the activity. It is a virtual method that can be overridden in derived classes.
    //LN - The pace is calculated based on the distance and duration of the activity.
    public virtual double GetPace()
    {
        return 0;
    }

    //LN - This method is used to get the date of the activity. It is a read-only property.
    //LN - The date is stored as a DateTime object.
    public virtual string GetSummary()
    {
        string dateStr = _date.ToString("dd MMM yyyy");
        return $"{dateStr} {GetType().Name} ({_minutes} min) - Distance: {GetDistance():F1} miles, Speed: {GetSpeed():F1} mph, Pace: {GetPace():F1} min per mile";
    }
}