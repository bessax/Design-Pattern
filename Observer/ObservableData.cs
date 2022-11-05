using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class ObservableData:Observable
    {
        private Object data;

        public void SetData(Object myData)
        {
            this.data = myData;
            this.NotifyObserver();
        }

        public Object GetData()
        {
            return this.data;
        }
    }
}
