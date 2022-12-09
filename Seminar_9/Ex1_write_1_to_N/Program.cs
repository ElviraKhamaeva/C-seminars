// Задача 63: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

Console.WriteLine("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());

Console.Write($"N = {num} -> ");
Console.WriteLine(PrintNum(1, num));

string PrintNum(int start, int end)
{
    if (start == end)
    {
        return end.ToString();
    }
    return (start + ", " + PrintNum(start + 1, end));
}