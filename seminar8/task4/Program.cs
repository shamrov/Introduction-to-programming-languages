// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


int[,,] FillMatrix3D(int row, int cols, int digits)
{
    int[,,] matr = new int[row, cols, digits];
    Random rand = new Random();
    int nums = 1;
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            for (int k = 0; k < digits; k++)
            {
                matr[i, j, k] = nums * 10 + rand.Next(1,10);
                nums++;
            }
        }
    }
    return matr;
}

void PrintMatrix3D(int[,,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++)
            {
                System.Console.Write($"{matr[i, j, k]}({i},{j},{k})\t");
            }
            System.Console.WriteLine();
        }
    }
}

int[,,] matrix3D = FillMatrix3D(2,2,2);
PrintMatrix3D(matrix3D);
