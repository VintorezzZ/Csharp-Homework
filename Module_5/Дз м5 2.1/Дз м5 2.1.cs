using System;

namespace Дз_м5_2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //string data = Console.ReadLine();
            String cmc = "A ББ ВВВ ГГГГ ДДДД  ДД ЕЕ ЖЖ ЗЗЗ";
            Console.WriteLine(cmc);

            MaxWord(cmc);
            Console.ReadKey();
        }

        static void MaxWord(string cmc)
        {            
            char[] chars = { ' ', '!', '-', ',' }; // сюда засовываешь элементы, которыми могут разделятся слова

            string[] words = cmc.Split(chars); // создаем массив, в котором элементами будут считаться те, которые разделены указанными символами
                                    
            int max = 0;

            for (int i = 0; i < words.Length; i++)
            {
                // Первый шаг, найти строку с макс. символами и запомнить его размер

                if (words[i].Length > max)
                {
                    max = words[i].Length;
                }                      
            }
            
            for (int i = 0; i < words.Length; i++)
            {
                // шаг 2, выводить те слова, длина которых равна переменной max

                if (words[i].Length == max)
                {
                    Console.WriteLine("Самое длинное слово(а) в предложениu это: " + words[i]);
                }
            }

                                 
            #region another tries
            //for (int i = 1; i < words.Length; i++) 
            //{


            //    string word = words[i]; // создали переменную, которая содержит значение в индексе

            //    if (word.Length > words[m].Length) // если длина следующего слова больше предыдущего 
            //    {
            //        m = i; //передаем индекс    

            //    }

            //}
            //Console.WriteLine("Самое длинное слово в предложениu это: " + words[m]);
            //return words[m];





            //foreach (string word in words)
            //           {
            //               if (word.Length > wordLength)
            //               {
            //                   wordLength = word.Length;
            //                   maxW = word;
            //                   Console.WriteLine("Слово максимальной длины - {0}, длина - {1}", maxW, wordLength);
            //               }


            //           }
            #endregion
        }
    }
}


 