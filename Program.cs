/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными 
вещественными числами.*/
double[,] mas = new double[5, 5];
Random random = new Random();
for (int i = 0; i < mas.GetLength(0); i++)
{
for (int j = 0; j < mas.GetLength(1); j++) 
mas[i,j] = random.NextDouble() * 100; 
}
for (int i = 0; i < mas.GetLength(0); i++)
{
for (int j = 0; j < mas.GetLength(1); j++)
Console.Write("{0,8:F}", mas[i,j]); 
Console.WriteLine(); 
}
 
