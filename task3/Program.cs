using System;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            Console.Write("Введите строку: ");
            str = Console.ReadLine();
            for(int i = str.Length-1; i > -1; i--)
            {
                Console.Write($"{str[i]} ");
            }
        }
    }
}
