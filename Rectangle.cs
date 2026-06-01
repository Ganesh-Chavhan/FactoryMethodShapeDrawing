using FactoryMethodShapeDrawing;
using System;

public class Rectangle : IShape
{
    public void Draw()
    {
        Console.WriteLine("Drawing Rectangle");
    }
}