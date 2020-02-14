using System;

namespace _1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введи кол-во строк: ");
            int row = int.Parse(Console.ReadLine());
            Console.Write("Введи кол-во столбов: ");
            int col = int.Parse(Console.ReadLine());
            Console.Write("Введи число: ");
            int x = int.Parse(Console.ReadLine());

            int[,] matrix = new int[row, col];
            int[,] mat = new int[matrix.GetLength(0), matrix.GetLength(1)];
            Random r = new Random();

            Console.WriteLine($"\nГенерируем матрицу {row}*{col}: ");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    matrix[i, j] = r.Next(10);
                    Console.Write($"{matrix[i, j],4}");

                }
                Console.WriteLine();
            }

            Console.WriteLine($"\nУмножение матрицы на число {x}: ");

            MultiplyByNumber(x, matrix); // вызов метода

            Console.ReadKey();
        }

        /// <summary>
        /// метод, принимающий число и матрицу, возвращающий матрицу умноженную на число
        /// </summary>
        /// <param name="x"></param>
        /// <param name="matrix"></param>
        /// <returns></returns>
        static int[,] MultiplyByNumber(int x, int[,] matrix)
        {

            int[,] mat = new int[matrix.GetLength(0), matrix.GetLength(1)];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    mat[i, j] = x * matrix[i, j];
                    Console.Write($"{mat[i, j],4}");
                }
                Console.WriteLine();
            }
            return mat;
        }

    }
}
