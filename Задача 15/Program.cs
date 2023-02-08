// Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Clear();

Console.WriteLine("Введите число");

int day = int.Parse(Console.ReadLine()!);

if(day == 1) Console.Write("Понедельник - Рабочий день");
else if(day == 2)Console.Write("Вторник - Рабочий день");
else if(day == 3)Console.Write("Среда - Рабочий день");
else if(day == 4)Console.Write("Черверг - Рабочий день");
else if(day == 5)Console.Write("Пятница - Рабочий день");
else if(day == 6)Console.Write("Суббота - Выходной день");
else if(day == 7)Console.Write("Воскресение - Выходной день");

Console.WriteLine();