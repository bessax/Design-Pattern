using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory_GUI.shape
{
    public class NoFillCircle : Shape
    {
        public override void draw(Graphics g)
        {
        
            Pen p = new Pen(Color.Red);
            g.DrawEllipse(p, new Rectangle(0, 0, 50, 50));           
        }
    }
}
