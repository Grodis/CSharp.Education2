// See https://aka.ms/new-console-template for more information
using System.Runtime.InteropServices;
int i;
var massive = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
Array.Reverse(massive);
for (i = 0; i < massive.Length; i++)
{
    ConsolConsoleApp1e.WriteLine(massive[i]);
}
Console.ReadLine();