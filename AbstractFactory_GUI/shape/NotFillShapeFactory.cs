

namespace AbstractFactory_GUI.shape
{
    public class NotFillShapeFactory:ShapeAbstractFactory
    {
        public override Shape NewShape(string type)
        {
            if (type.Equals("circle"))
            {
                return new NoFillCircle();
            }
            else if (type.Equals("square"))
            {
                return new NoFillSquare();
            }
            return null;
        }
    }
}
