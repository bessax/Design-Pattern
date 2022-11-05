using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class TemperatureObjectAdapter
    {
        private Temperature temperature ;
        public TemperatureObjectAdapter(Temperature tempe)
        {
          this.temperature = tempe;
        }

        public double GetValue()
        {
          return(this.temperature.GetValue()-32)*5/9;
        }

        public void SetValue(double value)
        {
           this.temperature.SetValue(value*9/5+32);
        }
    }
}
