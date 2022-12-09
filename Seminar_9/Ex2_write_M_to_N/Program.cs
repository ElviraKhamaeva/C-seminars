// Задача 65: Задайте значения M и N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

Console.WriteLine("Введите число M");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число N");
int n = Convert.ToInt32(Console.ReadLine());

if (m > n)
{
    Console.WriteLine("Число M больше N. Невозможно осуществить вывод.");
}
else
{
    Console.Write($"M = {m}; N = {n} -> ");
    Console.WriteLine(PrintNum(m, n));
}

string PrintNum(int start, int end)
{
    if (start == end)
    {
        return end.ToString();
    }
    return (start + ", " + PrintNum(start + 1, end));
}