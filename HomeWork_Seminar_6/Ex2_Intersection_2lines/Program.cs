// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();
Console.WriteLine("Уравнения прямых y = k1 * x + b1, y = k2 * x + b2");
Console.Write("Введите коэффициент k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите коэффициент b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите коэффициент k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите коэффициент b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

if ((k1 == k2) && (b1 == b2))
{
    Console.WriteLine("Прямые совпадают");
}
else if (k1 == k2)
{
    Console.WriteLine("Прямые параллельны");
}
else
{
    double x = Math.Round((b2 - b1) / (k1 - k2), 2);
    double y = Math.Round((k1 * (b2 - b1)) / (k1 - k2) + b1, 2);
    Console.WriteLine($"Точка пересечения двух прямых ({x}; {y})");
}