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
            Console.WriteLine("Получившийся телефонный справочник:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{handBook[i, 0]} \t\t\t {handBook[i, 1]}");
            }
        }
    }
}
