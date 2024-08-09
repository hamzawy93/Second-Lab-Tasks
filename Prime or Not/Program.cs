// See https://aka.ms/new-console-template for more informationfor (int i = 2; i <= Math.Sqrt(num); i++)
Console.WriteLine("Enter any number ");
int num = int.Parse(Console.ReadLine());
if (num < 0)
{
    Console.WriteLine("The number is Not prime");
}
for (int i = 2; i <= Math.Sqrt(num); i++)
{
    if (num % i == 0)
    {
        Console.WriteLine("The number is not prime");
}
    if (num % i !=0) 
    { Console.WriteLine("The Number is prime");
    }
}

