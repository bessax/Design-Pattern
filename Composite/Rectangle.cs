using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class Rectangle : ISceneObject
    {
        public void draw()
        {
            Console.WriteLine("Drawing rectangle...");
        }
    }
}
