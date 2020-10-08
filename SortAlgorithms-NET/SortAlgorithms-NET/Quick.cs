using System;

namespace SortAlgorithms_NET
{
    public static class Quick<T> where T : IComparable
    {
        public static T[] Sort(T[] arrayOriginal)
        {
            T[] array = new T[arrayOriginal.Length];
            Array.Copy(arrayOriginal, array, arrayOriginal.Length);
            return Sort(array, 0, array.Length - 1);
        }

        private static T[] Sort(T[] array, int minIndex, int maxIndex)
        {
            if (minIndex >= maxIndex)
            {
                return array;
            }
            var pivotIndex = Partition(array, minIndex, maxIndex);
            Sort(array, minIndex, pivotIndex - 1);
            Sort(array, pivotIndex + 1, maxIndex);

            return array;
        }

        static int Partition(T[] array, int minIndex, int maxIndex)
        {
            var pivot = minIndex - 1;
            for (var i = minIndex; i < maxIndex; i++)
            {
                if (array[i].CompareTo(array[maxIndex]) < 0)
                {
                    pivot++;
                    Swap(ref array[pivot], ref array[i]);
                }
            }

            pivot++;
            Swap(ref array[pivot], ref array[maxIndex]);
            return pivot;
        }

        private static void Swap(ref T x, ref T y)
        {
            T temp = x;
            x = y;
            y = temp;
        }
    }
}
