using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Operations;

public class Divisao : Operacao
{
    public override double Calcular(double d1, double d2)
    {
        if (d1==0)
        {
            throw new DivideByZeroException("Erro de divisão por zero.");
        }
        return d1/d2;
    }
}
