using System;

namespace SortAlgorithms_NET
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 10, 5, 1, 7, 4, 9, 8, 6, 2, 3 };
            Console.Write("Before: ");
            Print(array);

            Console.ReadLine();
        }

        static void Print<T>(T[] array)
        {
            if (array.Length > 0)
            {
                Console.Write(array[0]);
                for (int i = 1; i < array.Length; i++)
                {
                    Console.Write(" " + array[i]);
                }
                Console.WriteLine();
            }
        }
    }
}
