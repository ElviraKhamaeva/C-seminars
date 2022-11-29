// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] GetArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-99, 100);
    }
    return arr;
}

int SumOddPosition(int[] arr)
{
    int sumOdd = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i%2 == 1)
        {
            sumOdd += arr[i];
        }
    }
    return sumOdd;
}

Console.WriteLine("Какой длины массив создать?");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = new int[size];
GetArray(array);
Console.Write("[");
Console.Write(String.Join(", ", array));
Console.WriteLine("]");

Console.WriteLine($"Сумма элементов массива, стоящих на нечётных позициях, равна {SumOddPosition(array)}");