//LN - Define the Rectangle class, inheriting from the Shape class
public class Rectangle : Shape
{
    //LN - Private field to store the width of the rectangle
    private double _width;

    //LN - Private field to store the height of the rectangle
    private double _height;

    //LN - Constructor to initialize the rectangle with a color, width, and height
    public Rectangle(string color, double width, double height) : base(color)
    {
        //LN - Set the width for the rectangle instance
        _width = width;

        //LN - Set the height for the rectangle instance
        _height = height;
    }

    //LN - Override the GetArea method to return the area of the rectangle
    public override double GetArea()
    {
        //LN - Calculate and return the area of the rectangle (width * height)
        return _width * _height; // Area = width * height
    }
}
