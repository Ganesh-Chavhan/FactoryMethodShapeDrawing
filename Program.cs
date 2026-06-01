using FactoryMethodShapeDrawing;
using System;

class Program
{
    static void Main(string[] args)
    {
        ShapeFactory circleFactory = new CircleFactory();

        IShape circle = circleFactory.CreateShape();

        circle.Draw();

        ShapeFactory rectangleFactory = new RectangleFactory();

        IShape rectangle = rectangleFactory.CreateShape();

        rectangle.Draw();

        ShapeFactory triangleFactory = new TriangleFactory();

        IShape triangle = triangleFactory.CreateShape();

        triangle.Draw();
    }
}