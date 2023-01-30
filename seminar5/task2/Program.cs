// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int[] ArrayFill(int size, int leftrange, int rightrange)
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

// Счет начинается с индекса 0 , соответсвенно первый нечетный элемент будет под индексом 1,3,5 и т.д.
int SumElementNotEvenPos(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 1)
        {
            sum += array[i];
        }
    }
    return sum;
}

int[] array = ArrayFill(6,1,10);
PrintArray(array);
System.Console.WriteLine(SumElementNotEvenPos(array));
