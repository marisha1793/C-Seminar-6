// Задача 43: Напишите программу, которая найдёт точку пересечения 
// двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите координаты первой прямой, k1: ");
double k1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты первой прямой, b1: ");
double b1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты второй прямой, k2: ");
double k2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты второй прямой, b2: ");
double b2 = double.Parse(Console.ReadLine());
GetPointOfIntersection(k1, b1, k2, b2);



void GetPointOfIntersection(double k1, double b1, double k2, double b2)
{
    double x = (b2 - b1)/(k1 - k2);
    double y = k1 * x + b1;
    if (k1 == k2)
    {
        Console.Write("Прямые не пересекаются");
    }
    else
    {
        Console.Write($"Точка пересечения прямых: ({x}; {y})");
    }
}