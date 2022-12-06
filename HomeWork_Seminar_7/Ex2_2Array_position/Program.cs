// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.Clear();
Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[rows, columns];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(0, 10);
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}

Console.Write("Введите позицию по строке искомого элемента: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите позицию по столбцу искомого элемента: ");
int n = Convert.ToInt32(Console.ReadLine());

if (m < matrix.GetLength(0) && n < matrix.GetLength(1))
{
    Console.WriteLine($"Элемент в позиции ({m}, {n}) равен {matrix[m, n]}");
}
else
{
    Console.WriteLine($"Элемента в позиции ({m}, {n}) не существует");
}
