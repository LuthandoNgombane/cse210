//LN - Define the Square class, inheriting from the Shape class
public class Square : Shape
{
    //LN - Private field to store the side length of the square
    private double _side;

    //LN - Constructor to initialize the square with a color and side length
    public Square(string color, double side) : base(color)
    {
        //LN - Set the side length for the square instance
        _side = side;
    }

    //LN - Override the GetArea method to return the area of the square
    public override double GetArea()
    {
        //LN - Calculate and return the area of the square (side²)
        return _side * _side; // Area = side²
    }
}
