// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


int[,] FillMatrixWithRandomNum(int row, int cols)
{
    int[,] matr = new int[row, cols];
    Random rand = new Random();
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            matr[i, j] = rand.Next(0, 9);
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

int[,] SortMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(1); i++)
    {
        for (int j = 0; j < matr.GetLength(0); j++)
        {
            for (int k = 0; k < matr.GetLength(1) - 1; k++)
            {
                if(matr[j,k] < matr[j,k + 1])
                {
                    int temp = matr[j,k + 1];
                    matr[j,k + 1] = matr[j,k];
                    matr[j,k] = temp; 
                }
            }
        }
    }
    return matr;
}


int[,] matrix = FillMatrixWithRandomNum(4,3);
PrintMatrix(matrix);
System.Console.WriteLine();
int[,] matr = SortMatrix(matrix);
PrintMatrix(matr);

