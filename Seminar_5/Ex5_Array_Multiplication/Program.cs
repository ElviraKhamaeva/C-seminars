// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21


int[] GetArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-9, 10);
    }
    return arr;
}

int[] Multiplication(int[] arr)
{
    int[] arr2 = new int[arr.Length / 2 + arr.Length % 2];
    for (int i = 0; i < arr2.Length; i++)
    {
        if (i == arr.Length - 1 - i)
        {
            arr2[i] = arr[i];
        }
        else
        {
            arr2[i] = arr[i] * arr[arr.Length - 1 - i];
        }
    }
    return arr2;
}

Console.WriteLine("Какой длины массив создать?");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = new int[size];

GetArray(array);
Console.Write("[");
Console.Write(String.Join(", ", array));
Console.Write("]");
Console.WriteLine();

Console.WriteLine("Массив из произведений пар чисел (первый и последний, второй и предпоследний и тд):");
Console.Write("[");
Console.Write(String.Join(", ", Multiplication(array)));
Console.Write("]");
Console.WriteLine();


