//LN - This class is derived from the Activity class. It represents a swimming activity.q
using System;

public class Swimming : Activity
{
    //LN - This property stores the number of laps in the swimming activity.
    //LN - The number of laps is stored as an integer.
    private int _laps;
    private const double METERS_PER_LAP = 50.0;
    private const double MILES_PER_METER = 0.000621371;

    //LN - Constructor to initialize the properties of the Swimming class.
    //LN - The constructor takes a DateTime object, an integer representing minutes, and an integer representing laps as parameters.
    public Swimming(DateTime date, int minutes, int laps) : base(date, minutes)
    {
        _laps = laps;
    }

    //LN - This method is used to get the distance of the swimming activity.
    //LN - The distance is calculated based on the number of laps and the length of each lap.
    public override double GetDistance()
    {
        return _laps * METERS_PER_LAP * MILES_PER_METER;
    }

    //LN - This method is used to get the speed of the swimming activity.
    //LN - The speed is calculated based on the distance and duration of the activity.
    public override double GetSpeed()
    {
        return (GetDistance() / _minutes) * 60.0; 
    }

    //LN - This method is used to get the pace of the swimming activity.
    //LN - The pace is calculated based on the distance and duration of the activity.
    public override double GetPace()
    {
        return _minutes / GetDistance(); 
    }
}