// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

bool IsNotEqualLines(double x1, double x2, double z1, double z2)
{
    return x1 != x2 || z1 != z2;
}

bool IsNotParallel(double x1, double x2)
{
    return x1 != x2;
}

(double, double) FindIntersection(double x1, double x2, double z1, double z2)
{
    var point = (x: 0.0, y: 0.0);
    point.x = (z2 - z1) / (x1 - x2);
    point.y = x1 * point.x + z1;
    return point;
}

Console.Write("Введите k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
if (IsNotEqualLines(k1, k2, b1, b2))
{
    if (IsNotParallel(k1, k2))
    {
        var coord = (xPoint: 0.0, yPoint: 0.0);
        coord = FindIntersection(k1, k2, b1, b2);
        Console.WriteLine($"Точка пересечения -> ({coord.xPoint}, {coord.yPoint})");
    }
    else Console.WriteLine("Вы ввели параллельные линии, они никогда не пересекутся");
}
else Console.WriteLine("Вы ввели одинаковые линии, они наложенны друг на друга");