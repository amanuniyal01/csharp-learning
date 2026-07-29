// var animals = new List<string>
// {
//     "Lion","Elephant","Dog","Cat"
// };


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