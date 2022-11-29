// Задача 32: Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие 
// отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

int[] GetArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-9, 10);
    }
    return arr;
}

int[] ChangeSign(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = -arr[i];
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

ChangeSign(array);
Console.Write("[");
Console.Write(String.Join(", ", array));
Console.WriteLine("]");