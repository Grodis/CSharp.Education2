// See https://aka.ms/new-console-template for more information
double[,] massive = { { 1.1, 2.1, 3.1 }, { 2.1, 2.2, 3.2 }, { 3.1, 3.2, 3.3 } };
double sum1 = 0;
for (int i = 0; i < massive.GetLength(0); i++)
{
    for (int j = 0; j < massive.GetLength(1); j++)
    {
        massive[i, j] = Math.Pow(massive[i, j], 2);
        sum1 = sum1 + massive[i, j];
    }
    Console.WriteLine(sum1);
    sum1 = 0;
}
Console.ReadLine();