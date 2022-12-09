﻿// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.WriteLine("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Сумма цифр числа {num}  равна {SumNum(num)}");

int SumNum(int n)
{
    if (n == 0)
    {
        return 0;
    }
    return (n % 10 + SumNum(n / 10));
}