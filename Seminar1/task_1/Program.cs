// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

System.Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
int num_max = num2;
int num_min = num1;
if (num1 > num2)
{
    num_max = num1;
    num_min = num2;
}
System.Console.WriteLine($"Max = {num_max}\nMin = {num_min}");
