// Задача 50. Напишите программу, которая на вход принимает число, 
// возвращает индексы этого элемента в двумерном массиве или же указание, что такого числа нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет


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


int[] SearchNumInMatrix(int[,] matr, int searchNum)
{
    int[] result = new int[2];
    for (int i = 0; i < matr.GetLength(0); i++)
    {

        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (searchNum == matr[i, j])
            {
                result[0] = i;
                result[1] = j;
                goto NumberFound;                         // Использовал goto для того чтобы после нахождения первого элемента завершал метод
            }
        }
    }
    System.Console.WriteLine($"Число {searchNum} в массиве не найдено");
    NumberFound:
        return result;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write($"[{arr[i]}]");
    }
}

int[,] matrix = FillMatrixWithRandomNum(3, 4);
PrintMatrix(matrix);
System.Console.WriteLine();
int[] result = SearchNumInMatrix(matrix, 2);
PrintArray(result);


