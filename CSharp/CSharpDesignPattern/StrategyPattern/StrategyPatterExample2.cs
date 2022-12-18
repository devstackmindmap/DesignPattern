
/// <summary>
/// The strategy pattern is a behavioral design pattern that enables an algorithm's behavior to be selected at runtime. It defines a family of algorithms, encapsulates each algorithm, and makes the algorithms interchangeable within that family. The strategy pattern allows the algorithm to vary independently from clients that use it.
/// The strategy pattern is used when you need to define a set of related algorithms and select one of them to use at runtime. This pattern is useful when you have a set of related algorithms that need to be interchan//geable. For example, if you have a set of sorting algorithms, you can use the strategy pattern to select the appropriate algorithm to use for a particular task.
/// The strategy pattern consists of four main components: a context, a strategy interface, concrete strategies, and a client. The context is the object that will use the strategy. The strategy interface defines the operations that the strategies must implement. The concrete strategies are the actual implementations of the strategy interface. The client is the code that uses the strategy.
/// The strategy pattern is a powerful tool for designing flexible and extensible applications. It enables you to easily switch between different algorithms at runtime, making your code more flexible and maintainable.
/// </summary>

namespace SPE2;

// Define common operations as interfaces
public interface IStrategy
{
    void Execute();
}

// Implement interfaces as real algorithms
public class ConcreteStrategyA : IStrategy
{
    public void Execute()
    {
        Console.WriteLine("ConcreteStrategyA");
    }
}

// Implement interfaces as real algorithms
public class ConcreteStrategyB : IStrategy
{
    public void Execute()
    {
        Console.WriteLine("ConcreteStrategyB");
    }
}

// manage references to objects
// Materialized by having an instance of the Strategy subclass
// Defines the interfaces that objects need to access data
public class Context<TStrategy> where TStrategy : IStrategy
{
    private TStrategy _strategy;

    public Context(TStrategy strategy)
    {
        this._strategy = strategy;
    }

    public void ExecuteStrategy()
    {
        _strategy.Execute();
    }
}

public static class Test
{
    public static void Run()
    {
        // Usage
        var context = new Context<ConcreteStrategyA>(new ConcreteStrategyA());
        context.ExecuteStrategy();
    }
}