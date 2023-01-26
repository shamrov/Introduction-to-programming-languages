// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

int InputNumber(string str)
{
    int number;
    while(true)
    {
        System.Console.Write(str);
        if (int.TryParse(Console.ReadLine(),out number))
        {
            break;
        }
    System.Console.WriteLine("Введено не корректное число, попробуйте еще раз");
    }
    return number;
}

int SumOneNum(int num)
{
    int result = 0;
    while(num > 0)
    {
        result += num % 10;
        num /= 10;
    }
    return result;
}

// Второй варинт

// int SumOneNum(int num)
// {
//     int result = 0;
//     string numString = Convert.ToString(num);
//     foreach (var i in numString)
//     {
//         result += i-'0';
//     }
//     return result;
// }

// Третий вариант (Решил побаловаться с конвертациями)

// int SumOneNum(int num)
// {
//     int result = 0;
//     string numString = Convert.ToString(num);
    
//     for (int i = 0; i < numString.Length; i++)
//     {
//         result += Convert.ToInt32(Convert.ToString(numString[i]));
//     }
//     return result;
// }

int num = InputNumber("Введите число: ");
System.Console.WriteLine(SumOneNum(num));


