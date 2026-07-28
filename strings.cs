// ------------------------STRINGS ARE IMMUTABLE------------------

string friend1 = "Aman";
string friend2 = "Anurag";
// Console.WriteLine(hello + " " + aFriend);

Console.WriteLine($"Hello {friend2.Length} Myself {friend1}"); //C# does not provide backticks conditioning like Javascript and TypeScript.

// string greeting = "      Hello World!       ";
// Console.WriteLine($"[{greeting}]");

// string trimmedGreeting = greeting.TrimStart();
// Console.WriteLine($"[{trimmedGreeting}]");

// trimmedGreeting = greeting.TrimEnd();
// Console.WriteLine($"[{trimmedGreeting}]");

// trimmedGreeting = greeting.Trim();
// Console.WriteLine($"[{trimmedGreeting}]");

string greeting = "Hello\nAman"; //Aman will be on new line..
Console.WriteLine(greeting);
string replaced = greeting.Replace("Hello", "Hyy");
Console.WriteLine(replaced);


string columns = "Column 1\tColumn 2\tColumn 3"; //Output: Column 1        Column 2        Column 3
string rows = "Row 1\r\nRow 2\r\nRow 3";