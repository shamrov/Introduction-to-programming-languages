// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int[,] FillMatrixWithRandomNum(int row, int cols)
{
    int[,] matr = new int[row, cols];
    Random rand = new Random();
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            matr[i, j] = rand.Next(0,100);
        }
    }
    return matr;
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            System.Console.Write(matr[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

double[] AverageMatrix(int[,] matr, int decimals = 1)
{
    double[] result = new double[matr.GetLength(1)];
    for (int i = 0; i < matr.GetLength(1); i++)
    {
        int count = 0;
        for (int j = 0; j < matr.GetLength(0); j++)
        {
            result[i] += matr[j,i];
            count++; 
        }
        result[i] = Math.Round(result[i] / count, decimals);
    }
    return result;
}

void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write($"[{arr[i]}]\t");
    }
}

int[,] matrix = FillMatrixWithRandomNum(3, 4);
PrintMatrix(matrix);
double[] res = AverageMatrix(matrix);
PrintArray(res);
