// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит 
// число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число A");
int A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("В какую степень возвести это число?");
int B = Convert.ToInt32(Console.ReadLine());

double Exponentiation (int n, int k)
{
    double Exp = Math.Pow(n,k); 
    return Exp;
}

Console.WriteLine($"Число {A} в степени {B} равно {Exponentiation(A, B)}");