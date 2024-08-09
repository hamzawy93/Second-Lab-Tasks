// See https://aka.ms/new-console-template for more information

for (int num = 2; num <= 500; num++)
{
    bool isPrime = true;

    for (int i = 2; i <= Math.Sqrt(num); i++)
    {
        if (num % i == 0)
        {
            isPrime = false;
            break;
        }
    }

    if (isPrime)
    {
        Console.WriteLine(num); 
    }
     }