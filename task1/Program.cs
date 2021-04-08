using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            const int aSize = 10;
            int[,] arr = new int[aSize, aSize];
            var rand = new Random();
            for (int i = 0; i < aSize; i++)
            {
                for (int j = 0; j < aSize; j++)
                {
                    arr[i, j] = rand.Next(50);
                    Console.Write($"{arr[i, j]}\t");                    
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine("Элементы массива из диагонали:");
            for (int j = 0; j < aSize; j++)
            {
                Console.Write($"{arr[j, j]}\t");
            }
        }
    }
}
