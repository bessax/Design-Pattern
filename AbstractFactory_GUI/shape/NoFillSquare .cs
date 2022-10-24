using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory_GUI.shape
{
    public class NoFillSquare : Shape
    {
        public override void draw(Graphics g)
        {
            
            Pen p = new Pen(Color.Blue);
            g.DrawRectangle(p, new Rectangle(0, 0, 100, 100));
        }
    }
}
