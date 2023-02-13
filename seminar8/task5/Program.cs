// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] FillMatrixSpiral(int row, int cols)
{
    //Движение вправо j++
    //Движение вниз i++
    //Движение влево j--
    //Движение вверх i--
    int[,] matr = new int[row, cols];
    int i = 0;
    int j = 0;
    int num = 1;
    while (num <= matr.Length)
    {
        matr[i, j] = num;
        num++;
        if (i <= j + 1 && i + j < matr.GetLength(1) - 1)
            j++;
        else if (i < j && i + j >= matr.GetLength(0) - 1)
            i++;
        else if (i >= j && i + j > matr.GetLength(1) - 1)
            j--;
        else
            i--;
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
int[,] matr = FillMatrixSpiral(4, 4);
PrintMatrix(matr);