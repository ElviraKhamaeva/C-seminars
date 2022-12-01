// Задача 39: Напишите программу, которая перевернёт одномерный массив 
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

int[] GetArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 10);
    }
    return arr;
}

int[] TurnOverArray(int[] arr)
{
    for (int i = 0; i < arr.Length / 2; i++)
    {
        int temp = arr[i];
        arr[i] = arr[arr.Length - 1 - i];
        arr[arr.Length - 1 - i] = temp;
    }
    return arr;
}

Console.WriteLine("Какой длины массив создать?");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = new int[size];

GetArray(array);
Console.Write("[");
Console.Write(String.Join(", ", array));
Console.WriteLine("]");

Console.WriteLine("Перевернутый массив:");
Console.Write("[");
Console.Write(String.Join(", ", TurnOverArray(array)));
Console.WriteLine("]");