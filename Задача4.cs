// Домашнее задание по простым алгоритмам
// Задача 4
// Условие задачи: : Напишите программу, которая на вход принимает натуральное число N, 
// а на выходе показывает его цифры через запятую. Допускается вывод цифр в обратном порядке, например: 3462 => 2,6,4,3
using System;
class progra
{
    static void Main()
    {
Console.WriteLine("Введите натуральное число N:");
long N = Convert.ToInt64(Console.ReadLine());
while (N>0)
{
    long currentDigit = N % 10;
    N = N / 10;

if (N > 0)
{
    Console.Write(currentDigit + ",");
}
else
{
    Console.Write(currentDigit);
}
}
    }
}


    
