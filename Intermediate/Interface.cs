// An interface is a contract. It says "any class that implements me must provide these methods" — but the interface
//  itself provides no actual code, just the promise/signature.
// conventionally starts with I.


using System;
class Program
{
    static void Main(string[] args)
    {
        Dog obj1 = new Dog();
        obj1.MakeSound();
    }
}
public interface IAnimal
{
    void MakeSound();

}

public class Dog : IAnimal
{
    public void MakeSound()
    {
        Console.WriteLine("Woof");
    }
}


// Interface
interface ILogger
{
    void Log(string message);
    string Name { get; }
}

public class ConsoleLogger : ILogger
{
    public string Name => "Console";
    public void Log(string message) =>
        Console.WriteLine($"[{Name}] {message}");

}