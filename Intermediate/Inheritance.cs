// Inheritance lets one class (child/derived class) reuse the fields, properties,
//  and methods of another class (parent/base class) — without rewriting that code.
using System;
class Program
{
    static void Main(string[] args)
    {
        Animal obj1 = new Animal("Lion", "Orange");
        Cat obj2 = new Cat("Cat", "pink", true);

        Console.WriteLine($"{obj1.Name} {obj1.color}");
        Console.WriteLine($"{obj2.Name} {obj2.color} {obj2.isDomestic}");
    }
}

public class Animal
{
    public string Name;
    public string color;

    public Animal(string n, string c)
    {
        Name = n;
        color = c;
    }

}
public class Cat : Animal
{
    public bool isDomestic;

    public Cat(string n, string c, bool domestic) : base(n, c)
    {
        isDomestic = domestic;
    }
}