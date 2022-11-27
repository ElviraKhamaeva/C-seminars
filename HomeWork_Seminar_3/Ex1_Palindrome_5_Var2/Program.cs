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
    int[] numArray = new int[numText.Length];
    for( int i=0; i< numText.Length; i++)
        {
            numArray[i] = int.Parse(numText[i].ToString());
        }

    Array.Reverse(numArray);
    int[] numArrayRev = numArray;

    string numTextRev = string.Concat(numArrayRev);
    Console.WriteLine("Перевертыш: " + numTextRev);

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