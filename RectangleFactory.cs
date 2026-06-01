using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodShapeDrawing
{
    public class RectangleFactory : ShapeFactory
    {
        public override IShape CreateShape()
        {
            return new Rectangle();
        }
    }
}
