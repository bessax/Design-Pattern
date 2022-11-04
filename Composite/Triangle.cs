using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class Triangle : ISceneObject
    {
        public void draw()
        {
            Console.WriteLine("Drawing triangle...");
        }
    }
}
