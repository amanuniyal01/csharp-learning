
using System;
static void Main(string[] args)
{
    IsPalindrome(121);
}
// PRIME NUMBER
int a = 10;

if (a % 1 == 0 && a % 10 == 0)
{
    Console.WriteLine("Its a Prime Number");
}
else
{
    Console.WriteLine("Not");
}

// 121 -121 PALINDROME
static bool IsPalindrome(int digit)
{
    var original = digit;
    int reverse = 0;

    while (digit > 0)
    {
        int rem = digit % 10;
        reverse = reverse * 10 + rem;
        digit /= 10;
    }
    return original == reverse ? true : false;
}

