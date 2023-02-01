// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


System.Console.WriteLine("Введите значение b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите значение k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите значение b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите значение k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

double x = (-b2 + b1) / (-k1 + k2);
double y1 = k1 * x + b1;
double y2 = k2 * x + b2;

System.Console.WriteLine($"Точка пересечения двух прямых:{y1}; {y2}");


//Задание в виде функции 


// void IntersectionTwoLines()
// {
//     int count = 4;
//     double[] arr = new double[count];
//     string[] arrStr = { "b1", "k1", "b2", "k2" };
//     for (int i = 0; i < count; i++)
//     {
//         System.Console.WriteLine($"Введите значение {arrStr[i]}: ");
//         arr[i] = Convert.ToDouble(Console.ReadLine());
//     }
//     double x = (-arr[2] + arr[0]) / (-arr[1] + arr[3]);
//     double y1 = arr[1] * x + arr[0];
//     double y2 = arr[3] * x + arr[2];
//     System.Console.WriteLine($"Точка пересечения двух прямых:{y1}; {y2}");
// }


// IntersectionTwoLines();



