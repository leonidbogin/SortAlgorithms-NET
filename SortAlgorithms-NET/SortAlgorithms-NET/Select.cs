using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithms_NET
{
    public static class Select<T> where T : IComparable
    {
        public static T[] Sort(T[] arrayOriginal)
        {
            T[] array = new T[arrayOriginal.Length];
            Array.Copy(arrayOriginal, array, arrayOriginal.Length);

            for (int i = 0; i < array.Length; i++)
            {
                int indexMin = i;
                for (int j = i+1; j < array.Length; j++)
                {
                    if (array[indexMin].CompareTo(array[j]) > 0) indexMin = j;
                }
                if (indexMin != i) Swap(ref array[indexMin], ref array[i]);
            }
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
