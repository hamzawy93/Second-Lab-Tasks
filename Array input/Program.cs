// See https://aka.ms/new-console-template for more information
int[] Inputs = new int[5];
for (int i = 0; i < Inputs.Length; i++)
{
    Console.WriteLine("Please Enter A Number ");
        Inputs[i]=int.Parse(Console.ReadLine());

}
int print = Inputs.Length - 1;
while (print > 0)
{
    Console.WriteLine(Inputs[print]);
        print--;
}
