using System;

namespace _2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Создать метод, принимающий  текст и возвращающий слово, содержащее минимальное количество букв
            //string data = Console.ReadLine();
            String cmc = "A ББ ВВВ ГГГГ ДДДД v ДД ЕЕ ЖЖ ЗЗЗ И";
            Console.WriteLine(cmc);

            MinWord(cmc);
            Console.ReadKey();
        }

        static void MinWord(string cmc)
        {
            char[] chars = { ' ', '!', '-', ',' }; // сюда засовываешь элементы, которыми могут разделятся слова

            string[] words = cmc.Split(chars); // создаем массив, в котором элементами будут считаться те, которые разделены указанными символами

            int max = 0;
            int min = 0;
            for (int i = 0; i < words.Length; i++)
            {
                // Первый шаг, найти строку с мax. символами и запомнить его размер

                if (words[i].Length > max)
                {
                    max = words[i].Length;
                }
            }

            for (int i = 0; i < words.Length; i++)
            {
                // шаг 2, находим строку с мин. символами 

                if (words[i].Length < max)
                {
                    min = words[i].Length;

                }
            }

            for (int i = 0; i < words.Length; i++)
            {
                // шаг 3, выводить те слова, длина которых равна переменной min

                if (words[i].Length == min)
                {
                    Console.WriteLine("Самое короткое слово в предложениu это: " + words[i]);
                }

            }
        }
    }
}
