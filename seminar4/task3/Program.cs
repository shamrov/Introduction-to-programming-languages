// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]


// По заданию написанно что задает массив из 8 элементов из за этого установил по умолчанию длину массива 8
// Но оставил возможность изменять длину массива

int[] FuncArray(int startNum, int endNum, int lenghtArray = 8)
{
    int[] array = new int[lenghtArray];
    Random rand = new Random();

    for (int i = 0; i < lenghtArray; i++)
    {
        array[i] = rand.Next(startNum,endNum);
    }
    return array;
}

System.Console.WriteLine($"[{string.Join(" ", FuncArray(0,10))}]");
