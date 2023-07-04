﻿// Задача 29: Напишите программу, которая задаёт массив из 8 элементов в диапазоне от 10 до 1000 и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// С КОНСОЛИ

Console.Write("Введите размер массива: ");
int AlphaSize = Convert.ToInt32(Console.ReadLine());
int[] Alpha = new int[AlphaSize];

for (int i = 0; i < Alpha.Length; i++)
{
    Console.Write($"Введите элемент массива {i}:  ");
    Alpha[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine($"Массив: [ {string.Join("; " , Alpha)} ]");