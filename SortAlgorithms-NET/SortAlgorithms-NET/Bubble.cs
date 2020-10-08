using System;

namespace SortAlgorithms_NET
{
    public static class Bubble<T> where T : IComparable
    {    
        public static T[] Sort(T[] arrayOriginal)
        {
            T[] array = new T[arrayOriginal.Length];
            Array.Copy(arrayOriginal, array, arrayOriginal.Length);
            int numberChanges;
            do
            {
                numberChanges = 0;
                for (int i = 1; i < array.Length; i++)
                {
                    if (array[i - 1].CompareTo(array[i]) > 0)
                    {
                        Swap(ref array[i - 1], ref array[i]);
                        numberChanges++;
                    }
                }
            } while (numberChanges > 0);
            
            return array;
        }

        private static void Swap(ref T x, ref T y)
        {
            T temp = x;
            x = y;
            y = temp;
        }

    }
}
