// Create a Product class with Name, Price, Quantity. Write:

// A constructor with all 3 parameters
// A constructor with just Name and Price that chains to the first, defaulting Quantity to 1
// A parameterless constructor that chains to set Name = "Unknown", Price = 0, Quantity = 0

public class Product
{
    private string Name;
    private decimal Price;
    private int Quantity;

    public Product(string name, decimal price, int quantity)
    {
        Name = name;
        Price = price;
        Quantity = quantity;
    }

    public Product(string name, decimal price) : this(name, price, 1)
    {
    }

    public Product() : this("Unknown", 0, 0)
    {

    }
}