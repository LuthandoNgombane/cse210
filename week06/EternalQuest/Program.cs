//LN - Import the necessary namespaces
using System;
using System.Collections.Generic;

class Program
{
    //LN - Entry point of the program
    static void Main(string[] args)
    {
        //LN - Test individual shapes first
        //LN - Create a square object with color "Red" and side length 4
        Square square = new Square("Red", 4);
        //LN - Display the color and area of the square
        Console.WriteLine($"Square - Color: {square.GetColor()}, Area: {square.GetArea()}");

        //LN - Create a rectangle object with color "Blue" and dimensions 3x5
        Rectangle rectangle = new Rectangle("Blue", 3, 5);
        //LN - Display the color and area of the rectangle
        Console.WriteLine($"Rectangle - Color: {rectangle.GetColor()}, Area: {rectangle.GetArea()}");

        //LN - Create a circle object with color "Green" and radius 2
        Circle circle = new Circle("Green", 2);
        //LN - Display the color and area of the circle
        Console.WriteLine($"Circle - Color: {circle.GetColor()}, Area: {circle.GetArea()}");

        //LN - Create a list to store different shapes
        List<Shape> shapes = new List<Shape>();
        //LN - Add a square, rectangle, and circle to the list
        shapes.Add(new Square("Red", 4));
        shapes.Add(new Rectangle("Blue", 3, 5));
        shapes.Add(new Circle("Green", 2));

        //LN - Loop through the list and display the color and area of each shape
        Console.WriteLine("\nAll Shapes:");
        foreach (Shape shape in shapes)
        {
            //LN - Display the color and area for each shape in the list
            Console.WriteLine($"Color: {shape.GetColor()}, Area: {shape.GetArea()}");
        }
    }
}
