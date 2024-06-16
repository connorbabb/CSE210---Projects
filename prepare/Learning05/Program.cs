using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        shapes.Add(new Square("red", 3));
        shapes.Add(new Rectangle("blue", 3, 9));
        shapes.Add(new Circle("green", 4));

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            float area = shape.GetArea();
            Console.WriteLine($"The color is {color} and the area is {area}");
        }
    }
}