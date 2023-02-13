// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] FillMatrixWithRandomNum(int row, int cols)
{
    int[,] matr = new int[row, cols];
    Random rand = new Random();
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            matr[i, j] = rand.Next(1, 3);
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

int SumLineMatrix(int[,] matr)
{
    int resultIndex = 0;
    int sum = int.MaxValue;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        int temp = 0;
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            temp += matr[i,j];
        }
        if (temp < sum)
        {
            sum = temp;
            resultIndex = i;
        }

    }
    return resultIndex;
}

int[,] matrix = FillMatrixWithRandomNum(4,4);
PrintMatrix(matrix);
System.Console.WriteLine();
int result = SumLineMatrix(matrix);
System.Console.WriteLine($"Строка с наименьшей суммой элементов: {result}");