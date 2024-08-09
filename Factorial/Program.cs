// See https://aka.ms/new-console-template for more information
using static System.Runtime.InteropServices.JavaScript.JSType;

Console.WriteLine("Please enter your number");
int num =int.Parse (Console.ReadLine());
int factorial = 1;

for (int i = 1; i <= num; i++)
{
    factorial *= i;
}
Console.WriteLine("The factorial of number is "+factorial);



