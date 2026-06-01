using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodShapeDrawing
{
    public abstract class ShapeFactory
    {
        public abstract IShape CreateShape();
    }
}
