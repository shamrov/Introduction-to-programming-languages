// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1


//Первый вариант решения

System.Console.Write("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num.ToString().Length == 3)
{
System.Console.WriteLine($"Второе число {num}:{(num / 10) % 10}"); 
}
else
{
    System.Console.WriteLine($"Число не трехзначное");
}


//Второй вариант решения


// System.Console.Write("Введите трехзначное число: ");
// string num = Console.ReadLine();
// if (num.Length == 3)
// {
//     System.Console.WriteLine($"Второе число числа {num}: {num[1]}"); 
// }
// else
// {
//     System.Console.WriteLine("Введено не правильное значение!");
// }


//Третий вариант решения


// int num = new Random().Next(100,1000);
// System.Console.WriteLine($"Второе число числа {num}: {(num / 10) % 10}"); 