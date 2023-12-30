// Домашнее задание по простым алгоритмам
// Задача 1
// Условие задачи: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
using System;
Console.Write("Введите число a:");
int a = Convert.ToInt32(Console.ReadLine());

if (a % 7 ==0 && a% 23 ==0)
{
    Console.WriteLine("Верно");
}
else
{
     Console.WriteLine("Неверно");
}


