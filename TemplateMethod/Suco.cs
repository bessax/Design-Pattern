using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public class Suco : Bebida
    {
        public override void AdicionarAcucar()
        {
            Console.WriteLine("Adicionando açucar ao suco!");
        }

        public override void AdicionarAgua()
        {
            Console.WriteLine("Adicionando água ao suco!");
        }

        public override void AdicionarSubstancia()
        {
            Console.WriteLine("Adicionando Substância ao suco!");
        }

        public override bool colocarAcucar()
        {
            return true;
        }

        public override void Mexer()
        {
            Console.WriteLine("Mexendo o suco...!");
        }
    }
}
