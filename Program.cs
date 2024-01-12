using System;

Console.WriteLine("Welcome to Calculator programm!");
Console.WriteLine("Enter first numbers...");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Enter second Number");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"First number is greater  {a > b}");
System.Console.WriteLine($"First number is less than second {a < b}");
System.Console.WriteLine($"Numbers are equal {a == b}");
System.Console.WriteLine($"There are differnt numbers {a != b}");
System.Console.WriteLine($"first number greater or equal {a >= b}");