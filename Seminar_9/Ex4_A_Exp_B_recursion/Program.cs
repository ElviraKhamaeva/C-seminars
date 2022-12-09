// Задача 69: Напишите программу, которая на вход принимает два числа A и B, 
// и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Console.WriteLine("Введите число A");
int A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("В какую степень возвести это число?");
int B = Convert.ToInt32(Console.ReadLine());

double Exponentiation(int n, int m)
{
    if (m == 0)
    {
        return 1;
    }
    if (m == 1)
    {
        return n;
    }
    return n * Exponentiation(n, m - 1);
}

Console.WriteLine($"Число {A} в степени {B} равно {Exponentiation(A, B)}");