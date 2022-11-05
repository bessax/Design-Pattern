using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Operations;

public class FacadeOk
{
    public string CalculaSoma(double d1, double d2)
    {
        return new Soma().Calcular(d1, d2).ToString();
    }
    public string CalculaSubtracao(double d1, double d2)
    {
        return new Subtracao().Calcular(d1, d2).ToString();
    }
    public string CalculaDivisao(double d1, double d2)
    {
        return new Divisao().Calcular(d1, d2).ToString();
    }
    public string CalculaMultiplicacao(double d1, double d2)
    {
        return new Multiplicacao().Calcular(d1, d2).ToString();
    }

}

