// An interface is a contract. It says "any class that implements me must provide these methods" — but the interface
//  itself provides no actual code, just the promise/signature.


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