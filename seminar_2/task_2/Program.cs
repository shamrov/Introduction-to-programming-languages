// Задача 13: Напишите программу, которая выводит третью цифру заданного 
//числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


// Первый вариант

System.Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int numLen = num.ToString().Length;
int delNum = num;                               // Переменная нужна лишь для того , чтобы изначальное введенное число осталось не изменный (К примеру дальнейшее использование)
if (numLen < 3)
{
    System.Console.WriteLine($"В числе {num} нету третьей цифры");
}
else
{
    for (;numLen > 3;numLen--)
    {
        delNum /= 10;
    }
    
    System.Console.WriteLine($"Третье число числа {num}: -> {delNum % 10}");
}


// Либо For либо While

    // while (numLen > 3)
    // {
    //     delNum = delNum / 10;
    //     numLen--;
    // }


//Второй вариант

// System.Console.Write("Введите число: ");
// string num = Console.ReadLine();
// if (num.Length >= 3)
// {
//     System.Console.WriteLine($"Третье число числа {num}: -> {num[2]}");
// }
// else
// {
//     System.Console.WriteLine($"В числе {num} нету третьей цифры");
// }
