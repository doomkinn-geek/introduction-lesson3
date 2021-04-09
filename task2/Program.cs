using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] handBook = new string[5, 2];
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Введите имя: ");
                handBook[i, 0] = Console.ReadLine();
                Console.Write("Введите номер телефона/email: ");
                handBook[i, 1] = Console.ReadLine();
            }
            /*handBook[0, 0] = "doomkinn";
            handBook[0, 1] = "d@ya";
            handBook[1, 0] = "roma";
            handBook[1, 1] = "roman@gmail.com";
            handBook[2, 0] = "alexander";
            handBook[2, 1] = "a@v";
            handBook[3, 0] = "vk";
            handBook[3, 1] = "vk@bk";
            handBook[4, 0] = "faterial";
            handBook[4, 1] = "f@ya.ru";*/
            Console.WriteLine("Получившийся телефонный справочник:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("{0, -25} \t- {1, -15}", handBook[i, 0], handBook[i, 1]);
            }
        }
    }
}
