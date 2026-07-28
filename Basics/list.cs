var animals = new List<string>
{
    "Lion","Elephant","Dog","Cat"
};

foreach (var animal in animals)
{
    Console.WriteLine($"{animal.ToUpper()}");
}