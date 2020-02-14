using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            //double[] chisla = { 2, 4, 6, 8 }; // arifmetik progression
            double[] chisla = { 4, 6, 9, 13.5 }; // geometrik progression  
            //double[] chisla = { 4, 6, 9, 13.5555 }; // NOT progression  
            Console.WriteLine("Исходный массив:");
            Console.WriteLine(string.Join(", ", chisla));

            Progrs(chisla);
            Console.ReadKey();
        }

        static void Progrs(double[] chisla)
        {
            double n = 0;
            double k = 0;

            for (int i = 0; i < 1; i++)
            {
                n = chisla[1] - chisla[0];    // коэффициент при вычислении арифм. прогр.
                k = (double)chisla[1] / (double)chisla[0];     // коэффициент при вычислении геом. прогр.
                Console.WriteLine($"\n{chisla[1]}-{chisla[0]} = {n}");
                Console.WriteLine($"{chisla[1]}/{chisla[0]} = {k}");
            }

            for (int i = 0; i < chisla.Length - 1; i++)
            {
                if (chisla[i + 1] != chisla[i] + n & (double)chisla[i + 1] != (double)chisla[i] * k) // условие, при котором массив не является прогрессией
                {
                    Console.WriteLine("\nНе прогрессия");
                    break;
                }
                else if (k == (double)chisla[^1] / (double)chisla[i] & (double)chisla[i + 1] == (double)chisla[i] * k)
                {
                    Console.WriteLine("\nGeometrik progression");
                }
                else if (n == chisla[^1] - chisla[i] & chisla[i + 1] == chisla[i] + n)
                {
                    Console.WriteLine("\nАрифметическая прогрессия");
                }

                #region old v
                //if (k == (double)chisla[^2] / (double)chisla[i] & (double)chisla[i + 1] != (double)chisla[i] * k)
                //{
                //    Console.WriteLine("\nGeometrik progression");
                //}
                //else if (n == chisla[^1] - chisla[i] & chisla[i + 1] != chisla[i] + n)
                //{
                //    Console.WriteLine("\nАрифметическая прогрессия");
                //}

                //for (int i = 0; i < chisla.Length - 1; i++)
                //{
                //    if (chisla[i + 1] != chisla[i] + n & (double)chisla[i + 1] != (double)chisla[i] * k) // условие, при котором массив не является прогрессией
                //    {
                //        Console.WriteLine("Не прогрессия");
                //        break;
                //    }
                //    else if(chisla[i] == chisla[chisla.Length - 1]) //если дошли доконца массива
                //    {
                //        if (k == (double)chisla[^2] / (double)chisla[i])
                //        {
                //            Console.WriteLine("\nGeometrik progression");
                //        }
                //        else if (n == chisla[^1] - chisla[i])
                //        {
                //            Console.WriteLine("\nАрифметическая прогрессия");
                //        }
                //    }
                //} 
                #endregion
            }
        }
    }
}
