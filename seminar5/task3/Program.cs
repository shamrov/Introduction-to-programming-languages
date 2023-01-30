// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

double[] ArrayFillNumDouble(int size, int leftrange, int rightrange, int digits = 2)
{
    double[] array = new double[size];
    Random rand = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = Math.Round(rand.Next(leftrange, rightrange + 1) + rand.NextDouble(), digits);
    }
    return array;
}

void PrintArrayNumDouble(double[] array)
{
    System.Console.WriteLine($"[{string.Join(" | ", array)}]");
}

double DifferenceMaxMinNumArray(double[] array, int digits = 2)
{
    double result = 0;
    int minNumIndex = 0;
    int maxNumIndex = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < array[minNumIndex])
        {
            minNumIndex = i;
        }
        else if (array[i] > array[maxNumIndex])
        {
            maxNumIndex = i;
        }
    }
    result = Math.Round(Math.Abs(array[minNumIndex] - array[maxNumIndex]),digits);
    return result;
}


double[] array = ArrayFillNumDouble(5,1,10,2);
PrintArrayNumDouble(array);
System.Console.WriteLine(DifferenceMaxMinNumArray(array));
