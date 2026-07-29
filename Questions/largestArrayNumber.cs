// LARGEST NUMBER
// [1,2,3,4]=>4
class Program
{
    public static int LargestNumber(List<int> numbers)
    {
        int largest = numbers[0];
        foreach (int number in numbers)
        {
            if (number > largest)
            {
                largest = number;
            }
        }
        return largest;

    }
    static void Main(string[] args)
    {
        var nums = new List<int> { 1, 2, 3, 4 };

        int result = LargestNumber(nums);
        Console.WriteLine(result);
    }
}