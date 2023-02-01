// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3


int[] InputNums(int countNums)
{
    int[] array = new int[countNums];
    int count = 0;                      // Нужна лишь для фиксации сколько осталось ввести чисел
    for (int i = 0; i < countNums; i++)
    {
        System.Console.Write($"Введите число: ");
        int num = Convert.ToInt32(Console.ReadLine());
        array[i] = num;
        count++;
        System.Console.WriteLine($"Вы ввели {count}/{countNums}");
    }
    return array;
}

void PrintArray(int[] array)
{
    System.Console.WriteLine($"[{string.Join(",", array)}]");
}

int NumLargeZero(int[] array)
{
    int countNumLargeZero = 0;
    foreach (var item in array)
    {
        if (item > 0)
        {
            countNumLargeZero++;
        }
    }
    return countNumLargeZero;
}

// Вариант обработки вводимых значений

// int InputNumber()
// {
//     int number;
//     while(true)
//     {
//         if (int.TryParse(Console.ReadLine(),out number))
//         {
//             break;
//         }
//     System.Console.WriteLine("Введено не корректное число, попробуйте еще раз");
//     }
//     return number;
// }

// int[] InputNums(int countNums)
// {
//     int[] array = new int[countNums];
//     int count = 0;                      // Нужна лишь для фиксации сколько осталось ввести чисел
//     for (int i = 0; i < countNums; i++)
//     {
//         System.Console.Write($"Введите число: ");
//         int num = InputNumber();
//         array[i] = num;
//         count++;
//         System.Console.WriteLine($"Вы ввели {count}/{countNums}");
//     }
//     return array;
// }

int[] array = InputNums(5);
PrintArray(array);
System.Console.WriteLine($"Кол-во чисел больше 0 = {NumLargeZero(array)}");