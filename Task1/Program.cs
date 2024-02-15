// See https://aka.ms/new-console-template for more information
int i;
var massive = new int[5];
for (i = 0; i < massive.Length; i++)
{
    massive[i] = Convert.ToInt32(Console.ReadLine());
}
for (i = 0; i < massive.Length; i++)
{
    Console.WriteLine(massive[i]);
}
Console.ReadLine();
