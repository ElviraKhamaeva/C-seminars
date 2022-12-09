// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

int[,] Multiply2Arrays(int[,] arr1, int[,] arr2)
{
    int[,] resultArr = new int[arr1.GetLength(0), arr2.GetLength(1)];
    for (int i = 0; i < resultArr.GetLength(0); i++)
    {
        for (int j = 0; j < resultArr.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < arr1.GetLength(1); k++)
            {
                sum += arr1[i, k] * arr2[k, j];
            }
            resultArr[i, j] = sum;
        }
    }
    return resultArr;
}

Console.Clear();
Console.Write("Введите количество строк 1ой матрицы: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов 1ой матрицы: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество строк 2ой матрицы: ");
int p = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов 2ой матрицы: ");
int r = Convert.ToInt32(Console.ReadLine());

if (n != p)
{
    Console.WriteLine("Для этих матриц произведение посчитать невозможно. Произведение 2х матриц определено, если число столбцов 1ой матрицы совпадает с числом строк 2ой матрицы.");
    return;
}

int[,] array1 = new int[m, n];
int[,] array2 = new int[p, r];

PrintArray2(GetArray2(array1));
Console.WriteLine("______________________");
PrintArray2(GetArray2(array2));
Console.WriteLine("______________________");
PrintArray2(Multiply2Arrays(array1, array2));