﻿// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// Первое решение

// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int i = 1;
// while (i <= number)
// {
//     Console.WriteLine("Результат: " + (i*i*i));
//     i++;
// }

// Второе решение

// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// for (int i = 1; i <= number; i++)
// {
//     Console.WriteLine($"Результат: {i*i*i}");
// }