using System;

namespace _1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введи кол-во строк матрицы 1: ");
            int row1 = int.Parse(Console.ReadLine());
            Console.Write("Введи кол-во столбов матрицы 1: ");
            int col1 = int.Parse(Console.ReadLine());
            Console.Write("Введи кол-во строк матрицы 2: ");
            int row2 = int.Parse(Console.ReadLine());
            Console.Write("Введи кол-во столбов матрицы 2: ");
            int col2 = int.Parse(Console.ReadLine());

            int[,] matrix1 = new int[row1, col1];
            int[,] matrix2 = new int[row2, col2];
            int[,] mat = new int[matrix1.GetLength(0), matrix1.GetLength(1)];

            Random r = new Random();

            Console.WriteLine("Генерируем матрицу1: ");

            for (int i = 0; i < row1; i++)
            {
                for (int j = 0; j < col1; j++)
                {
                    matrix1[i, j] = r.Next(10);
                    Console.Write($"{matrix1[i, j],4}");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Генерируем матрицу2: ");

            for (int i = 0; i < row2; i++)
            {
                for (int j = 0; j < col2; j++)
                {
                    matrix2[i, j] = r.Next(10);
                    Console.Write($"{matrix2[i, j],4}");
                }
                Console.WriteLine();
            }

            try
            {
                mat = Multiplication(matrix1, matrix2); // вызываем метод
                Console.WriteLine("\nМатрица C = A * B:");
                Print(mat);
            }

            catch
            {
                Console.WriteLine("\nМатрицы нельзя перемножить!!!");
            }

            Console.ReadKey();
        }

        /// <summary>
        /// метод, принимающий две матрицу, возвращающий их произведение
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        static int[,] Multiplication(int[,] a, int[,] b)
        {

            if (a.GetLength(1) != b.GetLength(0)) throw new ArgumentException("Матрицы нельзя перемножить");
            int[,] r = new int[a.GetLength(0), b.GetLength(1)];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    for (int k = 0; k < b.GetLength(0); k++)
                    {
                        r[i, j] += a[i, k] * b[k, j];
                    }
                }
            }
            return r;
        }
        /// <summary>
        /// метод, выводящий результат на экрна
        /// </summary>
        /// <param name="a"></param>
        static void Print(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write($"{a[i, j],4}");
                }
                Console.WriteLine();
            }
        }


    }
}
