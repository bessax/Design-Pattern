
using Facade.Operations;

Console.WriteLine("Facade");

FacadeOk facade = new FacadeOk();

Console.WriteLine(facade.CalculaSoma(15,30));
Console.WriteLine(facade.CalculaDivisao(15, 2));
Console.WriteLine(facade.CalculaMultiplicacao(2, 30));
Console.WriteLine(facade.CalculaSubtracao(150, 30));
