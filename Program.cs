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
// logical operations in ternary 
// logical operators   &&   ||   !(bla bla bla)
string message =
    firstValue >= 0 && secondValue >= 0
    ? "First and second Numbers are positive !"
    : "First and second Number are negative";
Console.WriteLine(message);

string messag =
    firstValue >= 0 || secondValue >= 0
    ? "First or second Number is positive !"
    : "First and second Numbers are negative";
Console.WriteLine(messag);

string messa =
    !(firstValue >= 0)
    ? "First Number is Negative !"
    : "First Number is Positive";
Console.WriteLine(messa);

