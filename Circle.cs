using FactoryMethodShapeDrawing;
using System;

public class Circle : IShape
{
    public void Draw()
    {
        Console.WriteLine("Drawing Circle");
    }
}