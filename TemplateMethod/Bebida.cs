using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public abstract class Bebida
    {
        public void Preparar()
        {
            AdicionarAgua();
            AdicionarSubstancia();
            if(colocarAcucar())
            {
               AdicionarAcucar();      
            }
            Mexer();
        }

        public abstract void Mexer();
        public abstract void AdicionarAcucar();
        public abstract bool colocarAcucar();
        public abstract void AdicionarSubstancia();
        public abstract void AdicionarAgua();
      
    }
}
