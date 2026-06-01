using FactoryMethodShapeDrawing;
using System;

public class Triangle : IShape
{
    public void Draw()
    {
        Console.WriteLine("Drawing Triangle");
    }
}