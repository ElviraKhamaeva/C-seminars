// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

int[] WriteArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write("Введите число: ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
    }
    return arr;
}

int PositiveCount(int[] arr)
{
    int positiveCount = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            positiveCount++;
        }
    }
    return positiveCount;
}


Console.WriteLine("Сколько чисел хотите задать?");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = new int[size];

WriteArray(array);
Console.Write("[");
Console.Write(String.Join(", ", array));
Console.WriteLine("]");

Console.WriteLine($"Количество положительных чисел {PositiveCount(array)}");
