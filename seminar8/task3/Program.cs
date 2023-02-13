// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] FillMatrixWithRandomNum(int row, int cols)
{
    int[,] matr = new int[row, cols];
    Random rand = new Random();
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            matr[i, j] = rand.Next(2, 5);
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

int[,] MatrixMultiplication(int[,] matrixFirst, int[,] matrixSecond)
{
    int[,] result = new int[2, 2];
    for (int i = 0; i < matrixFirst.GetLength(0); i++)
    {
        for (int j = 0; j < matrixFirst.GetLength(1); j++)
        {
            int num = 0;
            for (int k = 0; k < matrixFirst.GetLength(1); k++)
            {
                num += matrixFirst[i, k] * matrixSecond[k, j];
            }
            result[i, j] = num;
        }

    }
    return result;
}
System.Console.WriteLine("Первая матрица:");
int[,] matrixFirst = FillMatrixWithRandomNum(2, 2);
PrintMatrix(matrixFirst);
System.Console.WriteLine();

System.Console.WriteLine("Вторая матрица:");
int[,] matrixSecond = FillMatrixWithRandomNum(2, 2);
PrintMatrix(matrixSecond);
System.Console.WriteLine();

int[,] multimatr = MatrixMultiplication(matrixFirst,matrixSecond);
System.Console.WriteLine("Произведение двух матриц:");
PrintMatrix(multimatr);