using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Дз_м5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "Ххххоооорррооошшшиий деееннннь";
            Console.WriteLine($"Исходный текст: {s1}\n");


            RemoveDuplicateChars(s1);
            Console.ReadLine();
        }

        static void RemoveDuplicateChars(string s1)
        {
            Console.WriteLine("Текст без дубликатов: \n");
            char symbol = s1[1];
            Console.Write(s1[0]);

            for (int i = 1; i < s1.Length; i++)
            {
                if (s1[i] != symbol)
                {
                    symbol = s1[i];
                    Console.Write(s1[i]);
                }

            }
            #region another tries
            //int i = 0;
            //while (true)
            //{
            //    var tmp = s1[i].ToString();
            //    s1 = s1.Replace(tmp, "");
            //    s1 =s1.Insert(i, tmp);
            //    i++;
            //    if (s1.Length - 1 < i)
            //        break;
            //}
            //Console.WriteLine(s1);
            //Console.WriteLine();




            //Console.WriteLine("Смс без дубликатов:");
            //s1 = new string(s1.Distinct().ToArray());
            //Console.WriteLine(s1);

            //int first = -1;
            //int last = -1;
            //foreach (char ch in s1)
            //{
            //    first = s1.IndexOf(ch);
            //    last = s1.LastIndexOf(ch);
            //    if (first != -1 && last != -1 && first != last)
            //        s1 = s1.Replace(ch.ToString(), "");
            //}
            //Console.Write(s1);






            //string str = "aabbcceeeeeeeeed";
            //str = new string (str.Distinct().ToArray());




            //string _string = "bla bla";
            //char[] arr = _string.ToCharArray();
            #endregion
        }








    }
}