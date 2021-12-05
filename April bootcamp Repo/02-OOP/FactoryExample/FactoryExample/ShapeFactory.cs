using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryExample
{
    class ShapeFactory
    {
        public ShapeFactory()
        {

        }

        //Factory Method
        public IShape getShape(string shapeType)
        {
            if (shapeType == "CIRCLE")
            {
                return new Circle();
            }
            else if (shapeType == "RECTANGLE")
            {
                return new Rectangle();
            }
            else if (shapeType == "TRIANGLE")
            {
                return new Triangle();
            }
            else//place all new shapetypes above here
            {
                return null;
            }
        }
    }
}
