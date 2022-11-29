// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами 
// в случайном порядке.
// [1,0,1,1,0,1,0,0]

//Вариант мой

// int[] GetArray(int size)
// {
//     int[] arr = new int[size];

//     for (int i = 0; i < size; i++)
//     {
//         arr[i] = new Random().Next(0,2);
//     }
//     return arr;
// }

// void PrintArray(int[] arrPr)
// {
//     for (int i = 0; i < arrPr.Length; i++)
//     {
//         Console.Write($"{arrPr[i]} ");
//     }
//     Console.WriteLine();
// }

// int[] array = GetArray(8);
// PrintArray(array);


//Вариант преподавателя
int[] GetArray(int[] array)
{

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 2);
    }
    return array;

}
int[] array = new int[8];
GetArray(array);
Console.Write(String.Join(", ", array));