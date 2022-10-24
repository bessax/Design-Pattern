


namespace AbstractFactory_GUI.shape
{
    public class FillShapeFactory : ShapeAbstractFactory
    {
        public override Shape NewShape(string type)
        {
            if (type.Equals("circle"))
            {
                return new Circle();
            }
            else if(type.Equals("square"))
            {
                return new Square();
            }
            return null;
        }
    }
}
