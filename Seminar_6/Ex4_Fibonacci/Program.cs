// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. 
// Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

Console.WriteLine("Введите  число ");
int num = Convert.ToInt32(Console.ReadLine());
int firstEl = 0;
int secondEl = 1;

Console.WriteLine($"Первые {num} чисел Фибоначчи:");

for (int i = 0; i < num; i++)
{
    Console.Write(firstEl + ", ");
    int nextEl = firstEl + secondEl;
    firstEl = secondEl;
    secondEl = nextEl;
}