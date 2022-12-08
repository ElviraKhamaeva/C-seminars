// Задача 53: Задайте двумерный массив. Напишите программу, 
// которая поменяет местами первую и последнюю строку массива

int[,] GetArray2(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(0, 10);
        }
    }
    return arr;
}

void PrintArray2(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void ChangeRows(int[,] arr)
{
    int rowsCount = arr.GetLength(0) - 1;
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        int temp = arr[0, i];
        arr[0, i] = arr[rowsCount, i];
        arr[rowsCount, i] = temp;
    }
}

Console.Clear();
Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[rows, columns];

PrintArray2(GetArray2(array));
Console.WriteLine("________________________");
ChangeRows(array);
PrintArray2(array);
