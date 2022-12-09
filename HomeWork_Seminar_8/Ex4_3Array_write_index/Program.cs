// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] GetArray3D(int[,,] arr)
{
    int[] temp = new int[arr.GetLength(0) * arr.GetLength(1) * arr.GetLength(2)];
    for (int i = 0; i < temp.Length; i++)
    {
        temp[i] = new Random().Next(10, 100);
        if (i > 0)
        {
            for (int k = 0; k < i; k++)
            {
                while (temp[i] == temp[k])
                {
                    temp[i] = new Random().Next(10, 100);
                    k = 0;
                }
            }
        }
    }

    int count = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                arr[i, j, k] = temp[count];
                count++;
            }
        }
    }
    return arr;
}

void PrintArray3D(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(2); i++)
    {
        for (int j = 0; j < arr.GetLength(0); j++)
        {
            for (int k = 0; k < arr.GetLength(1); k++)
            {
                Console.Write($"{arr[j, k, i]} ({j}, {k}, {i})    ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

Console.Clear();
Console.Write("Введите X: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите Y: ");
int y = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите Z: ");
int z = Convert.ToInt32(Console.ReadLine());

if (x * y * z > 90)
{
    Console.WriteLine("Невозможно заполнить массив такого размера неповторяющимися двузначными числами");
}
else
{
    int[,,] array3D = new int[x, y, z];
    PrintArray3D(GetArray3D(array3D));
}


