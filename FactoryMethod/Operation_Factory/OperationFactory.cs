using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Operation_Factory
{
    public class OperationFactory
    {
        public static Operacao GetOperation(int op)
        {
            Operacao? operacao;
            switch (op)
            {
                case 1:
                    operacao = new Soma();
                    break;
                case 2:
                    operacao = new Subtracao();
                    break;
                case 3:
                    operacao = new Divisao();
                    break;
                case 4:
                    operacao = new Multiplicacao();
                    break;
                default:
                    operacao = null;
                    break;
            }

            return operacao;
        }
    }
}
