using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodShapeDrawing
{
    public class CircleFactory : ShapeFactory
    {
        public override IShape CreateShape()
        {
            return new Circle();
        }
    }
}
