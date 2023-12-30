// Домашнее задание по простым алгоритмам
// Задача 2
// Условие задачи: Определение координатной четверти
using System;
class program
{
static void Main()
{
Console.WriteLine("ВВедите координаты точек X и Y через пробел");
string[] coordinates = Console.ReadLine().Split();
int x = Convert.ToInt32(coordinates[0]);
int y = Convert.ToInt32(coordinates[1]);
if (x > 0 && y > 0)
{
    Console.WriteLine("I");
}
else if (x < 0 && y > 0)
{
    Console.WriteLine("II");
}
else if (x < 0 && y < 0)
{
    Console.WriteLine("III");
}
else if (x > 0 && y < 0)
{
    Console.WriteLine("IV");
}
else
{
    Console.WriteLine("Точка лежит на оси координат");
}
}
}