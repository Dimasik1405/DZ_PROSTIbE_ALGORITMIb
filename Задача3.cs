// Домашнее задание по простым алгоритмам
// Задача 3
// Условие задачи: Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа.
using System;
class Program
{
static void Main()
{
Console.WriteLine("Введите целое число из отрезка [10, 99]:");
int number = Convert.ToInt32(Console.ReadLine());
int firstDigit = number / 10;
int secondDigit = number % 10;
if (firstDigit > secondDigit)
{
    Console.WriteLine(firstDigit);
}
else if (firstDigit < secondDigit)
{
    Console.WriteLine(secondDigit);
}
else if (firstDigit / secondDigit ==1)
{
Console.WriteLine(secondDigit);
}
}
}