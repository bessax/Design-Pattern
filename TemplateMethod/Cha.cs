using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public class Cha : Bebida
    {
        public override void AdicionarAcucar()
        {
            Console.WriteLine("Adicionar açucar ao Chá!");
        }

        public override void AdicionarAgua()
        {
            Console.WriteLine("Adicionar água ao Chá!");
        }

        public override void AdicionarSubstancia()
        {
            Console.WriteLine("Adicionar substância ao Chá!");
        }

        public override bool colocarAcucar()
        {
            return false;
        }

        public override void Mexer()
        {
            Console.WriteLine("Mexendo o Chá!");
        }
    }
}
