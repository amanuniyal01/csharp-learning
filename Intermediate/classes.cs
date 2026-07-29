
Aman obj = new Aman();
obj.Skills();
Console.WriteLine(obj.age);
Console.WriteLine(obj.name);
public class Aman
{
    public string name = "Uniyal";
    public int age = 20;

    public void Skills()
    {
        Console.WriteLine($"{name} is a software Developer");
    }

}
