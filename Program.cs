using System;

string parol = "";
do
{
System.Console.WriteLine("Enter password to Run \"123\" ");
parol = Console.ReadLine();
}
while (parol != "123");

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

// string messa =
//     !(firstValue >= 0)
//     ? "First Number is not Positive !"
//     : "First Number is not Negative !";
// Console.WriteLine(messa);

//switch

Console.WriteLine("To use Calculator enter operation (+,-,*,/,%): ");
string operation = Console.ReadLine();
switch(operation)
{
    case "+":
        Console.WriteLine($"Adding {firstValue} + {secondValue} = {firstValue + secondValue}");
        break;
    case "-":
        Console.WriteLine($"Minus {firstValue} - {secondValue} = {firstValue - secondValue}");
        break;
    case "/":
        Console.Write($"Dividing {firstValue} / {secondValue} = {firstValue / secondValue} ");
        Console.WriteLine($"Residue is {firstValue % secondValue} ");
        break; 
    case "*":
        Console.WriteLine($"Multiplying {firstValue} * {secondValue} = {firstValue * secondValue}");
        break;   

    default:
        Console.WriteLine("Operation Not Found!");   
        break;
}

// switch expression
string result = operation switch
{
    "+" => $"Adding {firstValue} + {secondValue} = {firstValue + secondValue}",
    "/" => $"Dividing {firstValue} / {secondValue} = {firstValue / secondValue} Residue is {firstValue % secondValue}",
    "-" => $"Minus {firstValue} - {secondValue} = {firstValue - secondValue}",
    "*" => $"Multipliying {firstValue} * {secondValue} = {firstValue * secondValue}",
    _   => "Operation Not Found!"
};
System.Console.WriteLine(result);
System.Console.Read();

//if (firstValue>0)
//{
    int counter = 0;
    while (counter < firstValue)
    {
    System.Console.WriteLine(counter);
    counter++;
    }
    
//}

int sonlar = 2;
while (sonlar <= 100)
{
    System.Console.WriteLine(sonlar);
    sonlar = sonlar +2 ;
}


