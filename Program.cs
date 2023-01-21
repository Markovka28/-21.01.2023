/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.*/

Console.Write("Введите значение точки b1: ");
float b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение точки k1: ");
float k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение точки b2: ");
float b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение точки k2: ");
float k2 = Convert.ToInt32(Console.ReadLine());

float y = (k2*b1-k1*b2)/(k2-k1);
float x = (b1-b2)/(k2-k1);
if (k1==k2)
{
    Console.Write("Прямые параллельны");
}
else
Console.Write($"Пересечение прямых в координате: ({Math.Round(x,3)}, {Math.Round(y,3)})");