// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

int num1 = new Random().Next(10,100);
int num2 = new Random().Next(10,100);

// num1 = 5;
// num2 = 25;

Console.WriteLine("Первое число "+ num1); 
Console.WriteLine("Второе число "+ num2); 

if ((num1 == num2*num2)||(num2 == num1*num1))
{
   Console.WriteLine("Числа " + num1 + " и " + num2 + " являются квадратом один другого"); 
}
else
{
   Console.WriteLine("Числа " + num1 + " и " + num2 + " НЕ являются квадратом один другого"); 
}
