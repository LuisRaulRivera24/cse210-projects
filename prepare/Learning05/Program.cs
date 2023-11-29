using System;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        Square square = new Square("blue", 6);
        Console.WriteLine(square.GetColor());
        Console.WriteLine(square.GetArea());
        Console.WriteLine();

        Rectangle rectangle = new Rectangle("red", 8, 5);
        Console.WriteLine(rectangle.GetColor());
        Console.WriteLine(rectangle.GetArea());
        Console.WriteLine();

        Circle circle = new Circle("orange", 3);
        Console.WriteLine(circle.GetColor());
        Console.WriteLine(circle.GetArea());
        Console.WriteLine();

        List<Shape> shapesList = new List<Shape>();
        shapesList.Add(square);
        shapesList.Add(rectangle);
        shapesList.Add(circle);

        foreach (Shape shape in shapesList)
        {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
        }
    }
}