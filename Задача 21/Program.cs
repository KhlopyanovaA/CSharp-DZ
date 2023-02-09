﻿// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.

Console.Clear();

Console.WriteLine("Введите X1 ");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите y1 ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите z1 ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите X2 ");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите y2 ");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите z2 ");
int z2 = Convert.ToInt32(Console.ReadLine());


double match = Math.Round(Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2)), 2);

Console.WriteLine($"Расстояние между точками {match}");

