// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

double[] coordA = new double[3];
double[] coordB = new double[3];

System.Console.Write("Введите координату X точки A: ");
coordA[0] = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координату Y точки A: ");
coordA[1] = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координату Z точки A: ");
coordA[2] = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите координату X точки B: ");
coordB[0] = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координату Y точки B: ");
coordB[1] = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координату Z точки B: ");
coordB[2] = Convert.ToInt32(Console.ReadLine());

double result = Math.Round(Math.Sqrt(Math.Pow(coordA[0] - coordB[0], 2) + Math.Pow(coordA[1] - coordB[1], 2) + Math.Pow(coordA[2] - coordB[2], 2)), 2);

System.Console.WriteLine(result);

//Конечно такая запись формулы не удобна для чтения и можно было все возведения в степень положить в разные переменные
// Можно сделать так для более понятного чтения , но теряем в производительности
// double num1D = Math.Pow(coordA[0] - coordB[0], 2);
// double num2D = Math.Pow(coordA[1] - coordB[1], 2);
// double num3D = Math.Pow(coordA[2] - coordB[2], 2);

// double result = Math.Round(Math.Sqrt(num1D + num2D + num3D),2);

//Либо такой вариант

// double num3D = 0;
// for (int i = 0; i < coordA.Length; i++)
// {
//     num3D += Math.Pow(coordA[i] - coordB[i], 2);
// }

// double result = Math.Round(Math.Sqrt(num3D),2);

// System.Console.WriteLine(result);