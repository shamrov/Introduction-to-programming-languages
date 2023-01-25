// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

System.Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 0)
{
    for (int i = 1; i <= num; i++)
    {
        System.Console.WriteLine($"{Math.Pow(i , 3)}");
    }
}
else
{
    System.Console.WriteLine($"{num} - не корректное число");
}

