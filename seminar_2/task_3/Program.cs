// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет


// Первый вариант

System.Console.Write("Введите цифру: ");
int num = Convert.ToInt32(Console.ReadLine());
switch(num)
{
    case 1:
    case 2:
    case 3:
    case 4:
    case 5:
        System.Console.WriteLine("Рабочий День");
        break;
    case 6:
    case 7:
        System.Console.WriteLine("Выходной день");
        break;
    default:
        System.Console.WriteLine("Такого дня недели не существует");
        break;
}
       

// Второй вариант

// System.Console.Write("Введите цифру: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int[] array = {0,1,2,3,4,5,6,7};
// if (num <= 0 || num > 7)
// {
//     System.Console.WriteLine("Такого дня недели не существует");
// }
// else
// {
//     switch(array[num])
//     {
//         case 6:
//         case 7:
//             System.Console.WriteLine("Выходной день");
//             break;
//         default:
//             System.Console.WriteLine("Рабочий День");
//             break;
//     }
// }