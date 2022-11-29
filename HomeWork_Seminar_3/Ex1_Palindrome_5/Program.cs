// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите  пятизначное число ");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 9999 && num < 100000)
{
    string numText = Convert.ToString(num);
    char[] arr = numText.ToCharArray();
    Array.Reverse(arr);
    string numTextRev = new String(arr);

    Console.WriteLine("Перевертыш :" + numTextRev);

    if (numText == numTextRev)
    {
        Console.WriteLine("Число палиндром!");
    }
    else
    {
        Console.WriteLine("Число НЕ палиндром!");
    }
}
else
{
    Console.WriteLine("Число не пятизначное!");
}