// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

SPE.Test.Run();


AFPE.AbstractFactory factory1 = new AFPE.ConcreteFactory1();
AFPE.Client client1 = new AFPE.Client(factory1);
client1.Run();

AFPE.AbstractFactory factory2 = new AFPE.ConcreteFactory2();
AFPE.Client client2 = new AFPE.Client(factory2);
client2.Run();