// : Напишите программу, которая на вход принимает число и выдает, является ли число четным (делится ли оно на два без остатка).

Console.Clear();

Console.WriteLine("введите число!");
int n = int.Parse(Console.ReadLine()!);

if(n % 2 != 0)
{
   Console.WriteLine("Нечетное число");
}
else
{
    Console.WriteLine("Четное число");
}
