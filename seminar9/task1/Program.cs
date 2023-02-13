// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int SumElement(int m, int n)
{
    if (m < n)
    {
        return n + SumElement(m, n - 1); 
    }
    return n;
}

int num = SumElement(1,15);
System.Console.WriteLine(num);