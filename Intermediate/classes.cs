

// Newer way of calling an object..
// Aman obj = new Aman();
// obj.Skills();
// Console.WriteLine(obj.age);
// Console.WriteLine(obj.name);

// public class Aman
// {
//     public string name = "Uniyal";
//     public int age = 20;

//     public void Skills()
//     {
//         Console.WriteLine($"{name} is a software Developer");
//     }

// }

// Older Way
// ALway remember to create classes in Capital letter (starting word)

using System;
class Program
{
    static void Main(string[] args)
    {
        Aman obj = new Aman();
        obj.Skills();
        Console.WriteLine(obj.age);
        Console.WriteLine(obj.name);
    }
}
public class Aman
{
    public string name = "Uniyal";
    public int age = 20;

    public void Skills()
    {
        Console.WriteLine($"{name} is a software Developer");
    }
}

