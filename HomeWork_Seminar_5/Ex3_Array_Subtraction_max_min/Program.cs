// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

int[] GetArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-99, 100);
    }
    return arr;
}

int FindMax(int[] arr)
{
    int max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max)
        {
            max = arr[i];
        }
    }
    return max;
}

int FindMin(int[] arr)
{
    int min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min)
        {
            min = arr[i];
        }
    }
    return min;
}

Console.WriteLine("Какой длины массив создать?");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = new int[size];
GetArray(array);
Console.Write("[");
Console.Write(String.Join(", ", array));
Console.WriteLine("]");

if (array.Length>0)
{
int diffMaxMin = FindMax(array) - FindMin(array);    
Console.WriteLine($"Разница между максимальным и минимальным элементов массива равна {diffMaxMin}");
}
else
{
Console.WriteLine($"Массив пустой");    
}


