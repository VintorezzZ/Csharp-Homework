using System;

namespace _1._2
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
            int[,] mat = new int[matrix1.GetLength(0), matrix2.GetLength(1)];


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

            ArraysSum(matrix1, matrix2); // вызов метода

            Console.ReadKey();
        }

        /// <summary>
        /// метод, принимающий две матрицу, возвращающий их сумму
        /// </summary>
        /// <param name="matrix1"></param>
        /// <param name="matrix2"></param>
        /// <returns></returns>
        static int[,] ArraysSum(int[,] matrix1, int[,] matrix2)
        {
            Console.WriteLine("Складываем матрицу1 и матрицу2: ");
            int[,] mat = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

            if (matrix1.GetLength(1) != matrix2.GetLength(1) && matrix1.GetLength(0) != matrix2.GetLength(0))
            {
                Console.WriteLine("\nМатрицы нельзя сложить");
            }
            else
            {
                for (int i = 0; i < matrix2.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix2.GetLength(1); j++)
                    {
                        mat[i, j] = matrix1[i, j] + matrix2[i, j];
                        Console.Write($"{mat[i, j],4}");
                    }
                    Console.WriteLine();
                }

            }
            return mat;
        }

    }
}
