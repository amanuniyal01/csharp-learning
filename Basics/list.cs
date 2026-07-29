// var animals = new List<string>
// {
//     "Lion","Elephant","Dog","Cat"
// };


using System.ComponentModel;

List<string> animals = ["Lion", "Elephant", "Dog"];
foreach (var animal in animals)
{
    Console.WriteLine($"{animal.ToUpper()}");
}
animals.Add("Maria");
animals.Add("Bill");
animals.Remove("Dog");
foreach (var name in animals)
{
    Console.WriteLine($"Hello {name.ToUpper()}!");
}

//  FIBONACCI
List<int> fibonacci = [1, 1];
var previous = fibonacci[fibonacci.Count - 1];
var previous2 = fibonacci[fibonacci.Count - 2];
fibonacci.Add(previous + previous2);

foreach (var item in fibonacci)
{
    Console.WriteLine(item);
}