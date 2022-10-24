using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory_GUI.shape
{
    public class ShapeFactoryProducer
    {
        public static ShapeAbstractFactory GetFactory(bool fill)
        {
            if (fill)
            {
                return new FillShapeFactory();
            }
            else
            {
                return new NotFillShapeFactory();
            }
        }
    }
}
