// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] ArrayFillWithRandomElements(int size, int leftrange, int rightrange)
{
    int[] array = new int[size];
    Random rand = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rand.Next(leftrange,rightrange + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    System.Console.WriteLine($"[{string.Join(",", array)}]");
}

int CountPositivEvenElements(int[] array)
{
    int count = 0;
    foreach (var item in array)
    {
        if (item % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

int[] temp = ArrayFillWithRandomElements(4,100,1000);
PrintArray(temp);
System.Console.WriteLine($"Кол-во четных чисел в массиве = {CountPositivEvenElements(temp)}");

