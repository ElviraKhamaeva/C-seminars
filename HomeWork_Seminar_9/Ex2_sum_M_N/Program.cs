// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите начальное число M");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите конечное число N");
int n = Convert.ToInt32(Console.ReadLine());

if (m > n)
{
    Console.WriteLine("Число M больше N. Невозможно осуществить вывод.");
}
else
{
    Console.Write($"M = {m}; N = {n} -> ");
    Console.WriteLine(SumNum(m, n));
}

int SumNum(int start, int end)
{
    if (start == end)
    {
        return end;
    }
    return (start + SumNum(start + 1, end));
}