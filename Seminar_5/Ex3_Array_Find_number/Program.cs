// Задача 33: Задайте массив. Напишите программу, которая определяет, 
// присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

int[] GetArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-9, 10);
    }
    return arr;
}

bool FindNumber(int[] arr, int num)
{
    bool check = false;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == num)
        {
            check = true;
        }
    }
    return check;
}

Console.WriteLine("Какой длины массив создать?");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = new int[size];

GetArray(array);
Console.Write("[");
Console.Write(String.Join(", ", array));
Console.Write("]");
Console.WriteLine();

Console.WriteLine("Какое число ищем?");
int number = Convert.ToInt32(Console.ReadLine());

if (FindNumber(array, number))
{
    Console.WriteLine("Число есть в массиве");
}
else
{
    Console.WriteLine("Числа нет в массиве");   
}



