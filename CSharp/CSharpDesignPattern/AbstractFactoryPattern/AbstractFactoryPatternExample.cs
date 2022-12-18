/// <summary>
/// The Abstract Factory Pattern is a creational design pattern that provides an interface for creating related objects without specifying their concrete classes. It allows for the creation of families of related objects without having to specify their concrete classes. The Abstract Factory Pattern is used to create a set of related objects, or dependent objects, without specifying their concrete classes. This pattern is especially useful when a system must be independent of how its objects are created, composed, and represented. 
/// The Abstract Factory Pattern defines an interface for creating a family of related objects, and then provides implementations of the interface that create objects of a particular type. This pattern allows a client to create objects without knowing the exact class of the object that will be created. This allows the client to create objects that are related, but not necessarily of the same type. 
/// The Abstract Factory Pattern is a great way to ensure that a system is loosely coupled and easily extensible. It also allows for the creation of objects that are interchangeable and can be used in different contexts. This pattern is also useful for creating objects that have a complex set of dependencies.
/// </summary>

namespace AFPE;

public abstract class AbstractFactory
{
    public abstract ProductA CreateProductA();
    public abstract ProductB CreateProductB();
}

public class ConcreteFactory1 : AbstractFactory
{
    public override ProductA CreateProductA()
    {
        return new ProductA1();
    }

    public override ProductB CreateProductB()
    {
        return new ProductB1();
    }
}

public class ConcreteFactory2 : AbstractFactory
{
    public override ProductA CreateProductA()
    {
        return new ProductA2();
    }

    public override ProductB CreateProductB()
    {
        return new ProductB2();
    }
}

public abstract class ProductA
{
    public abstract void OperationA();
}

public class ProductA1 : ProductA
{
    public override void OperationA()
    {
        Console.WriteLine("ProductA1 OperationA");
    }
}

public class ProductA2 : ProductA
{
    public override void OperationA()
    {
        Console.WriteLine("ProductA2 OperationA");
    }
}

public abstract class ProductB
{
    public abstract void OperationB();
}

public class ProductB1 : ProductB
{
    public override void OperationB()
    {
        Console.WriteLine("ProductB1 OperationB");
    }
}

public class ProductB2 : ProductB
{
    public override void OperationB()
    {
        Console.WriteLine("ProductB2 OperationB");
    }
}

public class Client
{
    private ProductA _productA;
    private ProductB _productB;

    public Client(AbstractFactory factory)
    {
        _productA = factory.CreateProductA();
        _productB = factory.CreateProductB();
    }

    public void Run()
    {
        _productA.OperationA();
        _productB.OperationB();
    }
}

// public class Program
// {
//     static void Main(string[] args)
//     {
//         AbstractFactory factory1 = new ConcreteFactory1();
//         Client client1 = new Client(factory1);
//         client1.Run();

//         AbstractFactory factory2 = new ConcreteFactory2();
//         Client client2 = new Client(factory2);
//         client2.Run();

//         Console.ReadKey();
//     }
// }