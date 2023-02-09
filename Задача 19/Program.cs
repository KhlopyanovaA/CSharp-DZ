// Напишите программу, которая принимает на вход пятизначное 
//число и проверяет, является ли оно палиндромом.

Console.Clear();

Console.WriteLine("Введите пятизначное число");
int num = int.Parse(Console.ReadLine()!);
int num1 = 0;
int num2 = num;
while(num != 0)
{
    num1 = num1 * 10 + num % 10;
    num /= 10;
}
Console.Write(num1 == num2 ? "Число палиндром" : "Число не палиндром");

Console.WriteLine();