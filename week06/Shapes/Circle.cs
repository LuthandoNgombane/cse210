//LN - Define the Circle class, inheriting from the Shape class
public class Circle : Shape
{
    //LN - Private field to store the radius of the circle
    private double _radius;

    //LN - Constructor to initialize the circle with a color and radius
    public Circle(string color, double radius) : base(color)
    {
        //LN - Set the radius for the circle instance
        _radius = radius;
    }

    //LN - Override the GetArea method to return the area of the circle
    public override double GetArea()
    {
        //LN - Calculate and return the area of the circle (π * radius²)
        return Math.PI * _radius * _radius; // Area = π * radius²
    }
}
