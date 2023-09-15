// Высокий уровень
// Вариант 13

﻿Console.Write("Введите a: ");
double a = double.Parse(Console.ReadLine());

Console.Write("Введите b: ");
double b = double.Parse(Console.ReadLine());

Console.Write("Введите x: ");
double x = double.Parse(Console.ReadLine());

double R = ((a) / (x - a)) + ((Math.Pow(b, x) + Math.Pow(Math.Cos(x), 3)) / (Math.Pow(Math.Log(a), 3) + 4.5));
Console.WriteLine($"R = {R:F2}");
