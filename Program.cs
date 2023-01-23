/*Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.*/

        Console.Write("Введите количество строк: ");
        int rows = int.Parse(Console.ReadLine());
        Console.Write("Введите количество столбцов: ");
        int colm = int.Parse(Console.ReadLine());
        int[,] mas = new int[rows, colm];
        Random random = new Random();
        int[] summ = new int[colm];
        Console.WriteLine();

        for (int i = 0; i < mas.GetLength(0); i++)
        {
            for (int j = 0; j < mas.GetLength(1); j++)
            {
                mas[i, j] = random.Next(0, 10);
               Console.Write("{0,5:F2} ", mas[i, j]);
            }
                Console.WriteLine(" ");
        }
        for (int i = 0; i < mas.GetLength(0); i++)
        {
            for (int j = 0; j < mas.GetLength(1); j++)
            {
                summ[i] += mas[j, i];
            }
            Console.Write(" ");
        }
            foreach (double elem in summ)
            {
            Console.Write($"{elem / colm:N1}");
            }
            
