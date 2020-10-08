using System;

namespace SortAlgorithms_NET
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Before: ");
            int[] array = new int[] { 5, 10, 1, 7, 4, 9, 8, 6, 2, 3, 5};
            Print(array);

            Console.Write("Bubble: ");
            int[] arrayBubble = Bubble<int>.Sort(array);
            Print(arrayBubble);

            Console.Write("Merge: ");
            int[] arrayMerge = Merge<int>.Sort(array);
            Print(arrayMerge);

            Console.Write("Select: ");
            int[] arraySelect = Select<int>.Sort(array);
            Print(arraySelect);

            Console.ReadLine();
        }

        public static void Print<T>(T[] array)
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
