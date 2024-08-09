// See https://aka.ms/new-console-template for more information
int[] arr =  { 2, 4, 7, 12, 36, 14, 24, 57, 86, 432 };
int mn = arr[0];
int max = arr[0];
for (int i = 1; i < arr.Length ; i++)
{
    if (arr[i] < mn)
    { mn = arr[i]; }
    else if (arr[i] > max) { max = arr[i]; }
    
    }
Console.WriteLine("Minimum is " + mn);
Console.WriteLine("Maximum is "+ max);

