using System;

 Console.WriteLine("Welcome to Calculator programm!");
 Console.WriteLine(" Enter the first number...");
int firstValue;
    if (int.TryParse(Console.ReadLine(), out firstValue))
    {
    }
    else
    {
        Console.WriteLine("Invalid format! Please enter a valid integer.");
        return;
    }

Console.WriteLine("Enter second Number");
int secondValue;
    if (int.TryParse(Console.ReadLine(), out secondValue))
    {
    }
    else
    {
        Console.WriteLine("Invalid format! Please enter a valid integer.");
        return;
    }

if (firstValue > secondValue)
    {
        Console.WriteLine("First Number is greater !");
    }
else if (firstValue == secondValue)
    {
        Console.WriteLine("Numbers are equal !");
    }
else
    {
        Console.WriteLine("Second Number is greater !");
    }

string message =
    firstValue > 0
    ? "First Value is positive !"
    : "First Value is negative";
Console.WriteLine(message);

