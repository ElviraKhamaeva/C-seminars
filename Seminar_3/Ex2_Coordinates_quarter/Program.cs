// Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).
// 2 | 1
// 3 | 4

Console.WriteLine("Введите четверть координат (1, 2, 3, 4)");
int num = Convert.ToInt32(Console.ReadLine());

if (num == 1)
{
    Console.WriteLine("x > 0, y > 0");
}

else if (num == 2)
{
    Console.WriteLine("x < 0, y > 0");
}

else if (num == 3)
{
    Console.WriteLine("x < 0, y < 0");
}

else if (num == 4)
{
    Console.WriteLine("x > 0, y < 0");
}

else
{
    Console.WriteLine("Fail");
}

