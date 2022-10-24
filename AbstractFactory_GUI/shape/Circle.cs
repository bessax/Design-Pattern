using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory_GUI.shape
{
    public class Circle : Shape
    {
        public override void draw(Graphics g)
        {
        
            SolidBrush p = new SolidBrush(Color.Red);
            g.FillEllipse(p, new Rectangle(0, 0, 50, 50));           
        }
    }
}
