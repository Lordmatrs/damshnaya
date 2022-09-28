// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
// формула 3d пространства d = √ (x 1 -x 2) 2 + (y 1 -y 2) 2 + (z 1 -z 2) 2

// Решение готово (но не понятно - double - Math - Sqrt - Pow) Решить нужно на семинаре

Console.Clear();
Console.Write("Введите число:  ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число:  ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число:  ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число:  ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число:  ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число:  ");
int z2 = Convert.ToInt32(Console.ReadLine());
double d=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2)+Math.Pow(z2-z1,2));
Console.Write($"Длина отрезка:  {d}");

