// Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y),
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
// 2 | 1
// 3 | 4

Console.WriteLine("Введите Х");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите Y");
int y = Convert.ToInt32(Console.ReadLine());

if (x > 0 && y > 0)
{
    Console.WriteLine("1");
}

if (x < 0 && y > 0)
{
    Console.WriteLine("2");
}

if (x < 0 && y < 0)
{
    Console.WriteLine("3");
}

if (x > 0 && y < 0)
{
    Console.WriteLine("4");
}