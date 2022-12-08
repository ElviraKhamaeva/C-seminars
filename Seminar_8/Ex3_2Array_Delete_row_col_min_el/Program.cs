// Задача 59: Задайте двумерный массив из целых чисел. 
// Напишите программу, которая удалит строку и столбец, 
// на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:

int minVal = Int32.MaxValue; //присвоили наибольшее из диапазона чисел
int indexRow = 0;
int indexCol = 0;

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

void FindMinElement(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (minVal > arr[i, j])
            {
                minVal = arr[i, j];
                indexRow = i;
                indexCol = j;
            }
        }
    }
}

void PrintArray2WithoutMin(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        if (i != indexRow)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                if (j != indexCol)
                {
                    Console.Write(arr[i, j] + " ");
                }
            }
            Console.WriteLine();
        }

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
FindMinElement(array);
//PrintArray2(TurnArray90(array));
//Console.WriteLine($"{minVal}, {indexRow}, {indexCol}");
PrintArray2WithoutMin(array);