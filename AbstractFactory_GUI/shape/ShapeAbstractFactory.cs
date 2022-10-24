using AbstractFactory_GUI.shape;

namespace AbstractFactory_GUI.shape
{
    public abstract class ShapeAbstractFactory
    {
       public abstract Shape NewShape(string type);
    }
}
