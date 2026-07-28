// While
int counter = 0;
while (counter < 10)
{
    Console.WriteLine($"Hey I am called {counter} time.");
    counter++;
}

// Do while 
int num = 0;
do
{
    Console.WriteLine($"Hey I am called {num} time.");
    num++;
}
while (num < 10);

// Find the sum of all integers 1 through 20 that are divisible by 3
int sum = 0;
for (int i = 1; i < 21; i++)
{
    if (i % 3 == 0)
    {
        sum += i;
    }

}
Console.WriteLine($"Sum is {sum}");

// Reverse a integer
int original = 12345;
int temp = original;
int reverse = 0;

while (temp > 0)
{
    int rem = temp % 10;
    reverse = reverse * 10 + rem;
    temp = temp / 10;
}

Console.WriteLine($"Reverse of {original} is {reverse}");