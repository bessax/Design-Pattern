using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Operations;

public class Subtracao : Operacao
{
    public override double Calcular(double d1, double d2)
    {
        return d1 - d2;
    }
}
