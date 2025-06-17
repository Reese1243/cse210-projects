using System;

class Program
{
    static void Main(string[] args)
    {

        Square box = new Square("red", 5.00);
        Rectangle rect = new Rectangle("blue", 8, 4);
        Circle circ = new Circle("purple", 6);

        List<Shape> shapes = new List<Shape>();
        shapes.Add(circ);
        shapes.Add(rect);
        shapes.Add(box);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
        }
    }
}