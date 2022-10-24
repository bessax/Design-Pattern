using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod_GUI.shape
{
    public class ShapeFactory
    {
		public static Shape NewShape(int i)
		{
			if (i == 1)
			{
				return new Circle();
			}
			else if (i == 2)
			{
				return new Square();
			}
			else
			{
				return null;
			}
		}

	}
}
