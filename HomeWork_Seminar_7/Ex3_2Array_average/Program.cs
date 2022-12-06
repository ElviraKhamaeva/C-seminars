// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

Console.WriteLine();

double[] average = new double[columns];

for (int k = 0; k < average.Length; k++)
{
    double avsum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        avsum += matrix[i, k];
    }
    average[k] = Math.Round(avsum / matrix.GetLength(0), 1);
}

Console.WriteLine($"Среднее арифметическое каждого столбца: {String.Join("; ", average)}");