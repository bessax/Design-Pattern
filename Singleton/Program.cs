using Singleton;

Console.WriteLine("Exemplo Singleton");

SecurityManager3 sm1 = SecurityManager3.getInstance();
SecurityManager3 sm2 = SecurityManager3.getInstance();

Console.WriteLine($"Os dois objetos são iguais? {sm1==sm2} " );