// Программа, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

Console.WriteLine("Введите значение b1");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение k1");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение b2");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение k2");
double k2 = Convert.ToInt32(Console.ReadLine());
if (k1 == k2 && b1 == b2) Console.WriteLine($"прямые совпадают (формулы одинаковые)");
else if (k1 == k2 && b1 != b2) Console.WriteLine($"прямые параллельны (углы наклона одинаковые, а смещение различно)");
else
{
  double GetDist(double b1, double k1, double b2, double k2)
  {
    return Math.Round(((b2 - b1) / (k1 - k2)), 2);
  }
  double GetDist1(double b1, double k1, double b2, double k2)
  {
    return Math.Round(((k2 * (b2 - b1) / (k1 - k2)) + b2), 2);
  }
  Console.Write("Прямые пересекаются в точке " + $"({GetDist(b1, k1, b2, k2)}" + "; " + $"{GetDist1(b1, k1, b2, k2)})");
}