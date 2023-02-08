// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Clear();

Console.WriteLine("введите число a");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число b");
int b = Convert.ToInt32(Console.ReadLine());
int max, min;

if (a > b)
{
    max = a;
    min = b;
}
else
{
    max = b;
    min = a;
}

Console.WriteLine($"max = {max} > min = {min}");
