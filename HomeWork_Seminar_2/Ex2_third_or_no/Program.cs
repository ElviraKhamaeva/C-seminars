// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int num = new Random().Next(10,10000);
Console.WriteLine("Число " + num);

string numText = Convert.ToString(num);

if (numText.Length > 2)
{
    Console.WriteLine("Третья цифра числа " + num + " является " + numText[2]);
}
else
{
    Console.WriteLine("У числа " + num + " нет третьей цифры");
}
