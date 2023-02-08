// Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.

Console.Clear();

Console.WriteLine("Введите трехзначное число");

int num = Convert.ToInt32(Console.ReadLine()!);

{
Console.WriteLine("Вторая цифра = " + num / 10 % 10 );
}

Console.WriteLine();
    