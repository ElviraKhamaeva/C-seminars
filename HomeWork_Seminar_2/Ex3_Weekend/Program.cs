// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());


if (num < 1 || num > 7)
{
   Console.WriteLine("Ошибка, такого дня недели нет!"); 
}
else
{
    if (num == 6 || num == 7)
    {
        Console.WriteLine("Да, выходной день!");
    }
    else
    {
        Console.WriteLine("Нет, будний день...");
    }
}