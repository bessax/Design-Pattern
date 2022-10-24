using FactoryMethod.Operation_Factory;

Console.WriteLine("Exemplo Factory Method - Fábrica de Objetos");

Console.Write("Informa 1º número: ");
double n1 = double.Parse(Console.ReadLine());

Console.Write("Informa 2º número: ");
double n2 = double.Parse(Console.ReadLine());

Console.Write("Informe o tipo de operação: ");
int op = int.Parse(Console.ReadLine());

Console.WriteLine("========================");
Operacao operation = OperationFactory.GetOperation(op);
Console.WriteLine($"Resultado: {operation.Calcular(n1,n2)}"); 