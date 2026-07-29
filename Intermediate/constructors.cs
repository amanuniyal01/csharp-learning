// A constructor is a special method that is used to initialize objects.
// Name of a constructor method is same name as class. like if class Name is Car so constructor will be of Car name.
// It doesn't return any value..
//  Every class should have a constructor if we are making instance of it. Let's say if we don't make constructor in class so by default
// an implicit constructor gets defined in the class by the compiler..


using System;
class Program
{
    static void Main(string[] args)
    {
        Car obj1 = new Car("Fortuner", "2026");
        Car obj2 = new Car("Scorpio", "2024");

        Console.WriteLine($"{obj1.name} {obj1.modal}");
        Console.WriteLine($"{obj2.name} {obj2.modal}");
    }
}

// Constructors
public class Aman
{
    public string name;
    public int age;

    // This is a constructor
    public Aman()
    {
        name = "Uniyal";
        age = 20;
        Console.WriteLine("Object created!");
    }
}

// PARAMETERIZED CONSTRUCTOR.
public class Car
{
    public string name;
    public string modal;

    public Car(string n, string m)
    {
        name = n;
        modal = m;
    }
}

