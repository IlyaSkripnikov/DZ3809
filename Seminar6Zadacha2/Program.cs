//Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
int InputInt(string msg)
{
    System.Console.Write($"{msg}");
    return int.Parse(Console.ReadLine());
}
(double, double) IntersectionPoint(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    return (x, y);
}
int b1 = InputInt("Введите b1: ");
int k1 = InputInt("Введите k1: ");
int b2 = InputInt("Введите b2: ");
int k2 = InputInt("Введите k2: ");
(double x, double y) = IntersectionPoint(b1, k1, b2, k2);
Console.WriteLine($"Пересечение в точке: ({x}; {y})");