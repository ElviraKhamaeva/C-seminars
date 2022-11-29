// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите  число ");
int num = Convert.ToInt32(Console.ReadLine());

int i = 2;

Console.WriteLine("Чётные числа от 1 до " + num + ":");

while (i <= num)
{
    if (num % 2 == 1 && i == num - 1)
    {
        Console.Write(i);
    }
    else if (num % 2 == 0 && i == num)
    {
        Console.Write(i);
    }
    else
    {
        Console.Write(i + ", ");
    }
    i += 2;
}