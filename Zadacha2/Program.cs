﻿// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите x1 число: ");
int x1= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y1 число: ");
int y1= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите z1 число: ");
int z1= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите x2 число: ");
int x2= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y2 число: ");
int y2= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите z2 число: ");
int z2= Convert.ToInt32(Console.ReadLine());

var result = Math.Sqrt(Math.Pow(x2 - x1,2) + Math.Pow(y2 - y1,2) + Math.Pow(z2 - z1,2));
Console.WriteLine("Расстояние между точками в 3D пространстве равно: " + Math.Round(result, 2, MidpointRounding.AwayFromZero));
