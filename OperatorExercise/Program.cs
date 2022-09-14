


Console.WriteLine("Enter the first number: ");
var a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the second number: ");
var b = Convert.ToInt32(Console.ReadLine());
int quotient = a / b;
int remainder = a % b;

Console.WriteLine($"{a}/{b} is {quotient} remainder of {remainder}");