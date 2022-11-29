// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.

// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, 
// сумма отрицательных равна -20.

int[] GetArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-9, 10);
    }
    return arr;
}

int PositiveSum(int[] arr)
{
    int positiveSum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            positiveSum += arr[i];
        }
    }
    return positiveSum;
}

int NegativeSum(int[] arr)
{
    int negativeSum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < 0)
        {
            negativeSum += arr[i];
        }
    }
    return negativeSum;
}

int[] array = new int[12];
GetArray(array);
Console.Write("[");
Console.Write(String.Join(", ", array));
Console.Write("]");
Console.WriteLine();

Console.WriteLine($"Сумма положительных элементов массива равна {PositiveSum(array)}");
Console.WriteLine($"Сумма отрицательных элементов массива равна {NegativeSum(array)}");