using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodShapeDrawing
{
    public class TriangleFactory : ShapeFactory
    {
        public override IShape CreateShape()
        {
            return new Triangle();
        }
    }
}
