// REVERSE A STRING WITHOUT USING REVERSE.
// "aman"=>"nama"

class Program
{
    public static string Reverse(string s)
    {
        string rev = "";
        foreach (char value in s)
        {
            rev = value + rev;
        }
        return rev;
    }

    static void Main(string[] args)
    {
        Console.WriteLine(Reverse("aman"));
    }
}