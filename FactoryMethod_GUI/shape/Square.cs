using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod_GUI.shape
{
    public class Square : Shape
    {
        public override void draw(Graphics g)
        {
            
            SolidBrush p = new SolidBrush(Color.Blue);
            g.FillRectangle(p, new Rectangle(0, 0, 100, 100));
        }
    }
}
