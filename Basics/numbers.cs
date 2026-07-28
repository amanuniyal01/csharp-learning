// int a = 30;
// int b = 20;
// int c = a + b;
// Console.WriteLine($"Addition of {a} and {b} is : {c}");

// long a1 = 100000000000000000;
// long b1 = 200000000000000000;
// long c1 = a1 + b1;   // Int type only supports upto 32 bit so we will use long for this..
// Console.WriteLine($"Addition of {a1} and {b1} is : {c1}");


// BY DEFAULT DECIMAL NUMBERS - FLOAT AND WHOLE NUMBERS - INT.

int max = int.MaxValue;
int min = int.MinValue;
Console.WriteLine($"The range of integers is {min} to {max}");

// OVERFLOW
int what = max + 3; //Overflow Wrapping
int what2 = min - 3; //Underflow Wrapping
Console.WriteLine($"An example of overflow: {what}");
Console.WriteLine($"An example of overflow: {what2}");

// Double type
double a = 19;
double b = 23;
double c = 8;
double d = (a + b) / c;
Console.WriteLine(d);

// DECIMAL => Precise than double.
decimal x = 1.0M; //M is to tell the compiler that its of decimal type otherwise by default it will treat as double
decimal y = 3.0M;
Console.WriteLine(x / y);