// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

double[,] FillMatrixWithRealDigit(int row, int cols, int digits = 2)
{
    double[,] matr = new double[row,cols];
    Random rand = new Random();
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            matr[i,j] = Math.Round(rand.Next(-10,10) + rand.NextDouble(),digits);
        }
    }
    return matr;
}

void PrintMatrixRealDigit(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            System.Console.Write(matr[i,j] + "\t");
        }
    System.Console.WriteLine();
    }
}

double[,] matrix = FillMatrixWithRealDigit(3,4,1);
PrintMatrixRealDigit(matrix);

