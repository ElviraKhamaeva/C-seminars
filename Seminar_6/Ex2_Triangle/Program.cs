// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника 
// меньше суммы двух других сторон.

Console.WriteLine("Введите 1 число");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите 2 число");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите 3 число");
int c = Convert.ToInt32(Console.ReadLine());

if (a < b + c && b < a + c && c < a + b)
{
    Console.WriteLine("Данные числа могут быть сторонами треугольника");
}
else
{
    Console.WriteLine("Данные числа НЕ могут быть сторонами треугольника");
}