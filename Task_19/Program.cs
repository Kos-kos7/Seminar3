﻿// Напишите программу, которая принимает на
// вход пятизначное число и проверяет, является ли оно
// палиндромом.

Console.WriteLine("Введите целое положительное пятизначное число =>");
int[] n = int.Parse(Console.ReadLine());

    for (int i = 0; i < n.Length / 2; ++i)
        if (n[i] == n[n.Length - 1 - i]) Console.WriteLine("Число не является палиндромом");
    Console.WriteLine("Число является палиндромом");