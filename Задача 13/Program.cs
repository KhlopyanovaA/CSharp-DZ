//Напишите программу, которая выводит третью цифру заданного 
//числа или сообщает, что третьей цифры нет.

Console.Clear();

Console.WriteLine("Введите число");

int num = int.Parse(Console.ReadLine()!);

if(num < 100 || num == 0)
{
    Console.WriteLine("Третьей цифры нет");
}
while(num > 1000)
{
    num /=  10;
}
if(num > 100)
{
    num = num % 10;
    Console.WriteLine($"Третья цифра {num}");
}

Console.WriteLine();