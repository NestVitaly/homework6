// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.

Console.Write("Введите число b1 - ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b2 - ");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число k1 - ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число k2 - ");
int k2 = Convert.ToInt32(Console.ReadLine());
if (b1 == b2 && k1 == k2)
{
    Console.Write("Прямые равны");
}
else if (k1 == k2)
{
    Console.Write("Прямые параллельны");
}
else Console.Write($"x({xValue(b1, b2, k1, k2)}), y({yValue(b1, b2, k1, k2)})");

int xValue (int b1, int b2, int k1, int k2)
{
    int x = (b2 - b1) / (k1 - k2);
    return x;
}
int yValue (int b1, int b2, int k1, int k2)
{
    int y = k1 * xValue(b1, b2, k1, k2) + b1;
    int result = y;
    return result;
}
