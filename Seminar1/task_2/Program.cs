﻿// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

System.Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите третье число: ");
int num3 = Convert.ToInt32(Console.ReadLine());
int num_max = num1;
if (num2 > num_max)
{
    num_max = num2;
}
if (num3 > num_max)
{
    num_max = num3;
}
System.Console.WriteLine($"Max = {num_max}");
