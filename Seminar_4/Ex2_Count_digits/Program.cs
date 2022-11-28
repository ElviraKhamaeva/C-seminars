// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.WriteLine("Введите  число ");
int num = Convert.ToInt32(Console.ReadLine());

int GetCountDigits(int res)
{
    if (res < 0) res = - res;

    int count = 0;
    while (res > 0)
    {
        res /= 10;
        count++;
    }
    return count;        
}

Console.WriteLine($"Количество цифр в числе {num} равно {GetCountDigits(num)}");