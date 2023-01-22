/*Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.*/

        Console.Write("Введите количество строк: ");
        int rows = int.Parse(Console.ReadLine());
        Console.Write("Введите количество столбцов: ");
        int colm = int.Parse(Console.ReadLine());
        int[,] mas = new int[rows, colm];
        Random random = new Random();
        int[] summ = new int[colm];
        for (int i = 0; i < mas.GetLength(0); i++)
        {
            for (int j = 0; j < mas.GetLength(1); j++)
                mas[i, j] = random.Next(0, 10);
        }
        for (int i = 0; i < mas.GetLength(0); i++)
        {
            for (int j = 0; j < mas.GetLength(1); j++)
            {
                Console.Write("{0,3:F2}", mas[i, j]); 
                summ[i] += mas[j, i];
            }
            foreach (double elem in summ)
            {
            Console.WriteLine($"{elem / colm}");
            }
            Console.WriteLine();
        }

        //ПОМОГИТЕ ПОЖАЛУЙСТА РАЗОБРАТЬСЯ ЧТО НЕ ТАК С КОДОМ НИ КАК НЕ МОГУ РЕШИТЬ ЭТУ ЗАДАЧУ, ЗА РАНЕЕ СПАСИБО