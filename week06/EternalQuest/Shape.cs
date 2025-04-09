//LN - Define the Shape class as the base class for geometric shapes
public class Shape
{
    //LN - Private field to store the color of the shape
    private string _color;

    //LN - Constructor to initialize the shape with a color
    public Shape(string color)
    {
        _color = color; 
    }

    //LN - Getter method to retrieve the color of the shape
    public string GetColor()
    {
        return _color;
    }

    //LN - Setter method to modify the color of the shape
    public void SetColor(string color)
    {
        _color = color; 
    }

    //LN - Virtual method to get the area of the shape, can be overridden by derived classes
    //LN - This method is intentionally left empty and should be overridden in derived classes
    //LN - It returns 0 by default, indicating that the area is not defined for the base class
    public virtual double GetArea()
    {
        return 0; 
    }
}
